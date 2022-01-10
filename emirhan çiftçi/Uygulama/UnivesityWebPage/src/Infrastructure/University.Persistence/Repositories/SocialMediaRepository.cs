using University.Application.Interfaces.Repositories;
using University.Domain.Models;
using University.Persistence.Context;

namespace University.Persistence.Repositories
{
    public class SocialMediaRepository : GenericRepository<SocialMedia>, ISocialMediaRepository
    {
        public SocialMediaRepository(UniversityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
