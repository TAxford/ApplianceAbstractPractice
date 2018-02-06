using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplianceAbstractPrcatice
{
    public abstract class Appliance
    {
        //field
        private bool isElectric;

        //Propertie
        public bool IsElectric
        {
            get { return this.isElectric; }
            set { this.isElectric = value; }
        }

        //Constructor - NONE

        //Methods
        public abstract void Work();











    }
}
