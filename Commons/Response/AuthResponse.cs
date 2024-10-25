

namespace net_core_example.Response {
    public class AuthResponse
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        
        #nullable enable
        public string? ProfileImage { get; set; }

        public required string Role { get; set; }
    }
}

