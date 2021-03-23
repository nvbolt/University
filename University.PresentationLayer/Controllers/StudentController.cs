using Microsoft.AspNetCore.Mvc;
using University.DomainLayer.Entities;
using University.UseCaseLayer.Interfaces;

namespace University.PresentationLayer.Controllers
{
    public class StudentController: ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public bool Create(Student student)
        {
            return studentService.Create(student);
        }
    }
}
