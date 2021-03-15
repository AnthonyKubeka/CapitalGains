using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace BusinessLogic.Interface
{
    interface ILessonCardService
    {
        LessonCardEntity FindById(int id);
    }
}
