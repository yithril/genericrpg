namespace GenericRPGBlazor.Server.Models
{
    public class CraftReagent : EntityBase
    {
        public int CraftRecipeId { get; set; }
        public CraftRecipe CraftRecipe { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int RequiredAmount { get; set; }
    }
}
