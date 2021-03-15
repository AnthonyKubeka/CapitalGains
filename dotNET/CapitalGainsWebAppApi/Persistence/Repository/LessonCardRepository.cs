using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Persistence.Interface;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repository
{
    public class LessonCardRepository : ILessonCardRepository
    {
        private readonly DbContext Context;  

        public LessonCardRepository (DbContext context)
        {
            Context = context;
        }
        public LessonCardEntity FindById(int id)
        {
            var lessonCard = Context.Set<LessonCardEntity>()
                .FirstOrDefault(l => l.LessonID == id);

            return lessonCard;
        }
    }
}
