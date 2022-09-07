using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace live_well.Rooms.Doors
{
    class Door
    {
        private string doorType;

        public string DoorType
        {
            get { return doorType; }
            set { doorType = value; }
        }
        public Door()
        {
            this.doorType = "new";
        }
    }
}
