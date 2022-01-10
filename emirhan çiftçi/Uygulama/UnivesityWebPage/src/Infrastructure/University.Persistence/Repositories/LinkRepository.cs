using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Interfaces.Repositories;
using University.Domain.Models;
using University.Persistence.Context;

namespace University.Persistence.Repositories
{
    public class LinkRepository : GenericRepository<Link>, ILinkRepository
    {
        public LinkRepository(UniversityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
