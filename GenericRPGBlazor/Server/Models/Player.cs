namespace GenericRPGBlazor.Server.Models
{
    public class Player : Living
    {
        public int Xp { get; set; }
        public int CurrentRoomId { get; set; }
        public List<PlayerSkill> Skills { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        public string AuthId { get; set; }
    }
}
