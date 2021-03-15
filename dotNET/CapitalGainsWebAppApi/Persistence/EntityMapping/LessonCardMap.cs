using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.EntityMapping 
{
    public class LessonCardMap : IEntityTypeConfiguration<LessonCardEntity>
    {

        public void Configure(EntityTypeBuilder<LessonCardEntity> builder) 
        {
            builder.HasKey(l => l.LessonID);
            builder.Property(t => t.DatePublished)
                .IsRequired()
                .HasColumnType("datetime")
                .HasDefaultValueSql("GetDate()");
        }

    }
}
