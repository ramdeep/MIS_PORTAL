namespace mohua_web_.Models
{
    public class LoginModel
    {
 
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Designation { get; set; }
        public string LoginDateTime { get; set; }
        public string SessionId { get; set; }
        public string StudSessId { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? UserType { get; set; }
        public int? UserRole { get; set; }
        public string? Status { get; set; }
    }
}
