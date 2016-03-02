using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class JanitorDroid : UtilityDroid
    {
        private bool trashCompactor;
        private bool vacuum;
        
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

        public JanitorDroid(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base(material, model, color, toolbox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.trashCompactor.ToString() + " " + this.vacuum.ToString();
        }

        public override void CalculateTotalCost()
        {
            
        }
    }
}
