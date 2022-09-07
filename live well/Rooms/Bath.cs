using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using live_well.Rooms.Windows;
namespace live_well.Rooms
{
    class Bath : Bedroom
    {
        public Bath(int amountOfPanes) : base(amountOfPanes)
        {
            if (amountOfPanes == 3)  // check if there's more than 3 bedrooms extra, so a 4 or above bedroom apartment, which means we need a matted window for the bath
            {
                this.Window = new MattedWindow(1);
            }
            else
            {
                this.Window = new Window(amountOfPanes);
            }
        }
    }
}
