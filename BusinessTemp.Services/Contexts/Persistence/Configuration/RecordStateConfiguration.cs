using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Portable.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Business.Services.Contexts.Persistence.Configuration
{
    public class RecordStateConfiguration : ComplexTypeConfiguration<RecordState>
    {
        public RecordStateConfiguration()
        {
            this.Property(t => t.CreatedByUserId).IsRequired().HasMaxLength(100).HasColumnName("CreatedByUserId");
            this.Property(t => t.CreatedDateTime).IsRequired().HasColumnName("CreatedDateTime");
            this.Property(t => t.ModfiedByUserId).IsRequired().HasMaxLength(100).HasColumnName("ModfiedByUserId");
            this.Property(t => t.ModifiedDateTime).IsRequired().HasColumnName("ModifiedDateTime");
            this.Property(t => t.RecordStateType).IsRequired().HasColumnName("RecordStateType");
        }
    }
}