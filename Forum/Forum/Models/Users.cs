namespace Forum.Models
{
    public class Users
    {
        public int id { get; set; }
        public string login { get; set; }
        public string psevdonim { get; set; }
        public string photo { get; set; }
        public bool isRecovery { get; set; }
        public string email { get; set; }
        public string codeWord { get; set; }
        public string password { get; set; }
        public string roles { get; set; }
        public bool isActive { get; set; }
        public string sex { get; set; }
        public bool isTrusted { get; set; }
        public bool isDeleted { get; set; }
        public DateTime registration_time { get; set; }
    }
}
