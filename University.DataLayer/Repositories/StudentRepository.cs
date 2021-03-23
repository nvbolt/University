using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using University.DomainLayer.Entities;
using University.DomainLayer.Repositories;

namespace University.DataLayer.Repositories
{
    internal class StudentRepository: BaseRepository<long, Student>, IStudentRepository
    {
        public StudentRepository(VuDbContext dbContext) : base(dbContext)
        {
        }
    }
}