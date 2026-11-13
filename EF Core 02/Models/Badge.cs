using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_02.Models
{
    public class Badge
    {
        public int BadgeId { get; set; } // Convention
        // i will not define PK by fluent api enough

        public DateTime IssueDate { get; set; }
        public string Tier { get; set; } = null!;

        // Relation between the badge and the attendee 

        // Navigation Property: 
        public Attendee Attendee { get; set; } = null!;

        // The FK Column 
        public int AttendeeId { get; set; } // It will work by cinvention and i will add it also by Fluent API
    }
}
