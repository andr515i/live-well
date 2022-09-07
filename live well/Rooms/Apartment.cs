using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using live_well.Rooms.Floors;
using live_well.Rooms.Windows;
using live_well.Rooms.Doors;

namespace live_well.Rooms
{
    abstract class Apartment
    {  // base apartment class.
       // every apartment always has a livingroom, kitchen and a bath, along with a front and backdoor



        

        private protected FrontDoor frontDoor;
        private protected FrontDoor FrontDoor
        {
            get { return frontDoor; }
        }
        private protected BackDoor backDoor;

        private protected BackDoor BackDoor
        {
            get { return backDoor; }
        }

        private int wpR; // windows per room    

        private protected int WpR
        {
            get { return wpR; }
            set { wpR = value; }
        }

        private Bedroom kitchen;

        private protected Bedroom Kitchen
        {
            get { return kitchen; }
            set { kitchen = value; }
        }

        private Bedroom bedroom;

        private protected Bedroom Bedroom
        {
            get { return bedroom; }
            set { bedroom = value; }
        }



        public Apartment(int amountOfPanes, int amountOfRooms)
        {
            this.kitchen = new Kitchen(amountOfPanes);
            this.backDoor = new BackDoor();
            this.frontDoor = new FrontDoor();
            


            

        }

        internal abstract int GetDoorCount();  // adds all doors and windows together in seperate variables
        internal abstract int GetWindowCount();  // gets all windows

        internal abstract int GetSize(int AoR);  // gets size of apartment

        internal abstract int GetRoomAmount();  // gets total amount of room count 


    }
}
