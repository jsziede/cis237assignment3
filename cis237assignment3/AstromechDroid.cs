using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AstromechDroid : UtilityDroid
    {
        private bool fireExtinguisher;                  //bool if user wants a toolbox or not
        private int numberShips;                        //int to store the amount of ships the user wants for their droid
        private decimal fireExtinguisherCost;           //the cost of adding a fire extinguisher to a droid
        private const decimal COST_OF_SHIP = 50.00m;    //the cost for each ship added with a droid
        
        public bool FireExtinguisher  
        {
            get { return fireExtinguisher; }
            set { fireExtinguisher = value; }
        }

        public int NumberShips  
        {
            get { return numberShips; }
            set { numberShips = value; }
        }

        public decimal FireExtinguisherCost
        {
            get { return fireExtinguisherCost; }
            set { fireExtinguisherCost = value; }
        }

        public AstromechDroid(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(material, model, color, toolbox, computerConnection, arm)    //material, model, color, toolbox, and arm are all inherited from UtilityDroid
                                                                                //UtilityDroid inherits model, color, and material from Droid
        {
            this.fireExtinguisher = fireExtinguisher;                           //these two variables are given from the user through the UI
            this.numberShips = numberShips;
        }

        public override string ToString()   //ToString is overridden so all parameters for the Astromech Droid are printed to the console
        {
            return base.ToString() + " " + this.fireExtinguisher.ToString() + " " + this.numberShips.ToString();
        }

        public override decimal CalculateTotalCost()
        {
            if (this.fireExtinguisher == false)
            {
                fireExtinguisherCost = 0.00m;   //if the user chose not to add an extinguisher, they will not be charged an additional 10 dollars
            }
            else
            {
                fireExtinguisherCost = 10.00m;  //if the user chose to add an extinguisher, they will be charged an additional 10 dollars
            }
            return base.CalculateTotalCost() + fireExtinguisherCost + (Convert.ToDecimal(numberShips) * COST_OF_SHIP);  ///the cost of the droid that was determined from both the utility and droid classes is added with the
                                                                                                                        ///possible additional cost of the extinguisher and all the ships added with the droid
        }
    }
}
