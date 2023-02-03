using Hostel.DataModel;
using Hostels.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel
{
    public partial class AddForm : Form
    {
        Form1 parentForm;
        Dictionary<string, int> keyValuePairsForSize = new Dictionary<string, int>();
        Dictionary<string, int> keyValuePairsForRoom = new Dictionary<string, int>();
        public AddForm(Form1 form1)
        {
            InitializeComponent();
            this.parentForm = new Form1();
            FillSize();
            FillFloor();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
           
        }
        private void FillFloor()
        {
            GetFloor.SelectedIndexChanged += GetFloor_SelectedIndexChanged;
            using (HostelContext context = new HostelContext())
            {
                var floor = context.Rooms;
                foreach (var item in floor)
                {
                    keyValuePairsForRoom[item.floor.ToString()] = item.RoomId;
                }
            }
            var keysForFloor = keyValuePairsForRoom.Keys.ToList();

            foreach (var item in keysForFloor)
            {
                GetFloor.Items.Add(item);
            }
        }

        private void FillSize()
        {
            GetSizeOfRoom.SelectedIndexChanged += GetSizeOfRoom_SelectedIndexChanged;
            using (HostelContext context = new HostelContext())
            {
                var size = context.Rooms;
                foreach (var item in size)
                {
                    keyValuePairsForSize[item.size] = item.RoomId;
                }
            }
            var keysForSize = keyValuePairsForSize.Keys.ToList();

            foreach (var item in keysForSize)
            {
                GetSizeOfRoom.Items.Add(item);
            }
        }

        

        private void GetFloor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetSizeOfRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private int GetIndexForFloor()
        {
            var id = keyValuePairsForRoom[GetSizeOfRoom.SelectedItem.ToString()];

            return id;
        }
        private int GetIndexForSize()
        {
            var id = keyValuePairsForSize[GetFloor.SelectedItem.ToString()];

            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (HostelContext context = new HostelContext())
            {
                Booking booking = new Booking();
                Client client = new Client();
                Room room = new Room();
                client.SurName = ClientSurName.Text;
                client.Name = ClientName.Text;
                client.LastName = ClientLastName.Text;
                client.BDay = ClientBDay.Value;
                context.Clients.Add(client);
                //booking.Client.SurName = ClientSurName.Text;
                // booking.Client.Name = ClientName.Text;
                //booking.Client.LastName = ClientLastName.Text;
                //  booking.Client.BDay = ClientBDay.Value;
                //  booking.Room.size = keyValuePairsForSize[GetIndexForSize().ToString()].ToString();
               room.size = 2.ToString();
             // room.size = (keyValuePairsForSize[GetIndexForSize().ToString()]).ToString();
                              // int roomId = GetIndexForFloor();
                              // Room room = (from d in context.Rooms
                              //                     where d.RoomId == roomId
                              //                     select d).FirstOrDefault();
                              // room.Bookings.Add(booking);
                              // int roomId1 = GetIndexForSize();
                              // Room room1 = (from d in context.Rooms
                              //                         where d.RoomId == roomId1
                              //                         select d).FirstOrDefault();
                              //   booking.Room.floor = keyValuePairsForRoom[GetIndexForFloor().ToString()];
                room.floor = 2;// keyValuePairsForRoom[GetIndexForFloor().ToString()];
               //// room.floor = keyValuePairsForRoom[GetIndexForFloor().ToString()];
                context.Rooms.Add(room);
                
                context.Bookings.Add(booking);




                context.SaveChanges();
            }

            MessageBox.Show("<Бронирование успешно добавлено");
            parentForm.UpdateHotel();
            Close();
            parentForm.Show();
        }
        private void ClientSurName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
