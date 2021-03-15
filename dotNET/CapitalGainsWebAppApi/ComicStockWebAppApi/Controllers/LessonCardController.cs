using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapitalGainsWebAppApi.DTO;
using BusinessLogic.Interface;
using Domain.Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CapitalGainsWebAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonCardController : ControllerBase
    {
        private readonly ILessonCardService _LessonCardService; 

        public LessonCardController( ILessonCardService lessonCardService)
        {
            _LessonCardService = lessonCardService;
        }


        // GET: LessonCard
        [HttpGet]
        [Route("{id}")]
        public ActionResult<LessonCardDTO> Index(int id)
        {
            LessonCardDTO lessonCardDTO = new LessonCardDTO(_LessonCardService.FindById(id));
            return Ok(lessonCardDTO);
        }

    

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
