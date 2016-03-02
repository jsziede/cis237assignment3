using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UtilityDroid : Droid
    {
        private bool toolbox;
        private bool computerConnection;
        private bool arm;

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

        public UtilityDroid(string material, string model, string color, bool toolbox, bool computerConnection, bool arm)
            : base(material, model, color)
        {
            this.toolbox = toolbox;
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.toolbox.ToString() + " " + this.computerConnection.ToString() + " " + this.arm.ToString();
        }

        public override void CalculateTotalCost()
        {
            
        }
    }
}
