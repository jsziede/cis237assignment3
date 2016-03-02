using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UtilityDroid : Droid
    {
        private bool toolbox;               //bool if user wants a toolbox or not
        private bool computerConnection;    //bool if user wants a toolbox or not
        private bool arm;                   //bool if user wants a toolbox or not
        private decimal utilityCosts;       //decimal to determine the sum costs of all the added features

        public bool Toolbox
        {
            get { return toolbox; }
            set { toolbox = value; }
        }

        public bool ComputerConnection
        {
            get { return computerConnection; }
            set { computerConnection = value; }
        }

        public bool Arm
        {
            get { return arm; }
            set { arm = value; }
        }

        public decimal UtilityCosts
        {
            get { return utilityCosts; }
            set { utilityCosts = value; }
        }

        public UtilityDroid(string material, string model, string color, bool toolbox, bool computerConnection, bool arm)
            : base(material, model, color)      //utility droid inherits material, model, and color option from the base droid class
        {
            this.toolbox = toolbox;                         //these three variables are all based on the user's choice from the UI
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        public override string ToString()   //overrides the defualt ToString so all the utility droid's parameters are printed
        {
            return base.ToString() + " " + this.toolbox.ToString() + " " + this.computerConnection.ToString() + " " + this.arm.ToString();
        }

        public override decimal CalculateTotalCost()
        {
            if (this.toolbox == true)
            {
                utilityCosts = utilityCosts + 20.00m;           //if the user chose to add a toolbox, the cost of the toolbox is added to the sum cost of all features
            }
            if (this.computerConnection == true)
            {
                utilityCosts = utilityCosts + 30.00m;           //if the user chose to add a computer connection, the cost of the computer connection is added to the sum cost of all features
            }
            if (this.arm == true)
            {
                utilityCosts = utilityCosts + 25.00m;           //if the user chose to add a arm, the cost of the arm is added to the sum cost of all features
            }
            return base.CalculateTotalCost() + utilityCosts;    //the cost of the droid is added to the sum cost of the added features
        }
    }
}
