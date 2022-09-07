using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace live_well.Rooms.Apts
{
    class Apt : Apartment
    {
        private Bedroom livingRoom;

        public Bedroom LivingRoom
        {
            get { return livingRoom; }
            set { livingRoom = value; }
        }
        
        private Bedroom bath;

        public Bedroom Bath
        {
            get { return bath; }
            set { bath = value; }
        }

        private int amountOfRooms;

        public Apt(int amountOfPanes, int amountOfRooms) : base(amountOfPanes, amountOfRooms)
        {
            this.livingRoom = new LivingRooms(amountOfPanes, amountOfRooms);
            this.bath = new Bath(amountOfPanes);

            this.amountOfRooms = amountOfRooms;

        }

        internal override int GetDoorCount()  // gets all doors
        {
            return GetRoomAmount() + 2; // always have a front and backdoor, therefore its just the room count + the front and backdoor
        }

        internal override int GetWindowCount() // gets all windwos
        {
            return GetRoomAmount(); // exact room count is the same as the exact window count
        }
        internal override int GetSize(int AoR)  // gets size of apartment
        {
            return AoR--;  // remove one room and we have the same number as the apartment size 
        }
        internal override int GetRoomAmount()  // gets total amount of room count 
        {
            return amountOfRooms + 3;  // as we always have 3 rooms no matter the size, we just need the extra rooms to be added aswell.
        }
    }
}
