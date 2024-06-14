using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Booking
    {
        public int Id { get; private set; }

        public DateTime Start { get; private set; }

        public DateTime End { get; private set; }

        public int Participants { get; private set; }



        public Booking(int id, DateTime start, DateTime end, int participants)

        {
            Id = id;
            Start = start;
            End = end;
            Participants = participants;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Start: {Start}, End: {End}, Participants: {Participants}";
        }


        public bool BookingDurationOK
        {
            get 
            {
                return Start.AddHours(2) >= End; 
            }
        }

        public bool IsSundayBooking
        {
            get
            {
                return Start.DayOfWeek == DayOfWeek.Sunday;
            }
        }


    }
}
