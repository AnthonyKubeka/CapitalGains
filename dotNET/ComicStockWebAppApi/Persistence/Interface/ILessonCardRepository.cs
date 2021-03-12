using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models; 
namespace Persistence.Interface
{
    public interface ILessonCardRepository
    {

        LessonCardEntity FindById(int id);
    }
}
