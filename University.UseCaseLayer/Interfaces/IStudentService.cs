using University.DomainLayer.Entities;

namespace University.UseCaseLayer.Interfaces
{
    public interface IStudentService
    {
        public bool Create(Student student);
    }
}
