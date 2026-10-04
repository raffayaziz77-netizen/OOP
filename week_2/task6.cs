using System;
using System.IO;

public class MUser
{
    public string Username;
    public string Password;
    public string Role;

    // Constructor
    public MUser(string username, string password, string role)
    {
        Username = username;
        Password = password;
        Role = role;
    }

    // Load data into attributes
    public void loadData(string data)
    {
        string[] parts = data.Split(',');

        Username = parts[0];
        Password = parts[1];
        Role = parts[2];
    }

    // Sign In
    public bool signIn(string username, string password)
    {
        if (Username == username && Password == password)
        {
            return true;
        }

        return false;
    }

    // Show User
    public void showUser()
    {
        Console.WriteLine("Username: " + Username);
        Console.WriteLine("Password: " + Password);
        Console.WriteLine("Role: " + Role);
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        MUser[] users = new MUser[100];

        int count = 0;

        // Load data from file
        if (File.Exists("users.txt"))
        {
            string[] lines = File.ReadAllLines("users.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                users[count] = new MUser("", "", "");

                users[count].loadData(lines[i]);

                count++;
            }
        }

        Console.WriteLine("1. Sign Up");
        Console.WriteLine("2. Sign In");

        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        // SIGN UP
        if (choice == 1)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Role: ");
            string role = Console.ReadLine();

            users[count] = new MUser(username, password, role);

            // Save to file
            File.AppendAllText(
                "users.txt",
                username + "," + password + "," + role + Environment.NewLine
            );

            count++;

            Console.WriteLine("Sign Up Successful!");
        }

        // SIGN IN
        else if (choice == 2)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (users[i].signIn(username, password))
                {
                    Console.WriteLine("Sign In Successful!");
                    Console.WriteLine("Role: " + users[i].Role);

                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine("Invalid Username or Password.");
            }
        }
    }
}