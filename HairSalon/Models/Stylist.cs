using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        private static List<Stylist> _instances = new List<Stylist> { };
        public string Name { get; set; }
        public int Id { get; }
        public List<Client> Clients { get; set; }

        public Stylist(string stylistName)
        {
            Name = stylistName;
            _instances.Add(this);
            Id = _instances.Count;
            Clients = new List<Client> { };
        }
    }
}