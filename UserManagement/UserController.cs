using System;
using UserManagement;


class UserController
{
    UserService _userService = new UserService();

    public void register()
    {
        Console.Write("Please Enter Your Name: ");
        string name = Console.ReadLine();
        Console.Write("Please Enter Your Email: ");
        string email = Console.ReadLine();
        Console.Write("Please Enter Your password: ");
        string password = Console.ReadLine();

        User user = new User
        {
            FullName = name,
            Email = email,
            Password = password,
            Id = new Random().Next(1, 10000)


        };
        _userService.AddUser(user);
        Console.WriteLine("User registered successfully!");
    }

    public void Login()
    {
        Console.Write("Please Enter Your password: ");
        string password = Console.ReadLine();

        Console.Write("Please Enter Your Email: ");
        string email = Console.ReadLine();

        User user = new User
        {
            Password = password,
            Email = email

        };


        bool result = _userService.Login(email, password);

        if (result)
        {
            Console.WriteLine("Login successfully!");
        }
        else { Console.WriteLine("Login Failed!"); }
    }

}