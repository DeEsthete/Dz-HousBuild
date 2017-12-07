using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Roof
    {
        public bool IsStructurally { get; set; }
        public string roof { get; set; }

        public Roof()
        {
            roof = "            //          \n" +
                   "          /////         \n" +
                   "        ////////        \n" +
                   "      ///////////       \n" +
                   "    //////////////      \n";
        }

        public void Build()
        {
            IsStructurally = true;
        }

        public bool GetIsStructurally()
        {
            return IsStructurally;
        }
    }
}
