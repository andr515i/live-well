using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using live_well.Rooms.Windows;
namespace live_well.Rooms
{
     class LivingRooms : Bedroom
    {
        public LivingRooms(int amountOfPanes, int amountOfRooms) : base(amountOfPanes)
        {
            if (amountOfRooms >= 3)
            {
                this.Window = new MattedWindow(amountOfPanes);
            }
            else
            {
                this.Window = new Window(amountOfPanes);
            }
        }
    }
}
