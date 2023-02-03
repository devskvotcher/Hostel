using System;
using System.Linq;
using System.Windows.Forms;
using Hostel.DataModel;
using Hostels.DataModel;
namespace Hostel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
           
           using (HostelContext context = new HostelContext())
            {
                var all = context.Bookings.ToList();
                if(all.Count == 0)
                { 
                Booking booking = new Booking();
                Client client = new Client();
                Room room = new Room();
                client.SurName = "test";
                client.Name = "test";
                client.LastName = "test";
                client.BDay = new DateTime(2015, 7, 20, 18, 30, 25);
                room.floor = 2;
                room.size = 2.ToString();
                context.Clients.Add(client);
                context.Rooms.Add(room);
                context.Bookings.Add(booking);
                context.SaveChanges();
                }
            } 
            UpdateHotel();
        }
        public void UpdateHotel()
        {
            using (HostelContext hostel = new HostelContext())
            {
                var all = hostel.Bookings.ToList();
                dataGridView1.RowCount = all.Count;
                dataGridView1.ColumnCount = 7;
                for (int i = 0; i < all.Count; i++)
                {
                    dataGridView1[0, i].Value = all[i].Id;
                    dataGridView1[1, i].Value = all[i].Client.SurName;
                    dataGridView1[2, i].Value = all[i].Client.Name;
                    dataGridView1[3, i].Value = all[i].Client.LastName;
                    dataGridView1[4, i].Value = all[i].Client.BDay.ToString();
                    dataGridView1[5, i].Value = all[i].Room.floor;
                    dataGridView1[6, i].Value = all[i].Room.size;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new AddForm(this);
            Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            int bookingId = int.Parse(dataGridView1[0, selectedRow].Value.ToString());
            using (HostelContext context = new HostelContext())
            {
                Booking booking = (from p in context.Bookings where p.Id == bookingId select p).FirstOrDefault();
                if (booking == null)
                {
                    MessageBox.Show("Пациент не выбран");
                }
                else
                {
                    context.Bookings.Remove(booking);
                    context.SaveChanges();
                    UpdateHotel();
                }
            }
        }
    }
}
