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


        private FrontDoor frontDoor;
        public FrontDoor FrontDoor
        {
            get { return frontDoor; }
        }
        private BackDoor backDoor;

        public BackDoor BackDoor
        {
            get { return backDoor; }
        }

        private int wpR; // windows per room    

        public int WpR
        {
            get { return wpR; }
            set { wpR = value; }
        }

        private Kitchen kitchen;

        public Kitchen Kitchen
        {
            get { return kitchen; }
        }


        public Apartment(int amountOfPanes)
        {
            this.kitchen = new Kitchen(amountOfPanes);
            this.backDoor = new BackDoor();
            this.frontDoor = new FrontDoor();

        }

        internal abstract void AddDoorsAndWindows();  // adds all doors and windows together in seperate variables

        internal abstract void GetSize();  // gets size of apartment

        internal abstract void GetRoomAmount();  // gets total amount of room count 


    }
}
