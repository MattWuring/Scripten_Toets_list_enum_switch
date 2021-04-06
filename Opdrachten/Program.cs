using System;
using System.Collections.Generic;

namespace Opdrachten
{
    class Program
    {

        #region enums

            //this is the enum for the second assignment
            enum mood { idle, angry, hungry, sleepy }

        #endregion

        static void Main(string[] args)
        {
            #region Assignment 1

                #region prime numbers
                    
                    // This is the List for the prime numbers
                    List<int> prime_numbers = new List<int>() { 5, 11, 2, 7 };

                    
                    // I could have made this assignment a lot easier, but i wanted to challenge myself a bit
                    // so I tried to make it as complicated as I possibly could in the amount of time that was given

                    // down here you have the part where you check if there is a 3 in the list, i've made it so that you can check it with or without the 3 in the list.
                    Console.WriteLine("do you want to check the list with or without the 3 in it? (With or Without)");
                    string with_without = Console.ReadLine();

                    if(with_without == "With")
                    {
                        prime_numbers.Add(3);
                        Console.WriteLine();
                        Console.WriteLine("does the list have number 3 in it: " + prime_numbers.Contains(3));
                        Console.WriteLine();
                        prime_numbers.Remove(3);
                    }

                    if(with_without == "Without")
                    {
                        Console.WriteLine();
                        Console.WriteLine("does the list have number 3 in it: " + prime_numbers.Contains(3));
                        Console.WriteLine();
                    }

                    prime_numbers.Add(3);

                    Continue();


                    // here you have the menu for the sorting the list, I made it so that you can chose what you want to do instead of just doing both ascending and descending without a menu 
                    Console.WriteLine("how do you want the list to be sorted?");
                    Console.WriteLine();
                    Console.WriteLine("Ascending");
                    Console.WriteLine("Descending");
                    Console.WriteLine("Both");
                    Console.WriteLine("Not");
                    Console.WriteLine();
                    Console.WriteLine("Please choose one of the above:");
                    string sorting = Console.ReadLine();
                    Console.WriteLine();


                    // I used a switch here, because I thought that it would easier to do it this way then with a bunch of if statements
                    switch (sorting)
                    {
                        
                        // this case is for if you choose for only the Ascending order
                        case "Ascending":

                            Console.WriteLine("Ascending order:");
                            prime_numbers.Sort();
                            foreach (var number in prime_numbers)
                            {
                                Console.WriteLine(number);
                            }
                            Console.WriteLine();
                            break;

                        // this case is for if you choose for only the Descending order
                        case "Descending":

                            Console.WriteLine("Descending order:");
                            prime_numbers.Sort();
                            prime_numbers.Reverse();
                            foreach (var number in prime_numbers)
                            {
                                Console.WriteLine(number);
                            }
                            Console.WriteLine();
                            break;
                        
                        //this case is for if you want to see both the Ascending and Descending order
                        case "Both":

                            prime_numbers.Sort();
                            Console.WriteLine("Ascending:");
                            foreach (var number in prime_numbers)
                            {
                                Console.WriteLine(number);
                            }
                            Console.WriteLine();


                            Console.WriteLine("Descending:");
                            prime_numbers.Reverse();
                            foreach (var number in prime_numbers)
                            {
                                Console.WriteLine(number);
                            }
                            Console.WriteLine();
                            break;
                        
                        //this case is here if you dont want it to be sorted
                        case "Not":

                            Console.WriteLine("Not sorted:");
                            foreach (var number in prime_numbers)
                            {
                                Console.WriteLine(number);
                            }
                            break;

                        default:
                            break;
                    }

                    Continue();

            #endregion

                #region names
                    
                    // these are the list that I used in the Assignments where you needed names
                    List<string> names = new List<string>();
                    List<string> names2 = new List<string>() { "Boris", "Kyan", "Matt" };


                    // this is where you fill in the empty list
                    Console.WriteLine("Write down 6 names below!");

                    for (int i = 0; i < 6; i++)
                    {
                        names.Add(Console.ReadLine());
                    }
                    Console.WriteLine();

                    Continue();


                    // this is where the 2 lists get combined
                    Console.WriteLine("All the names combined:");
                    Console.WriteLine();

                    names.AddRange(names2);
                    foreach (var name in names)
                    {
                        Console.WriteLine(name);
                    }


                    // 2 random names get removed here
                    Random rnd = new Random();
                    for (int i = 0; i < 2; i++)
                    {
                        int randomnumber = rnd.Next(0, 8);
                        names.RemoveAt(randomnumber);
                    }

                    // this is where i show how many names are still left in the list
                    Console.WriteLine();
                    Console.WriteLine("2 random names have been removed");
                    Console.WriteLine("How many names are left:");
                    Console.WriteLine();
                    Console.WriteLine(names.Count);

                    Continue();


                    // this is where all the names get removed except for the first 2
                    Console.WriteLine("Now all the names except for the first 2 have been removed!");
                    Console.WriteLine("Which Names are left:");
                    Console.WriteLine();

                    names.RemoveRange(2, names.Count - 2);
                    foreach (var name in names)
                    {
                        Console.WriteLine(name);
                    }

                    Continue();


                    // all the names get removed over here
                    Console.WriteLine("Now all the names have been removed!");
                    Console.WriteLine("How many names are there:");
                    Console.WriteLine();

                    names.Clear();
                    Console.WriteLine(names.Count);

                    Continue();
                
                #endregion

            #endregion

            #region Assignment 2


            //this is where the booleans and integers are at
            bool isBored = false,
                 isSatisfied = true;

            int rageLevel = 0,
                hitPoints = 20;

            // I have chosen to do 3 rounds, so that you can see the value's stack
            for (int i = 0; i < 3; i++)
            {

                //this is the menu that you get to see when you choose your mood
                Console.WriteLine("What mood are you in?");
                Console.WriteLine();
                Console.WriteLine("Idle");
                Console.WriteLine("Angry");
                Console.WriteLine("Hungry");
                Console.WriteLine("Sleepy");
                Console.WriteLine();
                Console.WriteLine("choose one of the options above:");
                string numberchosen = Console.ReadLine();


                mood CurrentMood = 0;


                // this where I change the given answer to the correct enum value
                switch (numberchosen)
                {
                    case "Idle":
                        CurrentMood = mood.idle;
                        break;

                    case "Angry":
                        CurrentMood = mood.angry;
                        break;

                    case "Hungry":
                        CurrentMood = mood.hungry;
                        break;

                    case "Sleepy":
                        CurrentMood = mood.sleepy;
                        break;

                    default:
                        break;
                }


                // this is where the enum value gets changed into a response that you get to seen in the console
                switch (CurrentMood)
                {
                    case mood.idle:
                        Console.WriteLine();
                        Console.WriteLine("you are now bored!");
                        isBored = true;
                        hitPoints = hitPoints + 5;
                        break;

                    case mood.angry:
                        Console.WriteLine();
                        Console.WriteLine("you are now angry!");
                        rageLevel = rageLevel + 100;
                        isBored = false;
                        break;

                    case mood.hungry:
                        Console.WriteLine();
                        Console.WriteLine("you are now hungry!");
                        isSatisfied = false;
                        hitPoints = hitPoints - 5;
                        break;

                    case mood.sleepy:
                        Console.WriteLine();
                        Console.WriteLine("you went to bed, so your stats are restored!");
                        isSatisfied = true;
                        isBored = false;
                        rageLevel = 0;
                        hitPoints = 20;
                        break;

                    default:
                        break;
                }

                // This shows you your stats at the end of each round so that you can see it change every time
                Console.WriteLine();
                Console.WriteLine("are you bored: " + isBored);
                Console.WriteLine("are you Satisfied: " + isSatisfied);
                Console.WriteLine("what rage level are you on: " + rageLevel);
                Console.WriteLine("how many hitpoints do you have left: " + hitPoints);
                Console.WriteLine();

                Continue();
            }

            #endregion

            #region voids

            // this is just a standerd continue void to make the code look cleaner
            void Continue()
            {
                Console.WriteLine();
                Console.WriteLine("Press [ENTER] to continue!");
                Console.ReadLine();
                Console.Clear();
            }

            #endregion
        }
    }
}

