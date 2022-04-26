namespace FelpModels
{
    /*everything inside my classes are properties, notice the accessors (getters and setters). all properties/indexers have
    accessors to provide var/value to them*/
    public class User : IUser
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //private List<User>
    }
}