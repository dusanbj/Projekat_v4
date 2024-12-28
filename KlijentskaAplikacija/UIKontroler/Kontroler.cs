using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zajednicki;

namespace KlijentskaAplikacija.UIKontroler
{
    internal class Kontroler
    {
        private static Kontroler instance;

        public static Kontroler Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Kontroler();
                }
                return instance;
            }
        }
        private Kontroler()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private Socket soket;
        private JsonNetworkSerializer serializer;

        public void PoveziSe()
        {
            try
            {
                soket.Connect("127.0.0.1", 9999);
                serializer = new JsonNetworkSerializer(soket);


            }
            catch (SocketException)
            {
                throw new Exception("Neuspesno povezivanje sa serverom!");
            }
        }

        public Zaposleni Login(Zaposleni zap)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.Login,
                    Podaci = zap
                };
                serializer.Send(z);
                Odgovor o = serializer.Receive<Odgovor>();

                if (o.Signal)
                {
                    Zaposleni zaposleni = serializer.ReadType<Zaposleni>(o.Podaci);
                    return zaposleni;
                }
                else
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (SocketException)
            {
                throw new Exception("Doslo je do greske u komunikaciji!");
            }
            catch (IOException)
            {
                throw new Exception("Doslo je do greske u komunikaciji!");
            }

        }

        internal List<Mesto> VratiMesta()
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.VratiMesta,
            };
            serializer.Send(z);
            Odgovor o = serializer.Receive<Odgovor>();

            if (o.Signal)
            {
                List<Mesto> result = serializer.ReadType<List<Mesto>>(o.Podaci);
                return result;
            }
            else
            {
                throw new Exception(o.Poruka);
            }
        }

        internal void SacuvajSveKlijente(List<Klijent> klijenti)
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.SacuvajSveKlijente,
                Podaci = klijenti
            };
            serializer.Send(z);
            Odgovor o = serializer.Receive<Odgovor>();
            if(!o.Signal)
            {
                throw new Exception(o.Poruka);
            }
        }

        internal void dodajKlijenta(Klijent klijent)
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.SacuvajKlijenta,
                Podaci = klijent
            };
            serializer.Send(z);
            Odgovor o = serializer.Receive<Odgovor>();
            if (!o.Signal)
            {
                throw new Exception(o.Poruka);
            }
        }

        internal void dodajRobu(Roba r)
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.SacuvajRobu,
                Podaci = r
            };
            serializer.Send(z);
            Odgovor o = serializer.Receive<Odgovor>();
            if (!o.Signal)
            {
                throw new Exception(o.Poruka);
            }
        }

        internal List<Roba> vratiRobu()
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.VratiRobu
            };
            serializer.Send(z);
            Odgovor o = serializer.Receive<Odgovor>();
            if (o.Signal)
            {
                List<Roba> result = serializer.ReadType<List<Roba>>(o.Podaci);
                return result;
            }
            else
            {
                throw new Exception(o.Poruka);
            }
        }

        internal void dodajMesto(Mesto m)
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.SacuvajMesto,
                Podaci = m
            };
            serializer.Send(z);
            Odgovor o = serializer.Receive<Odgovor>();
            if (!o.Signal)
            {
                throw new Exception(o.Poruka);
            }
        }
        internal List<Klijent> VratiKlijente()
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.VratiKlijente,
            };
            serializer.Send(z);
            Odgovor o = serializer.Receive<Odgovor>();

            if (o.Signal)
            {
                List<Klijent> result = serializer.ReadType<List<Klijent>>(o.Podaci);
                return result;
            }
            else
            {
                throw new Exception(o.Poruka);
            }
        }
    }
}
