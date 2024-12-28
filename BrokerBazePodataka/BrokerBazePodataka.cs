using Domen;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;

namespace BrokerBazePodataka
{
    public class BrokerBazePodataka
    {
        private SqlConnection connection;
        public void Connect()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=projekat4;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                connection.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("Nije uspesno uspostavljena veza sa bazom podataka!");
                throw;
            }
        }
        public void Disconnect()
        {
            connection?.Close();

        }
        public Zaposleni GetZaposleniByUserPass(Zaposleni z)
        {
            try
            {
                string upit = $"select id, ime, prezime, brTelefona from [zaposleni] where username=@user and password=@pass";
                using SqlCommand cmd = new SqlCommand(upit, connection);
                cmd.Parameters.AddWithValue("user", z.UserName);
                cmd.Parameters.AddWithValue("pass", z.Password);
                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    z.Id = reader.GetInt64(0);
                    z.Ime = reader.GetString(1);
                    z.Prezime= reader.GetString(2);
                    z.BrTelefona = reader.GetString(3);
                    return z;
                }
                else
                {
                    throw new Exception("Ne postoji korisnik sa zadatim podacima!");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Greska pri radu sa bazom!");
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        public List<Klijent> VratiKlijente()
        {
            string upit = "select * from klijent k join mesto m on(k.ptt= m.ptt)";
            SqlCommand cmd = new SqlCommand(upit, connection);
            using SqlDataReader reader = cmd.ExecuteReader();
            List<Klijent> list = new List<Klijent>();
            while (reader.Read())
            {
                Klijent k = new Klijent();
                k.Id = (long)reader["id"];
                k.Ime = (string)reader["prezime"];
                k.Prezime = (string)reader["prezime"];
                k.BrTelefona = (string)reader["brTelefona"];
                k.Mesto = new Mesto();
                k.Mesto.Ptt = (long)reader["ptt"];
                k.Mesto.Naziv = (string)reader["naziv"];
                list.Add(k);
            }
            return list;
        }

        public void SacuvajSveKlijente(List<Klijent> klijenti)
        {
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                string insertQuery = "INSERT INTO klijent (ime, prezime, brTelefona, Ptt) output inserted.id VALUES (@Ime, @Prezime, @BrTelefona, @Ptt)";

                SqlCommand cmd = new SqlCommand(insertQuery, connection, transaction);
                foreach (Klijent k in klijenti)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Ime", k.Ime);
                    cmd.Parameters.AddWithValue("@Prezime", k.Prezime);
                    cmd.Parameters.AddWithValue("@BrTelefona", k.BrTelefona);
                    cmd.Parameters.AddWithValue("@Ptt", k.Mesto.Ptt); 
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }

        }

        public void DodajKlijenta(Klijent k)
        {
            string insertQuery = "INSERT INTO klijent (ime, prezime, brTelefona, Ptt) output inserted.id VALUES (@Ime, @Prezime, @BrTelefona, @Ptt)";

            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@Ime", k.Ime);
                cmd.Parameters.AddWithValue("@Prezime", k.Prezime);
                cmd.Parameters.AddWithValue("@BrTelefona", k.BrTelefona);
                cmd.Parameters.AddWithValue("@Ptt", k.Mesto.Ptt);

                long generatedId = (long)cmd.ExecuteScalar();
                k.Id = generatedId;
            }
        }

        public void DodajMesto(Mesto m)
        {
            try
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"INSERT INTO mesto VALUES ({m.Ptt},'{m.Naziv}')";
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    Console.WriteLine("Uspesno ubaceno mesto!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Neuspesno!");
                throw;
            }
        }

        public void DodajRobu(Roba r)
        {
            try
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"INSERT INTO roba VALUES ('{r.Naziv}','{r.Opis}')";
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    Console.WriteLine("Uspesno ubacena roba!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Neuspesno!");
                throw;
            }
        }

        //da li je potrebno uopste slati i ID ili ne
        //kako u JSONserializeru 
        //opcioni parametri
        public void IzmeniRobu(Roba r, long id) 
        {
            try
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"UPDATE roba SET naziv='{r.Naziv}',opis='{r.Opis}' WHERE id={r.Id}";
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    Console.WriteLine("Uspesno azurirana roba!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Neuspesno!");
                throw;
            }
        }

        public List<Roba> VratiRobu()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from roba";
            using SqlDataReader reader = command.ExecuteReader();
            List<Roba> result = new List<Roba>();
            while (reader.Read())
            {
                Roba r = new Roba();
                r.Id=(long)reader["id"];
                r.Naziv = (string)reader["naziv"];
                r.Opis = (string)reader["opis"];
                result.Add(r);
            }
            return result;
        }

        public List<Mesto> VratiMesta(){
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from mesto";
            using SqlDataReader reader = command.ExecuteReader();
            List<Mesto> result = new List<Mesto>();
            while (reader.Read())
            {
                Mesto m = new Mesto();
                m.Ptt = (long)reader["ptt"];
                m.Naziv = (string)reader["naziv"];
                result.Add(m);
            }
            return result;
        }


    }
}
