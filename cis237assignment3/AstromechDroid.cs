using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AstromechDroid : UtilityDroid
    {
        private bool fireExtinguisher;
        private int numberShips;
        
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

        public AstromechDroid(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(material, model, color, toolbox, computerConnection, arm)
        {
            this.fireExtinguisher = fireExtinguisher;
            this.numberShips = numberShips;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.fireExtinguisher.ToString() + " " + this.numberShips.ToString();
        }

        public override void CalculateTotalCost()
        {
            
        }
    }
}
