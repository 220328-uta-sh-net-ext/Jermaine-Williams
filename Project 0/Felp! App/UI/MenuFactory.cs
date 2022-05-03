using DL;

namespace UI;
public static class MenuFactory
{
    public static IMenu GetMenu(string menuString)
    {
        menuString = menuString.ToLower();

        IUserRepo urepo = new UserSQLRepo();
        IRestaurantRepo repo = new RestaurantRepo();
        IUBL ubl = new UBL(urepo);
        IRRBL bl = new RRBL(repo);

        switch (menuString)
        {
            case "main":
                return new MainMenu();

            case "user":
                return new AdminMenu(ubl);

            case "restaurant":
                return new ListAllRestaurants(bl);
            
            case "review":
                //return new ReviewMenu(bl);
            
            default:
                return new MainMenu();
        }
    }
}