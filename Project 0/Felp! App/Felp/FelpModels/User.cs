namespace FelpModels
{
    /*everything inside my classes are properties, notice the accessors (getters and setters). all properties/indexers have
    accessors to provide var/value to them*/
    public class User : IUser
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string Password { get; set; }
    }
}