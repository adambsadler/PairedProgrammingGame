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
            Console.Clear();

            // User tools
            var hasBeenHurt = false;
            // User scene options / bools
            var areDressed = false;
            var checkBackWindowFirst = false;
            var fleeHouse = false;
            var haveCar = false;
            // User text returns
            string wrongAnswer = "Not a vaild option.";
            string foundMedicine = "You found a Medkit!";

            // Introduction
            Console.WriteLine($"It is a lovely day in the city of {userInfo.City}. You wake up to the sound of a faint siren, assuming \n" +
                $"it was your alarm you roll over to check your phone. You realize that you did not set your alarm \n" +
                $"the night before, and strangely you see that your phone has no signal. As you pause to consider why this is, \n" +
                $"you hear a knock at the door. You wonder who could be knocking at your door this early only have your thoughts \n" +
                $"interrupted by what sounds like scratching at your back window.\n" +
                $"What would you like to do?\n" +
                $"1. Go see who is at the front door.\n" +
                $"2. Take a minute to get dressed.\n" +
                $"3. Go check out the back window.");
            var userOption1 = Console.ReadLine();
            var validOption1 = false;

            // First User Option Result
            while (validOption1 == false)
            {
                switch (userOption1)
                {
                    case "1":
                        Console.Clear();
                        validOption1 = true;
                        Console.WriteLine($"You begrudgingly get out of bed to go see who is knocking at your front door.\n" +
                            $"You think to yourself that it better not be {userInfo.FriendName} at this hour. As you open the door,\n" +
                            $"you are shocked to find a small group of strangers lunge towards you. Their eyes are white and they appear\n" +
                            $"to be injured or sick. You don't have time to think about who they are or why they are at your house before\n" +
                            $"they all grab you and start biting your flesh. You are dead. Game over.");
                        Console.ReadLine();
                        return;
                    case "2":
                        Console.Clear();
                        validOption1 = true;
                        areDressed = true;
                        Console.WriteLine($"As a {userInfo.Age} year old, you understand the importance of getting dressed for the day.\n" +
                            $"You decide to take a moment to choose an outfit for the day and get dressed.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        validOption1 = true;
                        checkBackWindowFirst = true;
                        Console.WriteLine($"You decide to find out what is scratching at your back window. You think to yourself that it's\n" +
                            $"probably a raccoon. Walking from your bedroom, you feel a bit chilly in your shorts and realize that you should\n" +
                            $"have gotten dressed first. Shrugging it off, you turn the corner from your hallway to look out your window.\n" +
                            $"You are surprised to see a group of people walking around in your backyard. You rub the sleep out of your\n" +
                            $"eyes and walk closer to get a better look. Your heart skips a beat when you notice one of the people is the\n" +
                            $"{userInfo.City} mayor, who died a week ago!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine(wrongAnswer);
                        userOption1 = Console.ReadLine();
                        break;
                }

            }
            // Main route choice 1
            if (checkBackWindowFirst)
            {
                Console.Clear();

                Console.WriteLine("You take a second to process the horror scene outside your window, enough time to decide what to do next.\n" +
                    "1. Run out of the house!\n" +
                    "2. Go back to your room and get dressed.");

                var userOption3 = Console.ReadLine();
                var validOption3 = false;
                while (validOption3 == false)
                {
                    switch (userOption3)
                    {
                        case "1":
                            validOption3 = true;
                            fleeHouse = true;
                            Console.Clear();
                            Console.WriteLine($"You panic and decide the best course of action is to get out of the house immediately.\n" +
                                $"You quickly turn and run towards your garage. You notice the gym bag that {userInfo.FriendName}\n" +
                                $"left by the door when you last went to the gym together. You grab it, hoping it has some clothes inside.");
                            Console.ReadLine();
                            break;
                        case "2":
                            validOption3 = true;
                            areDressed = true;
                            Console.Clear();
                            Console.WriteLine($"As a {userInfo.Age} year old, you understand the importance of getting dressed for the day.\n" +
                            $"You decide to take a moment to choose an outfit for the day and get dressed.");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine(wrongAnswer);
                            userOption3 = Console.ReadLine();
                            break;
                    }
                }
            }

            if (areDressed)
            {
                Console.Clear();

                if (checkBackWindowFirst)
                {
                    Console.WriteLine("After quickly getting dressed, you decide the best course of action would be to get into your car\n" +
                        "and drive far away. Luckily, you reach into your pocket and find your car keys!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("As you get dressed, you reach into your pants pocket and find your car keys! Your relief is cut short\n" +
                        "when you hear what sounds like someone walking slowly and moaning outside your bedroom window.\n" +
                        "You finish tying your shoes and walk closer to the window to see who it is. As you approach the window,\n" +
                        "it shatters as a bloody hand reaches for you. A large shard of glass slices your arm open and you hear\n" +
                        "mindless groans outside. You decide you better get out of here!");
                    hasBeenHurt = true;
                    Console.ReadLine();
                }

                Console.WriteLine("You hear your back window breaking and what sounds like moaning and rustling sounds.\n" +
                    "You realize your house is not safe!\n" +
                    "1. Run to the garage and get in your car.\n" +
                    "2. Look for supplies on your way to your car.");
                var userOption2 = Console.ReadLine();
                var validOption2 = false;
                while (validOption2 == false)
                {
                    switch (userOption2)
                    {
                        case "1":
                            validOption2 = true;
                            Console.Clear();
                            Console.WriteLine("You run as fast as you can to your garage, hoping your car is safe and you can get\n" +
                                "out of here.");
                            haveCar = true;
                            Console.ReadLine();
                            break;
                        case "2":
                            validOption2 = true;
                            if (hasBeenHurt)
                            {
                                Console.Clear();
                                Console.WriteLine("With your arm bleeding, you decide that you have to treat it before leaving the house.\n" +
                                    "You rush across the hall to your bathroom to look for a bandage or something to stop the bleeding.\n" +
                                    "You throw open the cabinet and knock over a stack of extra toilet paper." + foundMedicine + "\n" +
                                    "You quickly wrap your arm up with a bandage from the kit. Then, you take the medkit with you as\n" +
                                    "you rush down the hall to your garage.");
                                haveCar = true;
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You decide that you better not leave the house without supplies, so you gather up as\n" +
                                    "much as you can carry from around your room. You grab your backpack and stuff it full of extra clothes.\n" +
                                    "You pick up an old baseball bat from your closet. You see your old trumpet and think to yourself that\n" +
                                    "you'll definitely need that! Carrying as much as you can, you realize that it's past time to get out of\n" +
                                    "the house. You open the door to room and are immediately overwhelmed by the crowd of bloody strangers in\n" +
                                    "your hallway. The last thing you feel are their teeth sinking into your flesh. You also swear you hear\n" +
                                    "the soft blast of a trumpet. You are dead. Game Over.");
                                Console.ReadLine();
                                return;
                            }
                            break;
                        default:
                            Console.WriteLine(wrongAnswer);
                            userOption2 = Console.ReadLine();
                            break;
                    }
                }
            }

            if (fleeHouse)
            {
                Console.Clear();
                // you checked the window and ran out grabbing a gym bag...you'll have to ride a bike or go back to get your keys (and die)
                Console.WriteLine($"You throw open the door to your garage and then slam it shut behind you. Opening up the\n" +
                    $"gym bag that {userInfo.FriendName} left at your house, you find some clean clothes and shoes. \n" +
                    $"You quickly get dressed as you decide what to do next. You realize you don't have your car keys and \n" +
                    $"you remember that they were in your pants pocket. The pants currently on the floor in your room.\n" +
                    $"1. Forget the car and grab your bicycle.\n" +
                    $"2. Go back inside and get your car keys.");

                var userOption4 = Console.ReadLine();
                var validOption4 = false;
                while (validOption4 == false)
                {
                    switch (userOption4)
                    {
                        case "1":
                            validOption4 = true;
                            Console.Clear();
                            Console.WriteLine("You realize that going inside would not be the best idea. You have no idea what is in your\n" +
                                "house, and you really don't have much desire to find out right now. You hop on your bicycle\n" +
                                "and open your garage door. The sight of what has become of your neigborhood overwhelms you.\n" +
                                "Countless, what can only be described as zombies, are shambling all over the streets and yards\n" +
                                "around your house. You have no idea what is going on, but you know that you don't want to stick\n" +
                                "stick around to find out. You pedal as fast as you can, carefully avoiding the shambling forms\n" +
                                "lunging after you.\n" +
                                "Congratulations! You survived Chapter 1 of Just Another Day! Stay tuned for Chapter 2...");
                            Console.ReadLine();
                            break;
                        case "2":
                            validOption4 = true;
                            Console.Clear();
                            Console.WriteLine("You think to yourself that you won't get very far without your car. As dangerous as it may be,\n" +
                                "you need to go back inside to get your keys. You carefully open your door and creep back into your hallway.\n" +
                                "You slowly make your way to your bedroom and find your pants on the floor. You reach into the pocket and\n" +
                                "find your car keys. Your moment of triumph is cut short with the shattering of your bedroom window and moans\n" +
                                "coming from the hallway. You are quickly surrounded by countless lumbering strangers, desparate to eat you.\n" +
                                "Game over.");
                            Console.ReadLine();
                            return;
                        default:
                            Console.WriteLine(wrongAnswer);
                            userOption4 = Console.ReadLine();
                            break;
                    }
                }
            }

            if (haveCar)
            {
                Console.Clear();
                // Either get in the car and leave or try to grab a gun from the cabinet
                Console.WriteLine($"You throw the door to your garage open and are immediately relieved to see your car waiting\n" +
                    $"for you. After taking your first step toward the car, you remember that {userInfo.FriendName} left a handgun\n" +
                    $"in a cabinet in your garage after going with you to the shooting range last week. That gun may come in handy.\n" +
                    "1. Get in the car and get out of here.\n" +
                    "2. Check the cabinet for the gun.");
                var userOption5 = Console.ReadLine();
                var validOption5 = false;
                while (validOption5 == false)
                {
                    switch (userOption5)
                    {
                        case "1":
                            Console.Clear();
                            validOption5 = true;
                            Console.WriteLine("You hop in the car, turn on the ignintion, and open up the garage door. As you back out of the garage,\n" +
                                "the reality of your situation finally hits you. Your neighborhood is crawling with zombies! You've seen them in,\n" +
                                "movies, shows, and video games, but you never would have imagined seeing them in real life. You step on the gas\n" +
                                "and try to avoid hitting as many as you can on your way down the street.\n" +
                                "Congratulations! You survived Chapter 1 of Just Another Day! Stay tuned for Chapter 2...");
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.Clear();
                            validOption5 = true;
                            if (hasBeenHurt)
                            {
                                Console.WriteLine($"With all the craziness going on this morning, you can't help but wonder just how much of\n" +
                                    $"{userInfo.City} is affected by this. You figure that you may need some protection from whatever it is surrounding\n" +
                                    $"your house. You quickly move to the cabinet on the wall of your garage to find the gun that {userInfo.FriendName} left.\n" +
                                    $"You are relieved when you see it sitting on the shelf. As you grab it, you are startled by the garage door being slammed\n" +
                                    $"open and the undead sheriff shambling in. You move to aim the gun, but your bandage gets caught on the door hinge. As you\n" +
                                    $"struggle to free it, the walking corpse lunges at you and takes a bite out of your shoulder. You fall to the ground as\n" +
                                    $"several more zombies shuffle into the garage to join in the feast. Game over.");
                                Console.ReadLine();
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"With all the craziness going on this morning, you can't help but wonder just how much of\n" +
                                    $"{userInfo.City} is affected by this. You figure that you may need some protection from whatever it is surrounding\n" +
                                    $"your house. You quickly move to the cabinet on the wall of your garage to find the gun that {userInfo.FriendName} left.\n" +
                                    $"You are relieved when you see it sitting on the shelf. As you grab it, you are startled by the garage door being slammed\n" +
                                    $"open and the undead sheriff shambling in. You quickly pull the gun up and take aim. You fire the gun and it finds its mark\n" +
                                    $"right in the chest of the approaching form. You are shocked to see that the shot has no effect and it continues to advance.\n" +
                                    $"You take another shot, this time aiming for the head. This time the sheriff falls to the ground and stays dead. You don't\n" +
                                    $"stay to admire your handywork, as the moans from inside your house fortell a dark fate.\n" +
                                    $"You hop in the car, turn on the ignintion, and open up the garage door. As you back out of the garage,\n" +
                                    $"the reality of your situation finally hits you. Your neighborhood is crawling with zombies! You've seen them in,\n" +
                                    $"movies, shows, and video games, but you never would have imagined seeing them in real life. You step on the gas\n" +
                                    $"and try to avoid hitting as many as you can on your way down the street.\n" +
                                    $"Congratulations! You survived Chapter 1 of Just Another Day! Stay tuned for Chapter 2...");
                                Console.ReadLine();
                            }
                            break;

                        default:
                            Console.WriteLine(wrongAnswer);
                            userOption5 = Console.ReadLine();
                            break;
                    }
                }
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();
        }

    }
}
