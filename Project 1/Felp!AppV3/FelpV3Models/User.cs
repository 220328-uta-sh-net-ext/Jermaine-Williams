namespace FelpV3Models
{
    public class User
    {
        Random random = new Random();

        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User() //default constructor to add default values to the properties
        {
            Fullname = " ";
            Username = " ";
            Password = " ";
            Email = " ";
        }

        public override string ToString() //will print the list of users to the console
        {
            return $"Fullname: {Fullname}\nUsername: {Username}\nPassword: {Password}\nEmail: {Email}";
        }
    }
}