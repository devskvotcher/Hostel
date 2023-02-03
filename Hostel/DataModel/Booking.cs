using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel.DataModel
{
    public class Booking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public int ClientId { get; set; }
        public int RoomId { get; set; }
        
        public virtual Client Client { get; set; }
        
        public virtual Room Room { get; set; }
    }
}
