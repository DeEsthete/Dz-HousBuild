    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Wall
    {
        public bool IsStructurally { get; set; }
        public string wall { get; set; }

        public Wall()
        {
            wall = "-----------------------------------------\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n";
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
