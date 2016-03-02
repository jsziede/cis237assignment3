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
            UI userInterface = new UI();
            DroidCollection droidsCollection = new DroidCollection();
            IDroid[] droids = new Droid[100];

            int positionInArray = 0;

            string model;
            string color;
            string material;

            bool toolbox;
            bool computerConnection;
            bool arm;

            int userResponse = userInterface.MenuPrompt();
            
            while (userResponse != 3)
            {
                switch (userResponse.ToString())
                {
                    case "1":
                        if (positionInArray == 0)
                        {
                            Console.WriteLine("No droids in the array!");
                        }
                        else
                        {
                            int a = 0;
                            while (a < positionInArray)
                            {
                                Console.WriteLine(droids[a].ToString());
                                a++;
                            }
                        }
                        userResponse = userInterface.MenuPrompt();
                        break;
                    case "2":
                        int modelResponse = userInterface.GetDroidModel();
                        switch (modelResponse.ToString())
                        {
                            case "1":
                                model = "Protocol";
                                material = userInterface.GetDroidMaterial();
                                color = userInterface.GetDroidColor();
                                int amountOfLangs = userInterface.GetNumberOfLangs();
                                droids[positionInArray] = new ProtocolDroid(material, model, color, amountOfLangs);
                                Console.WriteLine(droids[positionInArray]);
                                positionInArray++;
                                userResponse = userInterface.MenuPrompt();
                                break;
                            case "2":
                                model = "Janitor";
                                material = userInterface.GetDroidMaterial();
                                color = userInterface.GetDroidColor();
                                toolbox = userInterface.GetToolbox();
                                computerConnection = userInterface.GetCompConnection();
                                arm = userInterface.GetArm();
                                bool trashCompactor = userInterface.GetTrashCompactor();
                                bool vacuum = userInterface.GetVacuum();
                                droids[positionInArray] = new JanitorDroid(material, model, color, toolbox, computerConnection, arm, trashCompactor, vacuum);
                                Console.WriteLine(droids[positionInArray]);
                                positionInArray++;
                                userResponse = userInterface.MenuPrompt();
                                break;
                            case "3":
                                model = "Astromech";
                                material = userInterface.GetDroidMaterial();
                                color = userInterface.GetDroidColor();
                                toolbox = userInterface.GetToolbox();
                                computerConnection = userInterface.GetCompConnection();
                                arm = userInterface.GetArm();
                                bool fireExtinguisher = userInterface.GetFireExtinguisher();
                                int numberShips = userInterface.GetNumberShips();
                                droids[positionInArray] = new AstromechDroid(material, model, color, toolbox, computerConnection, arm, fireExtinguisher, numberShips);
                                Console.WriteLine(droids[positionInArray]);
                                positionInArray++;
                                userResponse = userInterface.MenuPrompt();
                                break;
                        }
                        //userResponse = userInterface.MenuPrompt();
                        break;
                    case "3":
                        userInterface.Close();
                        break;
                    default:
                        userInterface.InvalidMenuResponse();
                        userResponse = userInterface.MenuPrompt();
                        break;
                }
            }
        }
    }
}
