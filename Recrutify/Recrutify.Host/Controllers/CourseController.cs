using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Recrutify.DataAccess;
using Recrutify.Host.Service;

namespace Recrutify.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CoursesService courseService;

        public CourseController(CoursesService coursesService)
        {
            courseService = coursesService;
        }

        [HttpGet]
        public ActionResult<List<Course>> Index() => Ok(courseService.Read());

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            courseService.Creat(course);
            return CreatedAtRoute("GetStudent", new { id = course.Id }, course);
        }
    }
}
