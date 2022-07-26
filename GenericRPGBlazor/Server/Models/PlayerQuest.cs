namespace GenericRPGBlazor.Server.Models
{
    public class PlayerQuest : EntityBase
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int QuestId { get; set; }
        public Quest Quest { get; set; }
        public bool IsComplete { get; set; }
    }
}
