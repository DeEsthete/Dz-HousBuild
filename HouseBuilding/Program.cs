using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TICK = 6;
            House house = new House();
            Team team = new Team();
            TeamLeader teamLeader = new TeamLeader();
            for (int i = 0; i < TICK; i++)
            {
                team.Work(house);
            }
            if (teamLeader.Work(house) == true)
            {
                Console.WriteLine("Строительство завершено");
                Console.WriteLine("           //        \n" +
                                  "         /////       \n" +
                                  "      /////////      \n" +
                                  "---------------------\n" +
                                  "|**************__***|\n" +
                                  "|*************|**|**|\n" +
                                  "|*******____***--***|\n" +
                                  "|*******|  |********|\n" +
                                  "|*******|  |********|\n" +
                                  "=====================\n" +
                                  "=====================\n");
            }
            else
            {
                Console.WriteLine("Строительство не завершено");
            }
        }
    }
}
