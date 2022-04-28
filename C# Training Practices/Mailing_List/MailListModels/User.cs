namespace MailListModels
{
    public class User : IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
    }
}