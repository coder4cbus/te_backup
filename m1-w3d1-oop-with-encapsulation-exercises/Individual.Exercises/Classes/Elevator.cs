using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        //class properties listed below...
        private int currentLevel;
        //private int numberOfLevels;
        private bool doorIsOpen;

        //accessors
        public int CurrentLevel
        {
            get;
            private set;
        }
        public int NumberOfLevels
        {
            get;  
        }
        public bool DoorIsOpen
        {
            get;
            private set;
        }
        //constructor
        public Elevator(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
            CurrentLevel =1;
        }

        //methods
        public void OpenDoor()
        {
            DoorIsOpen =  true;
        }

        public void CloseDoor()
        {
            DoorIsOpen = false;
        }

        public void GoUp (int desiredFloor)
        {

            if (!DoorIsOpen && desiredFloor > CurrentLevel && desiredFloor <= NumberOfLevels)
            {
                CurrentLevel = desiredFloor;
            }
            
        }
        public void GoDown(int desiredFloor)
        {
            if (!DoorIsOpen && desiredFloor < CurrentLevel && desiredFloor > 0)
            {
                CurrentLevel = desiredFloor;
            }
        }
    }

}
