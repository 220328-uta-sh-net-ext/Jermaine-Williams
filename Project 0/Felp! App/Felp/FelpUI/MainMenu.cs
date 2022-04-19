namespace FelpUI
{
    class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Hello, and Welcome to the Felp! App");
            Console.WriteLine("Where you can write, review, and search you next favorite resturants!"); Thread.Sleep(5000);

            Console.WriteLine("Please select from the following options:"); Thread.Sleep(2000);
            Console.WriteLine("Press <1> to make a new account"); Thread.Sleep(1000);
            Console.WriteLine("Press <2> to make an Admin account"); Thread.Sleep(1000);
            Console.WriteLine("Press <3> to review a restaurant"); Thread.Sleep(1000);
            Console.WriteLine("Press <4> for Admin access"); Thread.Sleep(1000);
            Console.WriteLine("Press <0> to exit the app"); Thread.Sleep(1000);
        }

        public void UserChoice()
        {
            string x = Console.ReadLine();
            
            Console.Clear();

            switch (x)
            {
                case "1":
                    Console.WriteLine("Please enter your full name:");

                    string fullname = Console.ReadLine();

                    Console.WriteLine("Enter your email:");

                    string email = Console.ReadLine();

                    if (!email.Contains("@") && !email.Contains(".com"))
                    {
                        Console.WriteLine("Invalid email\n, Please enter your email in the correct format: johndoe@jd.com"); Thread.Sleep(2000);
                        Console.WriteLine("Please re-enter your email:");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(email);
                    }

                    break;

                case "2":

                    Console.WriteLine("2  block");

                    break;

                case "3":

                    Console.WriteLine("3 block");

                    break;

                case "4":

                    Console.WriteLine("This area is only for Administrators only."); Thread.Sleep(2000);
                    Console.WriteLine("To continue, please enter the access code, then press enter:");

                    var accesscode = Console.ReadLine();

                    Console.WriteLine(accesscode);

                    break;

                case "0":

                    Console.WriteLine("Are you sure you would like to exit?"); Thread.Sleep(2000);
                    Console.WriteLine("<Y> or <N> ?");

                    var yn = Console.ReadLine();

                    if (yn == "Y" || yn == "y")
                    {
                        Console.WriteLine("Thank you for visiting the Felp App! We hope you enjoyed your experience"); Thread.Sleep(2000);
                        Console.WriteLine("Goodbye~ <3");
                    }
                    if (yn == "N" || yn == "n")
                    {
                        Console.WriteLine("Going back to the main menu"); Thread.Sleep(2000);
                        Console.Clear();
                        Display();
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    break;

            }
        }
    }
}


