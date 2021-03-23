using University.DomainLayer.Entities;
using University.DomainLayer.Repositories;

namespace University.DataLayer.Repositories
{
    internal class GroupRepository : BaseRepository<long, Group>, IGroupRepository
    {
        public GroupRepository(VuDbContext dbContext) : base(dbContext)
        {
        }
    }
}
