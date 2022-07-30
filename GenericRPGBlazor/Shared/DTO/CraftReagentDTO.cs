namespace GenericRPGBlazor.Shared.DTO
{
    public class CraftReagentDTO
    {
        public int CraftRecipeId { get; set; }
        public int ItemId { get; set; }
        public ItemDTO Item { get; set; }
        public int RequiredAmount { get; set; }
    }
}
