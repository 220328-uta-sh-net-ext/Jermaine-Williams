using MailListUI;

IMenu menu = new MainMenu();

menu.Display();

bool repeat = true;

while (repeat)
{
    string userinput = menu.UserChoice();

    switch (userinput)
    {
        case "1":
            Console.WriteLine();
            break;
            
        case "2":
            Console.WriteLine();
            repeat = false;
            break;

        default:
            Console.WriteLine();
            break;
    }

}
