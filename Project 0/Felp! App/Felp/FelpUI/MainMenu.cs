using FelpModels;


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

        public string UserChoice()
        {
           string userinput = Console.ReadLine();

            switch (userinput)
            {
                case "1":
                    return "NewUser";
                    break;
                
                case "2":
                    return "AddRest";
                    break;

                case "3":
                    return "ReviewRest";
                    break;

                case "4":
                    return "AdminAccess";
                    break;

                case "0":
                    return "Exit";
                    break;
                
                default:
                    Console.WriteLine("Please enter a vaild response");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                    break;
            }
        }
    }
}


