    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Runtime;
    using System.Text;
    using System.Threading.Tasks;

    namespace EF_Core_02.Models
    {
        [Table("EventOrganizers")]
        public class Organizer
        {
            public int OrganizerId { get; set; } // PK by convention

            [Required]
            [MaxLength(100)]
            public string Name { get; set; } = null!;

            [MaxLength(150)]
            public string? CompanyName { get; set; } // Allow Null 
            public bool IsVerified { get; set; }

            // Navigation Property
            public OrganizerProfile? Profile { get; set; }

        public ICollection<Event> Events { get; set; } = new List<Event>();







    }
    }
