namespace GenericRPGBlazor.Server.Models
{
    public class CraftSkill : EntityBase 
    {
        public int CraftRecipeId { get; set; }
        public CraftRecipe CraftRecipe{ get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public int MinSkillRequired { get; set; }
    }
}
