using System;
using UserManagement;


class Program
{
    static void Main()
    {
        UserController controller = new UserController();
        while (true)
        {
            Console.WriteLine("--Menue--");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            Console.WriteLine("3.Exists");

            Console.Write("Choose: ");
            var inp = Console.ReadLine();

            if (inp == "1") 
                controller.Login();
            else if (inp == "2") 
                controller.register();
            else 
                break;

        }

    }
}