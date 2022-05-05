using FelpV3UI;
using FelpV3DL;
using FelpV3BL;
using FelpV3Models;

SQLRepo repository = new SQLRepo();
Repo bL = new Repo(repository);

bool repeat = true;

IMenu menu = new Welcome();

menu.Display();

while (repeat)
{
    string userinput = menu.UserChoice();

    switch (userinput)
    {
        case "Login":
            menu = new Login(bL);
            break;

        case "Register":
            menu = new Register();
            break;

        case "Exit":
            repeat = false;
            break;

        case "Welcome":
            menu = new Welcome();
            break;
    }
}
