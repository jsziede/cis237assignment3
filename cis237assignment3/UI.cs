using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UI
    {
        public int MenuPrompt()
        {
            this.printMenuPrompt();
            string promptResponse = Console.ReadLine();                                                                 //program records the user's response to the promptResponse string
            while (promptResponse != "1" && promptResponse != "2" &&
                 promptResponse != "3" && promptResponse != "4")                                                        //runs while the user continues to provide an invalid response
            {
                Console.WriteLine("Error. Please select a valid number." + Environment.NewLine);                        //user is told that their response was invalid
                this.printMenuPrompt();                                                                                 //user is listed the options once again
                promptResponse = Console.ReadLine();                                                                    //program records the user's response again
            }
            return Int32.Parse(promptResponse);                                                                         //returns any valid response from the user
        }

        public void Close()
        {
            Console.WriteLine("You are now leaving the program.");  //a message that is printed after the user chose to close the program
        }

        public void InvalidMenuResponse()
        {
            Console.WriteLine("Invalid selection. Please choose one of the above options.");    //a message to warn the user that their response from the main menu is invalid
        }

        public int GetDroidModel()
        {
            Console.WriteLine("Please select a model.");
            this.printModelPrompt();
            string promptResponse = Console.ReadLine();                                                                 //program records the user's response to the promptResponse string
            while (promptResponse != "1" && promptResponse != "2" &&
                 promptResponse != "3" && promptResponse != "4")                                                        //runs while the user continues to provide an invalid response
            {
                Console.WriteLine("Error. Please select a valid number." + Environment.NewLine);                        //user is told that their response was invalid
                this.printModelPrompt();                                                                                //user is listed the options once again
                promptResponse = Console.ReadLine();                                                                    //program records the user's response again
            }
            return Int32.Parse(promptResponse);                                                                         //returns any valid response from the user
        }

        public string GetDroidMaterial()
        {
            Console.WriteLine("Please select a model.");
            this.printMaterialPrompt();
            string promptResponse = Console.ReadLine();                                                                 //program records the user's response to the promptResponse string
            while (promptResponse != "1" && promptResponse != "2" &&
                 promptResponse != "3")                                                                                 //runs while the user continues to provide an invalid response
            {
                Console.WriteLine("Error. Please select a valid number." + Environment.NewLine);                        //user is told that their response was invalid
                this.printMaterialPrompt();                                                                             //user is listed the options once again
                promptResponse = Console.ReadLine();                                                                    //program records the user's response again
            }
            ///the return value is based on the user's selection
            if (promptResponse == "1")                                                                                  
            {
                return "Iron";
            }
            else if (promptResponse == "2")
            {
                return "Steel";
            }
            else
            {
                return "Gold";
            }

        }

        public string GetDroidColor()
        {
            Console.WriteLine("Please select a color.");
            this.printColorPrompt();
            string promptResponse = Console.ReadLine();                                                                 //program records the user's response to the promptResponse string
            while (promptResponse != "1" && promptResponse != "2" &&
                 promptResponse != "3")                                                                                 //runs while the user continues to provide an invalid response
            {
                Console.WriteLine("Error. Please select a valid number." + Environment.NewLine);                        //user is told that their response was invalid
                this.printColorPrompt();                                                                                //user is listed the options once again
                promptResponse = Console.ReadLine();                                                                    //program records the user's response again
            }
            ///the return value is based on the user's selection
            if (promptResponse == "1")                                                                                  
            {
                return "White";
            }
            else if (promptResponse == "2")
            {
                return "Blue";
            }
            else
            {
                return "Green";
            }

        }

        public int GetNumberOfLangs()
        {
            Console.WriteLine("How many languages do you want?" + Environment.NewLine +
                "Please answer with an integer.");
            string userInput = Console.ReadLine();
            int i;                                                                              //integer to use as a reference for the tryparse
            while (Int32.TryParse(userInput, out i) == false)                                   //program checks if the user's response is an integer
            {
                Console.WriteLine("How many languages do you want?" + Environment.NewLine +
                "Please answer with an integer.");
                userInput = Console.ReadLine();                                                 //while loop prevents user from advancing until the user has enetered an integer
            }
            return Int32.Parse(userInput);                                                      //a valid integer is returned
        }

        public bool GetToolbox()
        {
            Console.WriteLine("Would you like to add a toolbox?" + Environment.NewLine + 
                "Press 1 for yes or 2 for no.");
            string promptResponse = Console.ReadLine();                                                                 //program records the user's response to the promptResponse string
            while (promptResponse != "1" && promptResponse != "2")                                                      //runs while the user continues to provide an invalid response
            {
                Console.WriteLine("Error. Please select a valid number." + Environment.NewLine);                        //user is told that their response was invalid
                promptResponse = Console.ReadLine();                                                                    //program records the user's response again
            }
            ///the return value is based on the user's selection
            if (promptResponse == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetCompConnection()
        {
            Console.WriteLine("Would you like to add a computer connection?" + Environment.NewLine +
                "Press 1 for yes or 2 for no.");
            string promptResponse = Console.ReadLine();                                                                 //program records the user's response to the promptResponse string
            while (promptResponse != "1" && promptResponse != "2")                                                      //runs while the user continues to provide an invalid response
            {
                Console.WriteLine("Error. Please select a valid number." + Environment.NewLine);                        //user is told that their response was invalid
                promptResponse = Console.ReadLine();                                                                    //program records the user's response again
            }
            ///the return value is based on the user's selection
            if (promptResponse == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetArm()
        {
            Console.WriteLine("Would you like to add an extra arm?" + Environment.NewLine +
                "Press 1 for yes or 2 for no.");
            string promptResponse = Console.ReadLine();                                                                 //program records the user's response to the promptResponse string
            while (promptResponse != "1" && promptResponse != "2")                                                      //runs while the user continues to provide an invalid response
            {
                Console.WriteLine("Error. Please select a valid number." + Environment.NewLine);                        //user is told that their response was invalid
                promptResponse = Console.ReadLine();                                                                    //program records the user's response again
            }
            ///the return value is based on the user's selection
            if (promptResponse == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetTrashCompactor()
        {
            Console.WriteLine("Would you like to add a trash compactor?" + Environment.NewLine +
                "Press 1 for yes or 2 for no.");
            string promptResponse = Console.ReadLine();                                                                 //program records the user's response to the promptResponse string
            while (promptResponse != "1" && promptResponse != "2")                                                      //runs while the user continues to provide an invalid response
            {
                Console.WriteLine("Error. Please select a valid number." + Environment.NewLine);                        //user is told that their response was invalid
                promptResponse = Console.ReadLine();                                                                    //program records the user's response again
            }
            ///the return value is based on the user's selection
            if (promptResponse == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetVacuum()
        {
            Console.WriteLine("Would you like to add a vacuum?" + Environment.NewLine +
                "Press 1 for yes or 2 for no.");
            string promptResponse = Console.ReadLine();                                                                 //program records the user's response to the promptResponse string
            while (promptResponse != "1" && promptResponse != "2")                                                      //runs while the user continues to provide an invalid response
            {
                Console.WriteLine("Error. Please select a valid number." + Environment.NewLine);                        //user is told that their response was invalid
                promptResponse = Console.ReadLine();                                                                    //program records the user's response again
            }
            ///the return value is based on the user's selection
            if (promptResponse == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetFireExtinguisher()
        {
            Console.WriteLine("Would you like to add a fire extinguisher?" + Environment.NewLine +
                "Press 1 for yes or 2 for no.");
            string promptResponse = Console.ReadLine();                                                                 //program records the user's response to the promptResponse string
            while (promptResponse != "1" && promptResponse != "2")                                                      //runs while the user continues to provide an invalid response
            {
                Console.WriteLine("Error. Please select a valid number." + Environment.NewLine);                        //user is told that their response was invalid
                promptResponse = Console.ReadLine();                                                                    //program records the user's response again
            }
            ///the return value is based on the user's selection
            if (promptResponse == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetNumberShips()
        {
            Console.WriteLine("How many ships do you want?" + Environment.NewLine +
                "Please answer with an integer.");
            string userInput = Console.ReadLine();
            int i;                                                                              //integer to use as a reference for the tryparse
            while (Int32.TryParse(userInput, out i) == false)                                   //program checks if the user's response is an integer
            {
                Console.WriteLine("How many ships do you want?" + Environment.NewLine +
                "Please answer with an integer.");
                userInput = Console.ReadLine();                                                 //while loop prevents user from advancing until the user has enetered an integer
            }
            return Int32.Parse(userInput);                                                      //a valid integer is returned
        }

        private void printMenuPrompt()                          //menu to select which course of action the program should take
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. View Droids");
            Console.WriteLine("2. Add Droid");
            Console.WriteLine("3. Exit");
        }

        private void printModelPrompt()             //menu to determine what model of droid the user wants
        {
            Console.WriteLine("1. Protocol Droid");
            Console.WriteLine("2. Utility Droid");
            Console.WriteLine("3. Janitor Droid");
            Console.WriteLine("4. Astromech Droid");
        }

        private void printMaterialPrompt()  //menu to determine what material of droid the user wants
        {
            Console.WriteLine("1. Iron");
            Console.WriteLine("2. Steel");
            Console.WriteLine("3. Gold");
        }

        private void printColorPrompt()     //menu to determine what color of droid the user wants
        {
            Console.WriteLine("1. White");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Green");
        }
    }
}
