using EF_Core_02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core_02.Configurations
{
    public class OrganizerProfileConfigurations : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(OP => OP.ProfileId);

            // Configure the relationship; 
            builder.HasOne(OP => OP.Organizer)
                   .WithOne(O => O.Profile)
                   .HasForeignKey<OrganizerProfile>(OP => OP.OrganizerId);
        }
    }
}
