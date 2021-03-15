using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
namespace CapitalGainsWebAppApi.DTO
{
    public class LessonCardDTO
    {
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public string Tags { get; set; }
        public string Category { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }

        public LessonCardDTO(LessonCardEntity lessonCardEntity)
        {
            MapFromEntity(lessonCardEntity);
        }

        private void MapFromEntity (LessonCardEntity lessonCard)
        {
            Title = lessonCard.Title;
            DatePublished = lessonCard.DatePublished;
            Tags = lessonCard.Tags;
            Category = lessonCard.Category;
            Level = lessonCard.Level;
            ExperiencePoints = lessonCard.ExperiencePoints;
        }
    }
}
