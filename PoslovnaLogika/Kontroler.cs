using BrokerBP = BrokerBazePodataka.BrokerBazePodataka;
using Domen;
using System.Reflection.Metadata;

namespace PoslovnaLogika
{
    public class Kontroler
    {
        private BrokerBP bbp = new BrokerBP();
        public Zaposleni Login(Zaposleni u)
        {
            bbp.Connect();
            try
            {
                Zaposleni dbUser = bbp.GetZaposleniByUserPass(u);
                return dbUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public List<Klijent> VratiKlijente()
        {
            try
            {
                bbp.Connect();
                return bbp.VratiKlijente();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public void DodajMesto(Mesto m)
        {
            try
            {
                bbp.Connect();
                bbp.DodajMesto(m);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public void DodajRobu(Roba r)
        {
            try
            {
                bbp.Connect();
                bbp.DodajRobu(r);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public void PromeniRobu(Roba r, long id)
        {
            try
            {
                bbp.Connect();
                bbp.IzmeniRobu(r,id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public List<Roba> VratiRobu()
        {
            try
            {
                bbp.Connect();
                return bbp.VratiRobu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public Klijent VratiKlijenta(long id)
        {
            //implementirati danas
            throw new NotImplementedException();
        }

        public void DodajKlijenta(Klijent k)
        {
            bbp.Connect();
            try
            {
                bbp.DodajKlijenta(k);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public List<Mesto> VratiMesta()
        {
            try
            {
                bbp.Connect();
                return bbp.VratiMesta();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public void SacuvajSveKlijente(List<Klijent> osobe)
        {
            bbp.Connect();
            try
            {
                bbp.SacuvajSveKlijente(osobe);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }
    }
}
