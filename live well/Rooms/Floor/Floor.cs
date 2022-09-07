using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace live_well.Rooms.Floors
{
    class Floor
    {
        private string floorType;

        public string FloorType
        {
            get { return floorType; }
            set { floorType = value; }
        }
        public Floor()
        {
            this.floorType = "new";
        }
    }
}
