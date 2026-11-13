using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_02.Models
{
    public class Event
    {
        public int EventId { get; set; } // PK by Convention
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }

        public Organizer Organizer { get; set; } = null!;

        public int OrganizerId { get; set; } // By convention it will work 
        // and i will apply it by fluent Api acc to assignment requireements;

    }
}
