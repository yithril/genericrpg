namespace GenericRPGBlazor.Server.Models
{
    public class PlayerSpell : EntityBase
    {
        public int SpellId { get; set; }
        public Spell Spell { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
