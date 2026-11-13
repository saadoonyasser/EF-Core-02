using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EF_Core_02.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_02.Configurations
{
    public class EventConfigurations : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(E => E.EventId); // u asked for fluent api in event class;

            builder.HasOne(E => E.Organizer)
                .WithMany(O => O.Events)
                .HasForeignKey(E => E.OrganizerId);
        }
    }
}
