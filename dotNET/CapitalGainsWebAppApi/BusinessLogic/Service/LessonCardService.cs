using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interface;
using Domain.Entities;
using Persistence.Interface; 
namespace BusinessLogic.Service
{
    class LessonCardService : ILessonCardService
    {
        private readonly ILessonCardRepository LessonCardRepository;

        public LessonCardService (ILessonCardRepository lessonCardRepository)
        {
            LessonCardRepository = lessonCardRepository;
        }
        public LessonCardEntity FindById(int id)
        {
            return LessonCardRepository.FindById(id);
        }
    }
}
