namespace GenericRPGBlazor.Server.Models
{
    public class Spell : EntityBase
    {
        public string Name { get; set; }
        public int ManaCost { get; set; }
    }
}
