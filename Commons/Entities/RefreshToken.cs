using Commons.Shared;

namespace Commons.Entities
{
    public class RefreshToken : BaseEntity
    {
        public string Value { get; set; }
        public bool IsBlacklisted { get; set; }
        
        public long UserId { get; set; }
        public User User { get; set; }
    }
}