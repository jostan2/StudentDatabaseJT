namespace StudentDatabaseJT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool start = true;

            while (start == true)
            {
                //database Name (8)
                string[] names = { "Jack", "Lack", "Back", "Jill", "Gill", "Bill", "Phil", "Shill" };

                //database Hometown
                string[] hometown = { "City A", "City B", "District C", "County D", "Area E", "Community F", "Commonwealth G", "Kingdom H" };

                //database favorite ood
                string[] food = { "Apples", "Oranges", "Bannana", "Pickles", "Gumbo", "Ratatouille", "Quiche", "Lasagna" };


                //PrintArray(names); //print list/array of student's names
                string input = PromptUserInput("Hello. Please input the number of the student you would like to know more about. 1-8:"); //prompt user input for student #

                int userinput = (Convert.ToInt32(input) -1);    

                if (userinput < 0 || userinput > 7)
                {
                    Console.WriteLine("Invald input, restarting");
                    Console.WriteLine();
                    Console.WriteLine();
                    start = true;
                    
                }
                else
                {
                    Console.WriteLine(names[userinput]); //return name of selected student
                    Console.WriteLine();

                    Console.WriteLine("Would you like to know the student's hometown or favorite food?");
                    string userinput2 = Console.ReadLine().ToLower();

                    while (true)
                    {
                        if (userinput2 == "hometown" || userinput2 == "home" || userinput2 == "town")
                        {
                            Console.WriteLine(hometown[userinput]);
                            Console.WriteLine();

                            while (true)
                            {
                                Console.WriteLine("Would you like to see the list of all students? Y/N");
                                string userinput3 = Console.ReadLine().ToLower();
                                

                                if (userinput3 == "y")
                                {
                                    Console.WriteLine();
                                    PrintArray(names);
                                    break;

                                }
                                else if (userinput3 == "n")
                                {
                                    Console.WriteLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("error, invalid input.");
                                    break;
                                }
                                
                            }

                        }
                        else if (userinput2 == "favorite food" || userinput2 == "food" || userinput2 == "favorite")
                        {
                            Console.WriteLine(food[userinput]);
                            Console.WriteLine();
                            while (true)
                            {
                                Console.WriteLine("Would you like to see the list of all students? Y/N");
                                string userinput3 = Console.ReadLine().ToLower();

                                if (userinput3 == "y")
                                {
                                    PrintArray(names);
                                    break;
                                }
                                else if (userinput3 == "n")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("error, invalid input.");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry, invalid choice, try again.");
                            break;
                        }
                        break;
                    }

                    
                }
                start = restart(); //prompt to restart or quit
                Console.WriteLine();
            }
            
        }

        public static void PrintArray(string[] names) // method for printing name of selected array
        {
            Console.WriteLine("Printing Array");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine((i+1) + " " + names[i]);
            }
            Console.WriteLine();
        }

        public static string PromptUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().Trim(); //saves user input, and trims excess whitespace/spaces

                return input;
        }

        public static bool restart()
        {
                Console.WriteLine("Do you want to know about another student? Y/N");
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }
                else //if user input is not "y" or "n"
                {
                    Console.WriteLine("I'm sorry, I'm afraid I can't do that, invalid input. Please try again.");
                    return restart();
                }
        } 
        
    }
}