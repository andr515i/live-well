using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace live_well.Rooms.Windows
{
    class Window
    {
        private int amountOfPanes;

        public int AmountOfPanes
        {
            get { return amountOfPanes; }
            set { amountOfPanes = value; }
        }

        public Window(int AoP)
        {
            this.amountOfPanes = AoP;
        }

    }
}
