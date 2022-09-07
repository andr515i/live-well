using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace live_well.Rooms.Apartment_Sizes._1_Rooms
{
    class OneRoomApartment : Apartment
    {
        private int roomAmount;

        public int RoomAmount
        {
            get { return roomAmount; }
            set { roomAmount = value; }
        }

        private LivingRooms livingRoom;

        public LivingRooms LivingRoom
        {
            get { return livingRoom; }
        }



        public OneRoomApartment(int amountOfPanes) : base(amountOfPanes)
        {
            
            this.livingRoom = new LivingRooms(amountOfPanes);
        }
        
        internal override void AddDoorsAndWindows()
        {

        }
        internal override void GetSize()
        {

        }
        internal override void GetRoomAmount()
        {

        }
    }
}
