using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        private DroidCollection[] droidsCollection = new DroidCollection[100];
        private int droidsInArray = 0;
        private string droidInformation = null;

        public DroidCollection[] DroidsCollection
        {
            get { return droidsCollection; }
            set { droidsCollection = value; }
        }

        public int DroidsInArray
        {
            get { return droidsInArray; }
            set { droidsInArray = value; }
        }

        public string DroidInformation
        { 
            get { return droidInformation; }
            set {droidInformation = value; }
        }

        public void ReadDroidArray (DroidCollection[] droidsCollection, int droidsInArray)
        {
            this.droidsCollection = droidsCollection;
            this.droidsInArray = droidsInArray;
            readArray();
        }

        public void AddDroid(int droidsInArray, string droidInformation)
        {
            
        }

        private void readArray()
        {

        }
    }
}
