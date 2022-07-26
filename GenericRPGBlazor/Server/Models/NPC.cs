namespace GenericRPGBlazor.Server.Models
{
    public class NPC : Living
    {
        public int XpValue { get; set; }
        public bool IsShopKeep { get; set; }
        public bool IsQuestGiver { get; set; }
        public bool IsAggressive { get; set; }
    }
}
