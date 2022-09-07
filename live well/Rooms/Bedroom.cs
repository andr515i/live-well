using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using live_well.Rooms.Floors;
using live_well.Rooms.Windows;
using live_well.Rooms.Doors;

namespace live_well.Rooms
{  // i see a normal room as always having 1 door, atleast 1 window and it always has floor.
    class Bedroom
    {
        private protected Floor floor;

        public Floor Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        private protected Window window;

        public Window Window
        {
            get { return window; }
            set { window = value; }
        }

        private protected Door door;

        public Door Door
        {
            get { return door; }
            set { door = value; }
        }

        public Bedroom(int amountOfPanes)
        {
            this.door = new Door();
            this.floor = new Floor();
            this.window = new Window(amountOfPanes); 
        }


    }
}
