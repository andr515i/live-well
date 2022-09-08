using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using live_well.Rooms.Apts;

namespace live_well
{
    class Program
    {
        // https://app.diagrams.net/?libs=general;uml
        // class diagram
        static void Main(string[] args)
        {
            Apt apt = new Apt(1, 0);  // 0 room apartment
            Console.WriteLine(apt.GetDoorCount() + " doors and " + apt.GetWindowCount() + " windows") ;

            Console.ReadLine();
        }
    }
}
