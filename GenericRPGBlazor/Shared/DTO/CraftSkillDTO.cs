namespace GenericRPGBlazor.Shared.DTO
{
    public class CraftSkillDTO
    {
        public int CraftRecipeId { get; set; }
        public int SkillId { get; set; }
        public SkillDTO Skill { get; set; }
        public int MinSkillRequired { get; set; }
    }
}
