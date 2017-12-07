using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Window
    {
        public bool IsStructurally { get; set; }
        public string window { get; set; }

        public Window()
        {
            window = "-------\n" +
                     "|  |  |\n" +
                     "|__|__|\n" +
                     "|  |  |\n" +
                     "|__|__|\n";
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
