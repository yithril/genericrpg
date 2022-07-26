namespace GenericRPGBlazor.Server.Models
{
    public class RaceSkill : EntityBase
    {
        public int RaceId { get; set; }
        public Race Race { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
