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
            //IDroid[] droids = new Droid[100];

            int userResponse = userInterface.MenuPrompt();
            
            while (userResponse != 3)
            {
                switch (userResponse.ToString())
                {
                    case "1":
                        droidsCollection.ReadArray();
                        userResponse = userInterface.MenuPrompt();
                        break;
                    case "2":
                        int modelResponse = userInterface.GetDroidModel();
                        switch (modelResponse.ToString())
                        {
                            case "1":
                                droidsCollection.AddProtocolDroid();
                                userResponse = userInterface.MenuPrompt();
                                break;
                            case "2":
                                droidsCollection.AddUtilityDroid();
                                userResponse = userInterface.MenuPrompt();
                                break;
                            case "3":
                                droidsCollection.AddJanitorDroid();
                                userResponse = userInterface.MenuPrompt();
                                break;
                            case "4":
                                droidsCollection.AddAstromechDroid();
                                userResponse = userInterface.MenuPrompt();
                                break;
                        }
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
