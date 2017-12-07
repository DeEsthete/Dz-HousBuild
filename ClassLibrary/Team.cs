using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Team : IWorker
    {
        public Worker[] worker { get; set; }

        public Team()
        {
            worker = new Worker[3];
        }

        public bool Work(House house)
        {
            if (house.basement.GetIsStructurally() == false)
            {
                house.basement.Build();
                return true;
            }
            else if (house.door.GetIsStructurally() == false)
            {
                house.door.Build();
                return true;
            }
            for (int i = 0; i < house.wall.Length; i++)
            {
                if (house.wall[i].GetIsStructurally() == false)
                {
                    house.wall[i].Build();
                    return true;
                }
            }
            for (int i = 0; i < house.window.Length; i++)
            {
                if (house.window[i].GetIsStructurally() == false)
                {
                    house.window[i].Build();
                    return true;
                }
            }
            else if (house.roof.GetIsStructurally() == false)
            {
                house.roof.Build();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCountWorker()
        {
            return worker.Length;
        }

    }
}
