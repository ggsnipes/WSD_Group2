using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebHotel.Models
{
    public class Customer
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Email { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string GivenName { get; set; }

        [Required]
        [RegularExpression(@"[0-9]{4}$")]
        public string Postcode { get; set; }

        public ICollection<Booking> TheBookings { get; set; }
    }
}
