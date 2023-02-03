using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel.DataModel
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int RoomId { get; set; }
        public int floor { get; set; }
        public string size { get; set; }

        public ICollection<Booking> Bookings = new List<Booking>();
    }
}
