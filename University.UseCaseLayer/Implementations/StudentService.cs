using System;
using University.DomainLayer.Entities;
using University.DomainLayer.Repositories;
using University.UseCaseLayer.Interfaces;

namespace University.UseCaseLayer.Implementations
{
    public class StudentService : IStudentService
    {
        readonly IStudentRepository studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public bool Create(Student student)
        {
            try
            {
                studentRepository.Create(student);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
