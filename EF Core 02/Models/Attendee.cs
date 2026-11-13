using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_02.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; } // PK --> By convention;

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; } = null!;

        [Required]
        [MaxLength(200)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Street { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string City { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Country { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [Column("ZipCode")]
        public string PostalCode { get; set; } = null!;

        [NotMapped]
        public string FullAddress => $"{Street}, {City}, {Country}, {PostalCode}";
        // Read Only;;; and has the values of the full address in single line as required;


        // The relationship between the attendee and the badge 

        // Navigation Property 
        public Badge? Badge { get; set; } 



    }
}
