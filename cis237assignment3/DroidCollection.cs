using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        IDroid[] droids = new Droid[100];       //instanciates IDroid interface and Droid array
        private UI userInterface = new UI();    //instanciates user interface
        int positionInArray = 0;                //used to determine to first null element in the droids array
        string model;                           //variables used for the Droid class
        string color;                           //
        string material;                        //----------------------------------
        bool toolbox;                           //variables used for the Utlity class
        bool computerConnection;                //
        bool arm;                               //-----------------------------------

        public void AddProtocolDroid()                                                          //method used for adding a Protocol droid
        {
            model = "Protocol";                                                                 //model is named Protocol
            material = userInterface.GetDroidMaterial();                                        //user interface asks user which material to pick from
            color = userInterface.GetDroidColor();                                              //user interface asks user which color to pick from
            int amountOfLangs = userInterface.GetNumberOfLangs();                               //user interface asks user how many languages they want
            droids[positionInArray] = new ProtocolDroid(material, model, color, amountOfLangs); //final droid is added to the array
            Console.WriteLine(droids[positionInArray]);                                         //droid specs are printed to the console for the user to see
            positionInArray++;                                                                  //array index is changed so the recently added droid will not be overwritten
        }

        public void AddUtilityDroid()                                                                               //method used for adding a Utilty droid
        {
            model = "Utility";                                                                                      //model is named Utility
            material = userInterface.GetDroidMaterial();                                                            //user interface asks user which material to pick from
            color = userInterface.GetDroidColor();                                                                  //user interface asks user which color to pick from
            toolbox = userInterface.GetToolbox();                                                                   //user interface asks user if they want a toolbox for their droid
            computerConnection = userInterface.GetCompConnection();                                                 //user interface asks user if they want a computer connection for their droid
            arm = userInterface.GetArm();                                                                           //user interface asks user if they want an extra arm for their droid
            droids[positionInArray] = new UtilityDroid(material, model, color, toolbox, computerConnection, arm);   //final droid is added to the array
            Console.WriteLine(droids[positionInArray]);                                                             //droid specs are printed to the console for the user to see
            positionInArray++;                                                                                      //array index is changed so the recently added droid will not be overwritten
        }

        public void AddJanitorDroid()                                                                                                       //method used for adding a Janitor droid
        {
            model = "Janitor";                                                                                                              //model is named Janitor
            material = userInterface.GetDroidMaterial();                                                                                    //user interface asks user which material to pick from
            color = userInterface.GetDroidColor();                                                                                          //user interface asks user which color to pick from
            toolbox = userInterface.GetToolbox();                                                                                           //user interface asks user if they want a toolbox for their droid
            computerConnection = userInterface.GetCompConnection();                                                                         //user interface asks user if they want a computer connection for their droid
            arm = userInterface.GetArm();                                                                                                   //user interface asks user if they want an extra arm for their droid
            bool trashCompactor = userInterface.GetTrashCompactor();                                                                        //user interface asks user if they want a trash compactor for their droid
            bool vacuum = userInterface.GetVacuum();                                                                                        //user interface asks user if they want a vacuum for their droid
            droids[positionInArray] = new JanitorDroid(material, model, color, toolbox, computerConnection, arm, trashCompactor, vacuum);   //final droid is added to the array
            Console.WriteLine(droids[positionInArray]);                                                                                     //droid specs are printed to the console for the user to see
            positionInArray++;                                                                                                              //array index is changed so the recently added droid will not be overwritten
        }

        public void AddAstromechDroid()                                                                                                             //method used for adding an Astromech droid
        {
            model = "Astromech";                                                                                                                    //model is named Astromech
            material = userInterface.GetDroidMaterial();                                                                                            //user interface asks user which material to pick from
            color = userInterface.GetDroidColor();                                                                                                  //user interface asks user which color to pick from
            toolbox = userInterface.GetToolbox();                                                                                                   //user interface asks user if they want a toolbox for their droid
            computerConnection = userInterface.GetCompConnection();                                                                                 //user interface asks user if they want a computer connection for their droid
            arm = userInterface.GetArm();                                                                                                           //user interface asks user if they want an extra arm for their droid
            bool fireExtinguisher = userInterface.GetFireExtinguisher();                                                                            //user interface asks user if they want a fire extinguisher for their droid
            int numberShips = userInterface.GetNumberShips();                                                                                       //user interface asks user how many ships they want
            droids[positionInArray] = new AstromechDroid(material, model, color, toolbox, computerConnection, arm, fireExtinguisher, numberShips);  //final droid is added to the array
            Console.WriteLine(droids[positionInArray]);                                                                                             //droid specs are printed to the console for the user to see
            positionInArray++;                                                                                                                      //array index is changed so the recently added droid will not be overwritten
        }

        public void ReadArray()
        {
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
        }
    }
}
