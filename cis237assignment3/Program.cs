using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            UI userInterface = new UI();                                    //instanciates the user interface
            DroidCollection droidsCollection = new DroidCollection();       //instanciates the droid collection

            int userResponse = userInterface.MenuPrompt();                  //user is prompted the menu of tasks that the program can perform
            
            while (userResponse != 3)                                       //while the user has not selected the option to close the program
            {
                switch (userResponse.ToString())                            //case structure that uses the user's choice as a reference
                {
                    case "1":                                               //user has chosen to print the array
                        droidsCollection.ReadArray();                       //the method to print the array is called
                        userResponse = userInterface.MenuPrompt();          //user is prompted the menu of tasks that the program can perform
                        break;
                    case "2":                                               //user has chosen to add a droid to the array
                        int modelResponse = userInterface.GetDroidModel();  //method to choose the droid model is called and the user's choice of model is stored as an integer
                        switch (modelResponse.ToString())                   //the integer from the above line is used as reference for the case structure
                        {                                                   //this case structure runs certain code for each model
                            case "1":                                       //protocol droid case
                                droidsCollection.AddProtocolDroid();        //method to add a new protocol droid
                                userResponse = userInterface.MenuPrompt();  //user is prompted the menu of tasks that the program can perform
                                break;
                            case "2":                                       //utility droid case
                                droidsCollection.AddUtilityDroid();         //method to add new utility droid
                                userResponse = userInterface.MenuPrompt();  //user is prompted the menu of tasks that the program can perform
                                break;
                            case "3":                                       //janitor droid case
                                droidsCollection.AddJanitorDroid();         //method to add new janitor droid
                                userResponse = userInterface.MenuPrompt();  //user is prompted the menu of tasks that the program can perform
                                break;
                            case "4":                                       //astromech droid case
                                droidsCollection.AddAstromechDroid();       //method to add new astromech droid
                                userResponse = userInterface.MenuPrompt();  //user is prompted the menu of tasks that the program can perform
                                break;
                        }
                        break;
                    case "3":                                               //user has chosen to exit the program
                        userInterface.Close();                              //method to close the program is called
                        break;
                    default:                                                //user has chosen an invalid option
                        userInterface.InvalidMenuResponse();                //user is told of their invalid response
                        userResponse = userInterface.MenuPrompt();          //user is prompted the menu of tasks that the program can perform
                        break;
                }
            }
        }
    }
}
