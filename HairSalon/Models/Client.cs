using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Client
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ApptDate { get; set; }
    public string Services { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }

  }
}
