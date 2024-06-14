namespace SkillsTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Booking booking1 = new Booking(1, new DateTime(2024, 6, 16, 12, 0, 0), new DateTime(2024, 6, 16, 14, 0, 0), 10);
            Booking booking2 = new Booking(2, new DateTime(2024, 6, 16, 16, 0, 0), new DateTime(2024, 6, 16, 19, 0, 0), 15);
            Booking booking3 = new Booking(3, new DateTime(2024, 6, 17, 18, 0, 0), new DateTime(2024, 6, 17, 20, 0, 0), 23);
            Booking booking4 = new Booking(4, new DateTime(2024, 6, 18, 18, 0, 0), new DateTime(2024, 6, 18, 20, 0, 0), 20);
            Console.WriteLine("Tester klassen Booking");
            Console.WriteLine();
            Console.WriteLine(booking1);
            Console.WriteLine();
            Console.WriteLine(booking2);
            Console.WriteLine();
            Console.WriteLine(booking3);

            GymHall hall1 = new GymHall(1, "Store gymnastiksal", "Højbovænget 33", "42655443", "HøjenHjælp@hotmail.com");
            GymHall hall2 = new GymHall(2, "Lille gymnastiksal", "Højbovænget 33", "42655443", "HøjenHjælp@hotmail.com");
            

            Console.WriteLine();
            Console.WriteLine("Tester klassen Gymhall");
            Console.WriteLine();
            Console.WriteLine(hall1);
            Console.WriteLine();
            Console.WriteLine(hall2);
            Console.WriteLine();
            

            hall1.RegisterBooking(booking1);
            hall1.RegisterBooking(booking3);
            hall2.RegisterBooking(booking4);
            hall2.RegisterBooking(booking2);
        

            Console.WriteLine();
            Console.WriteLine("Tester CRUD metoder");
            Console.WriteLine("Liste af bookings");
            
            hall1.PrintBookings();
            hall2.PrintBookings();
       

            hall2.Removebooking(booking2);
            Console.WriteLine();
            Console.WriteLine("Opdateret Liste efter slettelse af booking nummer 2:");

            hall1.PrintBookings();
            hall2.PrintBookings();
      
            Console.WriteLine();
            Console.WriteLine("Test om bookings er 2 timer eller mindre, og om det er på en søndag");
            Console.WriteLine();

            Console.WriteLine($"Booking 1 er booket i mindre end 2 timer eller 2 timer præcist:{booking1.BookingDurationOK}");
            Console.WriteLine($"Booking 1 er booket på en søndag: {booking1.IsSundayBooking}");
            Console.WriteLine();
            Console.WriteLine($"Booking 2 er booket i mindre end 2 timer eller 2 timer præcist:{booking2.BookingDurationOK}");
            Console.WriteLine($"Booking 2 er booket på en søndag: {booking2.IsSundayBooking}");
            Console.WriteLine();
            Console.WriteLine($"Booking 3 er booket i mindre end 2 timer eller 2 timer præcist:{booking3.BookingDurationOK}");
            Console.WriteLine($"Booking 3 er booket på en søndag: {booking3.IsSundayBooking}");
            Console.WriteLine();
            Console.WriteLine($"Booking 4 er booket i mindre end 2 timer eller 2 timer præcist:{booking4.BookingDurationOK}");
            Console.WriteLine($"Booking 4 er booket på en søndag: {booking4.IsSundayBooking}");

            Console.WriteLine($"Total Bookings i hal 1: {hall1.TotalBookings}");
            Console.WriteLine($"Total Bookings i hal 2: {hall2.TotalBookings}");
            Console.WriteLine();
            

            Console.WriteLine();
            Console.WriteLine("Exception handling");
            Console.WriteLine();
            Console.WriteLine("Test af booking 3");
            try
            {
                hall1.Validate();
                Console.WriteLine("Booking valideret");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                hall2.Validate();
                Console.WriteLine("Booking er valideret");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





















        }

    }
}
