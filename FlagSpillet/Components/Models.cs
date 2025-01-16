namespace FlagSpillet.Components
{
    public class UserDTO
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
    }
    public class Flag
    {
        public string png { get; set; }
    }
    public class Country
    {
        public Flag flags { get; set; }
        public Name name { get; set; }
    }
    public class LoginResult
    {
        public string Username { get; set; }
        public string ID { get; set; }
    }
}
