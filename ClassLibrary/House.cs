using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class House : IPart
    {
        public const int COUNTWALL = 4;
        public const int COUNTOBJECT = 11;
        public bool IsStructurally { get; set; }
        public string house { get; set; }
        public Basement basement { get; set; }
        public Door door { get; set; }
        public Roof roof { get; set; }
        public Wall[] wall { get; set; }
        public Window[] window { get; set; }

        public House()
        {
            wall = new Wall[COUNTWALL];
            window = new Window[COUNTWALL];
        }

        public void Build()
        {
            IsStructurally = true;
        }

        public bool GetIsStructurally()
        {
            return IsStructurally;
        }

        public int GetCountWall()
        {
            return COUNTWALL;
        }

        public int GetCountObject()
        {
            return COUNTOBJECT;
        }
    }
}
