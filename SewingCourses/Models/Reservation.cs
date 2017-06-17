using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingCourses.Models
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservationId { get; set; }

        public DateTime MadeDate { get; set; }

        public ReservationState State { get; set; }

        public enum ReservationState
        {
            Active,
            Paid,
            Expired,
            Canceled,
            Done
        }
    }
}
