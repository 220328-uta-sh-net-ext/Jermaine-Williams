global using Serilog;
using FelpUI;

//Log.Logger = new LoggerConfiguration();

IMenu menu = new MainMenu();

bool repeat = true;

menu.Display();

while (repeat) //while repeat is true, display will loop until it's false
{
    string userinput = menu.UserChoice();

    switch (userinput)
    {

        case "NewUser":
            AddUser.AddingUser();
            break;

        case "AddRest":
            AddRest.AddingRest();
            break;

        case "ReviewRest":
            Console.WriteLine("AddReview Method");
            break;

        //case "AdminAccess":
        //    Console.WriteLine("Call AddAdmin method");
        //    break;

        case "Exit":
            repeat = false;
            break;

        case "MainMenu":
            menu = new MainMenu();
            break;
    } 
}