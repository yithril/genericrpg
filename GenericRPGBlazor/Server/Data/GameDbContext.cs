using GenericRPGBlazor.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRPGBlazor.Server.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Race> Races { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<ArmorLimb> ArmorsLimbs { get; set; }
        public DbSet<CraftReagent> CraftReagents { get; set; }
        public DbSet<CraftRecipe> CraftRecipes { get; set; }
        public DbSet<CraftSkill> CraftSkills { get; set; }
        public DbSet<GameZone> GameZones { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Limb> Limbs { get; set; }
        public DbSet<NPC> NPCs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerQuest> PlayerQuests { get; set; }
        public DbSet<PlayerSkill> PlayerSkills { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<RaceSkill> RaceSkills { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomExit> RoomExits { get; set; }
        public DbSet<RoomItem> RoomItems { get; set; }
        public DbSet<RoomNPC> RoomNPCs { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<GameHelp> GameHelp { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }
    }
}
