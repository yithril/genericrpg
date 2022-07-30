namespace GenericRPGBlazor.Shared.DTO
{
    public class PlayerQuestDTO
    {
        public int PlayerId { get; set; }
        public int QuestId { get; set; }
        public QuestDTO Quest { get; set; }
        public bool IsComplete { get; set; }
    }
}
