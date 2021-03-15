using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class LessonCardEntity
    {
        public int LessonID { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public string Tags { get; set; }
        public string Category { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }

    }
}
