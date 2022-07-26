namespace GenericRPGBlazor.Server.Models
{
    public abstract class Living : EntityBase
    {
        public int Hp { get; set; }
        public int Mana { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int Perception { get; set; }
        public int RaceId { get; set; }
        public Race Race { get; set; }
        public int Level { get; set; }
        public int Stamina { get; set; }
    }
}
