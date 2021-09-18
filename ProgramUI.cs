using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserInfoRepository;

namespace PairedProgrammingGame
{
    class ProgramUI
    {
        public void Run()
        {
            
            var userInfo = GetUserInfo();
            string userInput = Continue();
            if (userInput == "2")
            {
                return;
            }
            
            Game(userInfo);
            

            
        }

        private UserInfo GetUserInfo()
        {
            UserInfo userInfo = new UserInfo();
            //Name
            Console.WriteLine("Welcome to Just Another Day, a text based adventure game based on your life!\n" +
                "To get started, let's get a little bit of information about yourself. What is your name?");
            userInfo.Name = Console.ReadLine();
            Console.Clear();

            //City
            Console.WriteLine($"Thank you, {userInfo.Name}!\n" +
                $"Tell us the name of the city in which you live.");
            userInfo.City = Console.ReadLine();
            Console.Clear();

            //Friend Name
            Console.WriteLine($"I bet {userInfo.City} is a lovely place to live!\n" +
                $"Tell us the name of a close friend.");
            userInfo.FriendName = Console.ReadLine();
            Console.Clear();

            // Age
            Console.WriteLine($"{userInfo.FriendName} sounds lovely! \n" +
                $"Tell us your age.");
            userInfo.Age = Int32.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"{userInfo.Age}? Nice!\n" +
                $"Thank you for all that info!");

            return userInfo;
        }

        private string Continue()
        {
            Console.Clear();
            Console.WriteLine("Ready to get started?\n" +
                    "1. Continue\n" +
                    "2. Exit");
            string userOption = Console.ReadLine();
            var validOption = false;
            while (validOption == false)
            {
                switch (userOption)
                {
                    case "1":
                        validOption = true;
                        return userOption;
                    case "2":
                        Console.WriteLine("Have a good day!");
                        Thread.Sleep(1500);
                        return userOption;
                    default:
                        Console.WriteLine("That is not a valid choice. Please press 1 or 2.");
                        userOption = Console.ReadLine();
                        break;
                }
            }
            return userOption;
        }


        private void Game(UserInfo userInfo)
        {
            
            var hasGun = false;

            // var hasFood = false;
            // var hasBeenHurt = false;
            // var hasMedicine = false;

            Console.Clear();

            Console.WriteLine($"It is a lovely day in the city of {userInfo.City}.");

            Console.ReadKey();
        }

    }
}
