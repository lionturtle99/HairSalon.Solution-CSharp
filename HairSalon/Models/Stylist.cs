using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Hours { get; set; }

    public virtual ICollection<Stylist> Stylists { get; set; }

    public Stylist()
    {
        this.Stylists = new HashSet<Stylist>();
    }
  }
}