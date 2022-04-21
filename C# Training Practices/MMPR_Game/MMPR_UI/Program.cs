using MMPR_UI;

IMenu menu = new MainMenu();

bool repeat = true;

while (repeat)
{
    menu.Display();
    
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "CharacterSelect":
            menu = new MainMenu();
            break;

        case "Exit":
            repeat = false;
            break;
    }

}
    




