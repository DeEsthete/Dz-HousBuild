using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Door:IPart
    {
        public bool IsStructurally { get; set; }
        public string door { get; set; }

        public Door()
        {
            door = "-------\n" +
                   "|     |\n" +
                   "|     |\n" +
                   "|    *|\n" +
                   "|     |\n" +
                   "-------\n";
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
