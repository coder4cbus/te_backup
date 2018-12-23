using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        //class properties listed below...
        private string planeNumber;
        private int bookedFirstClassSeats;
        private int availableFirstClassSeats;
        private int totalFirstClassSeats;
        private int bookedCoachSeats;
        private int availableCoachSeats;
        private int totalCoachSeats;

        //accessors
        public string PlaneNumber
        {
            get;
        }

        public int BookedFirstClassSeats
        {
            get;
            private set;
        }
        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }
        public int TotalFirstClassSeats
        {
            get;
        }
        public int BookedCoachSeats
        {
            get;
            private set;
        }
        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }

        public int TotalCoachSeats
        {
            get;
        }

        //single constructor below...
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }

        //methods
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            bool seatStatus = false;
            if ((forFirstClass == true) && (totalNumberOfSeats <= AvailableFirstClassSeats))
            {
                seatStatus = true;
                BookedFirstClassSeats += totalNumberOfSeats;    
            }
            else if ((forFirstClass == false) && (totalNumberOfSeats <= AvailableCoachSeats))
            {
                seatStatus = true;
                BookedCoachSeats += totalNumberOfSeats;
                
            }
            return seatStatus;


        }

    }
}

