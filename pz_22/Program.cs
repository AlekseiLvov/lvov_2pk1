
namespace pz_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingTicket parkingTicket = new ParkingTicket();
            parkingTicket.getInfo();

            Console.WriteLine();

            DateTime Time = DateTime.Now;
            DateTime endTime = Time.AddMinutes(6);

            ParkingTicket info = new ParkingTicket(5);
            info.getInfo();

            Console.WriteLine();

            ParkingTicket ticket = new ParkingTicket();
            ticket.getInfo();

            Console.WriteLine();


            ParkingTicket tickets = new ParkingTicket();
            tickets.getInfo();

            Console.WriteLine();


            info.getticketsinfo();

        }
    }
}