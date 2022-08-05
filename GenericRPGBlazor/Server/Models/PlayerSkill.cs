namespace GenericRPGBlazor.Server.Models
{
    public class PlayerSkill : EntityBase
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public double CurrentLevel { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
