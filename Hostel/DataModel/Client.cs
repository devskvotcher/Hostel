using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel.DataModel
{
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BDay { get; set; }

        public ICollection<Booking> Bookings = new List<Booking>();

    }
}
