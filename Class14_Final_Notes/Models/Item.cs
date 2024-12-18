namespace ConsoleRpg.Models;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public decimal Weight { get; set; }
    public int Value { get; set; }
    public virtual ICollection<Monster> Monsters { get; set; } = new List<Monster>();
}