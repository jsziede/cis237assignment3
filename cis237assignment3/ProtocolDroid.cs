using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class ProtocolDroid : Droid
    {
        private int amountOfLangs;
        private const decimal COST_PER_LANG = 2.50m;

        public int AmountOfLangs
        {
            get { return amountOfLangs; }
            set { amountOfLangs = value; }
        }

        public ProtocolDroid(string material, string model, string color, int amountOfLangs)
            : base(material, model, color)
        {
            this.amountOfLangs = amountOfLangs;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.amountOfLangs.ToString();
        }

        public override void CalculateTotalCost()
        {
            //return base + (Convert.ToDecimal(this.amountOfLangs) * COST_PER_LANG);
        }
    }
}
