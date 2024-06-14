using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class GymHall
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Address { get; private set; }

        public string Phone {  get; private set; }

        public string Email {  get; private set; }

        public int TotalBookings { get { return Bookings.Count; } }
        
        public Dictionary<int, Booking> Bookings { get; private set; }


        public GymHall(int id, string name, string address, string phone, string email)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            Bookings = new Dictionary<int, Booking>();
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Address: {Address}, Phone: {Phone}, Email: {Email}";
        }

        public void RegisterBooking(Booking booking)
        {
            if (!Bookings.ContainsKey(booking.Id))
            {
                Bookings.Add(booking.Id, booking);
            }
        }

        public void PrintBookings()
        {
            foreach (var booking in Bookings.Values)
            {
                Console.WriteLine(booking);
            }
        }

        public void Removebooking(Booking booking)
        {
            Bookings.Remove(booking.Id);
        }

        public void Validate()
        {
            foreach (var booking in Bookings.Values)
            {
                if (!booking.BookingDurationOK)
                {
                    throw new Exception("validering mislykkedes: Booking er længere end 2 timer");
                }

                if (booking.Participants > 22)
                {
                    throw new Exception("Validering mislykkedes: Der er mere end 22 deltagere i bookingen.");   
                }
            }

            



        }
    }
}
