namespace HairSalon.Models
{
  public class Client
  {
    public string Name { get; set; }
    public int ClientId { get; set; }

    public virtual Client client { get; set; }
  }
}