namespace GenericRPGBlazor.Shared.DTO
{
    public class PlayerDTO
    {
        public int Id { get; set; }
        public int Xp { get; set; }
        public int Hp { get; set; }
        public int Mana { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int Perception { get; set; }
        public int RaceId { get; set; }
        public RaceDTO Race { get; set; }
        public int Level { get; set; }
        public int Stamina { get; set; }
        public List<PlayerSkillDTO> Skills { get; set; } 
    }
}
