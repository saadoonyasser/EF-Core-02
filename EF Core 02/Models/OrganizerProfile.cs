using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_02.Models
{
    public class OrganizerProfile
    {
        // i will not use [Key]
        // Because the assignment doc requires fluent Api for OrganizerProfile Table
        public int ProfileId { get; set; } // Will be PK by fluent Api
        public string Bio { get; set; } = null!;
        public string WebsiteLink { get; set; } = null!;
        public string LogoPhotoLink { get; set; } = null!;

        // Navigation Property
        public Organizer Organizer { get; set; } = null!;

        // FK Column 
        public int OrganizerId { get; set; }

    }
}
