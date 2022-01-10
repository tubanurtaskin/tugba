using University.Application.Interfaces.Repositories;
using University.Domain.Models;
using University.Persistence.Context;

namespace University.Persistence.Repositories
{
    public class SectionRepository : GenericRepository<Section>, ISectionRepository
    {
        public SectionRepository(UniversityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
