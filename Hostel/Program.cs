using System;
using System.Windows.Forms;
using Hostel.DataModel;
using Hostels.DataModel;
namespace Hostel
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
          //  using (HostelContext context = new HostelContext())
          //  {
          //      Client clients = new Client();
          //      clients.ClientId = 1;
          //      clients.SurName = "Test";
          //      clients.Name = "Test";
          //      clients.LastName = "Петя";
          //      clients.BDay = new DateTime(1978, 6, 8, 3, 5, 0); ;
          //      context.Clients.Add(clients);
          //      
          //      Booking bookings = new Booking();
          //      bookings.Id = 1;
          //      bookings.ClientId = 3;
          //      bookings.RoomId = 1;
          //      context.Bookings.Add(bookings);
          //      Room rooms = new Room();
          //      rooms.RoomId = 1;
          //      rooms.size = "2";
          //      rooms.floor = 3;
          //      context.Rooms.Add(rooms);
          //      context.SaveChanges();
          //  }
        }
    }
}
