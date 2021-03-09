using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class LessonCard
    {
        public Int32 LessonId { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public string Tags { get; set; }
        public string Category { get; set; }
        public Int32 Level { get; set; }
        public Int32 ExperiencePoints { get; set; }
    }
}
