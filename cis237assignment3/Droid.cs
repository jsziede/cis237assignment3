using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public abstract class Droid : IDroid
    {
        private string material;
        private string model;
        private string color;
        private decimal baseCost;
        private decimal totalCost;

        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public Droid(string material, string model, string color)
        {
            this.material = material;
            this.model = model;
            this.color = color;
        }

        public override string ToString()
        {
            return this.material + " " + this.model + " " + this.color;
        }

        public virtual void CalculateTotalCost()
        {
            
        }

        public void CalculateBaseCost()
        {

        }
    }
}
