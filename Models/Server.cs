namespace ServerManagement.Models
{
    public class Server
    {
        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0 ? false : true;
        }
        public int ServerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsOnline { get; set; }
        public string City { get; set; } = string.Empty;
        //public string Image { get; set; }
    }
}
