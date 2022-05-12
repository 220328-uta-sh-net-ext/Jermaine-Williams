using UI;
using DL;
using Serilog;

//Log.Logger = new LoggerConfiguration();

IMenu menu = new MainMenu();
IUserRepo urepo = new UserRepo();
IRestaurantRepo repo = new RestaurantRepo();
IUBL ubl = new UBL(urepo);
IRRBL bl = new RRBL(repo);
AddUser au = new AddUser();

bool repeat = true;

menu.Display();
MenuFactory.GetMenu("menu");

while (repeat) //while repeat is true, display will loop until it's false
{
    string userinput = menu.UserChoice();

    switch (userinput)
    {
        case "adduser":
            menu = new AddUser();
            break;

        case "listrest":
            menu = new ListAllRestaurants(bl);
            break;

        case "addrest":
            menu = new AddRest(bl);
            break;

        case "reviewrest":
            menu = new AddReview(bl);
            break;

        case "adminaccess":
            Console.WriteLine("Call AddAdmin method");
            break;

        case "exit":
            repeat = false;
            break;

        case "mainmenu":
            menu = new MainMenu();
            break;
    }
}

