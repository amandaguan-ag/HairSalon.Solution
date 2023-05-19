using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Client
    {
        public string Description { get; set; }
        private static List<Client> _instances = new List<Client> { };

        public Client(string description)
        {
            Description = description;
            _instances.Add(this);
        }
        public static List<Client> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}