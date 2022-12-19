/*
 * Program Name: UserManagment
 * Programmer: Jae, Overlow
 * Date: 12/19/2022
 *
 * Description: My UserManagment program allows one to 
 * make a new admin, guest user, or login into a exsisting account.
 * Or before logging in you have the option of entering a calculator,
 * your favorite song genre, or your favorite game.
 */





bool isLooping = true;

//Default Admin Username and Password
const string ADMIN_USERNAME = "Andrew Tate";
const string ADMIN_PASSWORD = "Masc";


List<User> users = new List<User>();
List<Guest> guests = new List<Guest>();
List<Admin> admins = new List<Admin>();

while (isLooping)
{

    Console.WriteLine("Press 1 for Admin login");
    Console.WriteLine("Press 2 to create new sub-users");
    Console.WriteLine("Press 3 to enter calculator");
    Console.WriteLine("Press 4 for favorite song genre");
    Console.WriteLine("Press 5 for favorite game");
    string userInput = Console.ReadLine();

    if (userInput == "1")
    {
        Login();
    }
    else if (userInput == "2")
    {
        CreateUsers();
    }
    else if (userInput == "3")
    {
        AcessCalculator();
    }
    else if (userInput == "4")
    {
        AcessSong();
    }
    else if (userInput == "5")
    {
        AcessGames();
    }
    else
    {
        Console.WriteLine("Invalid Selection...");
    }
}

void AcessGames()
{
    Console.WriteLine("What is your favorite video game?");
    Console.WriteLine("Is it COD, Cyberpunk 2077, Minecraft, NFS Unbound, Apex Legends, or Destiny 2?");
    string selection = Console.ReadLine();
    if (selection == "COD")
    {
        Console.WriteLine("You're a true man!");
    }
    else if (selection == "Cyberpunk 2077")
    {
        Console.WriteLine("Hows the FPS lag fool?? HAHAHAHA");
    }
    else if (selection == "Minecraft")
    {
        Console.WriteLine("Basic, that's all I say");
    }
    else if (selection == "NFS Unbound")
    {
        Console.WriteLine("HELL YEA BOIIII");
    }
    else if (selection == "Apex Legends")
    {
        Console.WriteLine("Child's play");
    }
    else if (selection == "Destiny 2")
    {
        Console.WriteLine("Give me your username and lets play man!");
    }
}

void AcessSong()
{
    Console.WriteLine("What is your favorite song genre?");
    Console.WriteLine("Is it punk, rock, rap, country?");
    string selection = Console.ReadLine();
    if (selection == "country")
    {
        Console.WriteLine("Country is your favorite? Got sum good taste gawddam, *Imagine the Free Bird solo*");
    }
    else if (selection == "rap")
    {
        Console.WriteLine("Rap is your favorite? Really? I respect that");
    }
    else if (selection == "punk")
    {
        Console.WriteLine("If you like punk then yessir, you got good taste.");
    }
    else if (selection == "rock")
    {
        Console.WriteLine("HELL YES");
    }

}

void AcessCalculator()
{

    Calculator calc = new Calculator();
    float division = calc.Divide(10, 100000);
    float multiplication = calc.Multiply(10, 20, 300);
    float addition = calc.Add(10, 20, 30);
    float subtraction = calc.Subtract(10, 210, 320);

    Console.WriteLine("Add" + " " + addition);
    Console.WriteLine("Subtract" + " " + subtraction);
    Console.WriteLine("Multiplication" + " " + multiplication);
    Console.WriteLine("division" + " " + division);
}
void CreateUsers()
{
    //Login as an administrator
    Console.WriteLine("Enter an admin username: ");
    string username = Console.ReadLine();
    Console.WriteLine("Enter the password: ");
    string password = Console.ReadLine();

    if (username == ADMIN_USERNAME && password == ADMIN_PASSWORD)
    {
        isLooping = true;
        Console.Clear();
    }
    else
    {
        isLooping = false;
        Console.Clear();
        Console.WriteLine("Invalid username or password!");
        CreateUsers();
    }

    while (isLooping)
    {
        //Prompt for Username
        Console.WriteLine("Enter a username: ");
        string un = Console.ReadLine();

        //Prompt for Password
        Console.WriteLine("Enter a password: ");
        string pw = Console.ReadLine();

        //Prompt for pre-determined access levels
        Console.WriteLine("Press 1 for a Generic User.");
        Console.WriteLine("Press 2 for a Guest User.");
        Console.WriteLine("Press 3 for an Admin User.");
        Console.WriteLine("Press 0 to Login");
        int selection = int.Parse(Console.ReadLine());

        //Clear Screen
        Console.Clear();

        //Create an object
        if (selection == 1)
        {
            users.Add(new User(un, pw));
            Console.WriteLine(un + " has been created as a Generic User");
        }
        else if (selection == 2)
        {
            guests.Add(new Guest(un, pw));
            Console.WriteLine(un + " has been created as a Guest User");

        }
        else if (selection == 3)
        {
            admins.Add(new Admin(un, pw));
            Console.WriteLine(un + " has been created as an Admin User");
        }
        else if (selection == 0)
        {
            Login();
        }
        else
        {
            Console.WriteLine("Invalid Selection. No user created.");
        }

        Console.WriteLine("All Users:");
        foreach (User usr in users)
        {
            Console.WriteLine(usr.username);
        }
        Console.WriteLine("All Guests:");
        foreach (Guest gst in guests)
        {
            Console.WriteLine(gst.username);
        }
        Console.WriteLine("All Admins:");
        foreach (Admin adm in admins)
        {
            Console.WriteLine(adm.username);
        }
    }
}

void Login()
{
    Console.WriteLine("Enter username: ");
    string username = Console.ReadLine();
    Console.WriteLine("Enter password: ");
    string password = Console.ReadLine();

    foreach (User user in users)
    {
        if (user.username == username)
        {
            if (user.password == password)
            {
                LoadApp(username);
            }
            else
            {
                Console.WriteLine("Crapass Password Fool");
                Login();
            }
        }
        else
        {
            Console.WriteLine("Crapass Username Fool");
            Login();
        }
    }
}

void LoadApp(string username)
{
    Console.WriteLine("Hello " + username + "!");
}




