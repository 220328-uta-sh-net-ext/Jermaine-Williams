namespace UI;

public class ListAllRestaurants : IMenu
{
    private IRRBL _bl;

    public ListAllRestaurants(IRRBL bl) 
    {
        _bl = bl;
    }
    public void Display()
    {
        //Console.WriteLine("Press <1> to add a restaurant to the system");
        //Console.WriteLine("Press <2> to show a list of all the restaurants in the system");
    }

    public string UserChoice()
    {
        Console.WriteLine("Press <1> to add a restaurant to the system");
        Console.WriteLine("Press <2> to show a list of all the restaurants in the system");
        Console.WriteLine("Press <3> to search for a restaurant of your choosing");

        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                return "addrest method";
                break;

            case "2":
                return "getallrest method";
                break;

            case "3":
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