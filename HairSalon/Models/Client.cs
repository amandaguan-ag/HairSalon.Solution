namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Description { get; set; }

        // public Client(string description)
        // {
        //   Description = description;
        // }
        // public Client(string description, int id)
        // {
        //   Description = description;
        //   Id = id;
        // }

        // public override bool Equals(System.Object otherClient)
        // {
        //   if (!(otherClient is Client))
        //   {
        //     return false;
        //   }
        //   else
        //   {
        //     Client newClient = (Client) otherClient;
        //     bool idEquality = (this.Id == newClient.Id);
        //     bool descriptionEquality = (this.Description == newClient.Description);
        //     return (idEquality && descriptionEquality);
        //   }
        // }

        // public void Save()
        // {
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();
        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;

        //   cmd.CommandText = "INSERT INTO clients (description) VALUES (@ClientDescription);";
        //   MySqlParameter param = new MySqlParameter();
        //   param.ParameterName = "@ClientDescription";
        //   param.Value = this.Description;
        //   cmd.Parameters.Add(param);    
        //   cmd.ExecuteNonQuery();
        //   Id = (int) cmd.LastInsertedId;

        //   conn.Close();
        //   if (conn != null)
        //   {
        //     conn.Dispose();
        //   }
        // }

        // public static Client Find(int id)
        // {
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();

        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //   cmd.CommandText = "SELECT * FROM `clients` WHERE id = @ThisId;";

        //   MySqlParameter param = new MySqlParameter();
        //   param.ParameterName = "@ThisId";
        //   param.Value = id;
        //   cmd.Parameters.Add(param);

        //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        //   int clientId = 0;
        //   string clientDescription = "";
        //   while (rdr.Read())
        //   {
        //     clientId = rdr.GetInt32(0);
        //     clientDescription = rdr.GetString(1);
        //   }
        //   Client foundClient = new Client(clientDescription, clientId);

        //   conn.Close();
        //   if (conn != null)
        //   {
        //     conn.Dispose();
        //   }
        //   return foundClient;
        // }

        // public static List<Client> GetAll()
        // {
        //   List<Client> allClients = new List<Client> { };
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();
        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //   cmd.CommandText = "SELECT * FROM clients;";
        //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        //   while (rdr.Read())
        //   {
        //       int clientId = rdr.GetInt32(0);
        //       string clientDescription = rdr.GetString(1);
        //       Client newClient = new Client(clientDescription, clientId);
        //       allClients.Add(newClient);
        //   }
        //   conn.Close();
        //   if (conn != null)
        //   {
        //       conn.Dispose();
        //   }
        //   return allClients;
        // }

        // public static void ClearAll()
        // {
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();
        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //   cmd.CommandText = "DELETE FROM clients;";
        //   cmd.ExecuteNonQuery();
        //   conn.Close();
        //   if (conn != null)
        //   {
        //    conn.Dispose();
        //   }
        // }
    }
}