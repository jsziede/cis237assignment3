using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class ProtocolDroid : Droid //protocol droid inherits from droid
    {
        private int amountOfLangs;                      //integer to determine how many languages the user wants for their droid
        private const decimal COST_PER_LANG = 45.00m;   //the cost for one language

        public int AmountOfLangs
        {
            get { return amountOfLangs; }
            set { amountOfLangs = value; }
        }

        public ProtocolDroid(string material, string model, string color, int amountOfLangs)
            : base(material, model, color)      //the material, model, and color are all inherited from the main droid class
        {
            this.amountOfLangs = amountOfLangs; //stores all of the parameters for the protocol droid given from the UI by the user
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.amountOfLangs.ToString();   //override ToString so that the amount of languages the user wants for their droid is printed, along with the base parameters
        }

        public override decimal CalculateTotalCost()
        {
            return base.CalculateTotalCost() + (Convert.ToDecimal(amountOfLangs) * COST_PER_LANG);  //the cost determined from the droid class is added with the costs of all the languages the user wants
        }
    }
}
