namespace GenericRPGBlazor.Shared.DTO
{
    public class PlayerSkillDTO
    {
        public int PlayerId { get; set; }
        public double CurrentLevel { get; set; }
        public int SkillId { get; set; }
        public string SkillName { get; set; }
    }
}
