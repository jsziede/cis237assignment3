using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class JanitorDroid : UtilityDroid
    {
        private bool trashCompactor;            //bool if user wants a toolbox or not
        private bool vacuum;                    //bool if user wants a toolbox or not
        private decimal utilityJanitorCosts;    //decimal to determine the sum costs of all the added features that are specific to the janitor model
        
        public bool TrashCompactor 
        {
            get { return trashCompactor; }
            set { trashCompactor = value; }
        }

        public bool Vacuum 
        {
            get { return vacuum; }
            set { vacuum = value; }
        }

        public decimal UtilityJanitorCosts
        {
            get { return utilityJanitorCosts; }
            set { utilityJanitorCosts = value; }
        }

        public JanitorDroid(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base(material, model, color, toolbox, computerConnection, arm)    //material, model, color, toolbox, and arm are all inherited from UtilityDroid
                                                                                //UtilityDroid inherits model, color, and material from Droid
        {
            this.trashCompactor = trashCompactor;                               //these two variables are given from the user through the UI
            this.vacuum = vacuum;
        }

        public override string ToString()   //ToString is overridden so all parameters for the Janitor Droid are printed to the console
        {
            return base.ToString() + " " + this.trashCompactor.ToString() + " " + this.vacuum.ToString();
        }

        public override decimal CalculateTotalCost()
        {
            if (this.trashCompactor == true)
            {
                utilityJanitorCosts = utilityJanitorCosts + 40.00m; //if the user chose to add a trash compactor, the cost of the trash compactor is added to the sum cost of all features
            }
            if (this.vacuum == true)
            {
                utilityJanitorCosts = utilityJanitorCosts + 10.00m; //if the user chose to add a vacuum, the cost of the vacuum is added to the sum cost of all features
            }
            return base.CalculateTotalCost() + utilityJanitorCosts; //the cost of the droid that was determined from both the utility and droid classes is added with the possible costs of the added utilities
        }
    }
}
