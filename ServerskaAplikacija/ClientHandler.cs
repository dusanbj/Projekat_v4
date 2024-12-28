using Domen;
using PoslovnaLogika;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Sockets;
using System.Text.Json;
using Zajednicki;

internal class ClientHandler
{
    private Socket klijentSoket;
    private JsonNetworkSerializer serializer;
    private Kontroler k = new Kontroler();

    public ClientHandler(Socket klijentSoket)
    {
        this.klijentSoket = klijentSoket;
        serializer = new JsonNetworkSerializer(klijentSoket);
    }

    internal void Handle()
    {
        try
        {
            while (true)
            {

                Zahtev z = serializer.Receive<Zahtev>();
                Console.WriteLine($"Stigao je zahtev od klijenta: {z.Operacija}");
                Odgovor o = ProcessRequest(z);
                serializer.Send(o);
                Console.WriteLine("Klijentu je poslat odgovor");
            }
        }
        catch (Exception ex) 
        {
            //obraditi i IOException i SocketException
            Console.WriteLine("Doslo je do greske prilikom citanja zahteva");
            Console.WriteLine(ex.Message);

        }
        finally
        {
            serializer.Close();
            klijentSoket.Shutdown(SocketShutdown.Both);
            klijentSoket.Close();
        }
    }


    private Odgovor ProcessRequest(Zahtev z)
    {
        Odgovor o = new Odgovor()
        {
            Signal = true
        };
        try
        {
            switch (z.Operacija)
            {
                case Operacija.Login:
                    Zaposleni u = serializer.ReadType<Zaposleni>(z.Podaci);
                    Zaposleni odgovor = k.Login(u);
                    o.Podaci = odgovor;
                    o.Poruka = "Korisnik je uspesno prijavljen";
                    break;
                case Operacija.VratiMesta:
                    List<Mesto> result = k.VratiMesta();
                    o.Podaci = result;
                    break;
                case Operacija.SacuvajSveKlijente:
                    List<Klijent> klijenti = serializer.ReadType<List<Klijent>>(z.Podaci);
                    k.SacuvajSveKlijente(klijenti);
                    break;
                case Operacija.VratiKlijente:
                    List<Klijent> resultOsobe = k.VratiKlijente();
                    o.Podaci = resultOsobe;
                    break;
                case Operacija.VratiRobu:
                    List<Roba> resultRoba = k.VratiRobu();
                    o.Podaci = resultRoba;
                    break;
                case Operacija.SacuvajKlijenta:
                    Klijent kl = serializer.ReadType<Klijent>(z.Podaci);
                    k.DodajKlijenta(kl);
                    break;
                case Operacija.SacuvajMesto:
                    Mesto m = serializer.ReadType<Mesto>(z.Podaci);
                    k.DodajMesto(m);
                    break;
                case Operacija.SacuvajRobu:
                    Roba r = serializer.ReadType<Roba>(z.Podaci);
                    k.DodajRobu(r);
                    break;
                default:
                    throw new Exception("Ne postoji operacija!");
            }
        }
        catch (Exception ex) 
        {
            o.Signal = false;
            o.Poruka = ex.Message;
        }
        return o;
    }
}