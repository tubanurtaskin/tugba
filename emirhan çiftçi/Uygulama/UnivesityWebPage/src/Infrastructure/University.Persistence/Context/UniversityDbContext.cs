using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using University.Domain.Models;
using University.Domain.SeedWork;
using University.Persistence.Extensions;

namespace University.Persistence.Context
{
    public class UniversityDbContext : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "university";
        private readonly IMediator mediator;

        public UniversityDbContext() : base()
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options, IMediator mediator) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
            this.mediator = mediator;
        }

        public DbSet<Section> Sections { get; set; }
        public DbSet<Link> Links { get; set; }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await mediator.DispatchDomainEventsAsync(this);
            await base.SaveChangesAsync(cancellationToken);

            return true;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
