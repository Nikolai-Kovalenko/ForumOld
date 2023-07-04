namespace Forum.Models
{
    public class UsersLogin
    {
        public int id { get; set; }
        public int? userId { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string userAgent { get; set; }
        public string userIp { get; set; }
        public bool isEntry { get; set; }
        public DateTime loginTime { get; set; }
        public virtual Users user { get; set; }
    }
}
