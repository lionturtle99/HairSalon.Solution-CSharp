using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public string Name { get; set; }
    public int Description { get; set; }
    public int StylistId { get; set; }

    public virtual ICollection<Stylist> Stylists { get; set; }

    public Stylist()
    {
        this.Stylists = new HashSet<Stylist>();
    }
  }
}