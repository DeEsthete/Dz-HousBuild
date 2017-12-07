using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Basement:IPart
    {
        public bool IsStructurally { get; set; }
        public string basement { get; set; }

        public Basement()
        {
            basement = "======================================";
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
