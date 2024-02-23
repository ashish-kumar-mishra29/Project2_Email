namespace Email_backend.Models
{
    public class Reset_Password
    {
        public string to_email {  get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string Cpassword {  get; set; } = string.Empty;
    }
}
