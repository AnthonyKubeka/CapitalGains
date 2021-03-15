using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityMapping;
namespace Persistence
{
    public class CapitalGainsDBContext : DbContext
    {
        public CapitalGainsDBContext (DbContextOptions contextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LessonCardMap());
        }
    }
}
