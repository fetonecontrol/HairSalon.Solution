using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public Stylist()
        {
            this.Client = new HashSet<Client>();
        }

        public int StylistId { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Specialty { get; set; }
        public virtual ICollection<Client> Client { get; set; }
    }
}