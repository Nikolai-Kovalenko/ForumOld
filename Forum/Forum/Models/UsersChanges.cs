namespace Forum.Models
{
    public class UsersChanges
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string field { get; set; }
        public string fromValue { get; set; }
        public string toValue { get; set; }
        public DateTime changeTime { get; set; }
        public int changeUserId { get; set; }
        public virtual Users user { get; set; }
    }

}
