using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public abstract class Droid : IDroid    //droid class inherits from droid interface
    {
        private string material;    //material of droid
        private string model;       //model of droid
        private string color;       //color of droid
        private decimal baseCost;   //base cost of droid, which is determined by its model
        private decimal totalCost;  //total cost of droid, which is determined by every parameted of the droid

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
            return this.material + " " + this.model + " " + this.color; //override string so that the droid's material, model, and color are printed
        }

        public virtual decimal CalculateTotalCost() //calculates the total cost of the droid
        {
            CalculateBaseCost();                    //calls the CalculateBaseCost method
            totalCost = baseCost;                   //as this is the most basic form of droid, only the base model cost will affect the cost
            return totalCost;                       //total cost is returned
        }

        public void CalculateBaseCost()             //method to determine the cost of the droid based on its model
        {
            switch (material)                       //the material, chosen from the UI by the user, is used as reference for the switch
            {
                case "Iron":
                    baseCost = 100.00m;             //iron droid costs 100
                    break;
                case "Steel":
                    baseCost = 145.00m;             //steel droid costs 145
                    break;
                case "Gold" :
                    baseCost = 190.00m;             //gold droid costs 190
                    break;
            }
        }
    }
}
