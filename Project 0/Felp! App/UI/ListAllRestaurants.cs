namespace UI;

public class ListAllRestaurants : IMenu
{
    private IRRBL _bl;

    public ListAllRestaurants(IRRBL bl) 
    {
        _bl = bl;
    }

    private static Restaurant newRestaurant = new Restaurant();
    private RestSQLRepo listRestRepo = new RestSQLRepo();
    public void Display()
    {
        //Console.WriteLine("Press <1> to add a restaurant to the system");
        //Console.WriteLine("Press <2> to show a list of all the restaurants in the system");
    }

    public string UserChoice()
    {
        Console.WriteLine("Press <1> to show a list of all the restaurants in the system");
        Console.WriteLine("Press <0> to search for a restaurant of your choosing");

        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                listRestRepo.GetAllRestaurants();
                return "mainmenu";
                break;

            case "0":
                return "searchrest method";
                break;

            default:
                return "Please enter a vaild response";
                Console.WriteLine("Press <Enter> to continue");
                Console.ReadLine();
                break;
        }
    }
}