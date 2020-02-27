using DevelopersGame.DataAccess.Enums;

namespace DevelopersGame.DataAccess.Entities
{
    public class User: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
        public string ChatId { get; set; }
        public decimal Coins { get; set; }
        public RankType Rank { get; set; }
    }
}