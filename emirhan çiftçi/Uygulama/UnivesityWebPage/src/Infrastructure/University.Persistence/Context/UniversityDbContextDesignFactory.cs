using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace University.Persistence.Context
{
    public class UniversityDbContextDesignFactory : IDesignTimeDbContextFactory<UniversityDbContext>
    {
        public UniversityDbContextDesignFactory()
        {
        }

        public UniversityDbContext CreateDbContext(string[] args)
        {
            var connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDb;Persist Security Info=True;";

            var optionsBuilder = new DbContextOptionsBuilder<UniversityDbContext>()
                .UseSqlServer(connStr);

            return new UniversityDbContext(optionsBuilder.Options, new NoMediator());
        }

        class NoMediator : IMediator
        {
            public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default(CancellationToken)) where TNotification : INotification
            {
                return Task.CompletedTask;
            }

            public Task Publish(object notification, CancellationToken cancellationToken = default)
            {
                return Task.CompletedTask;
            }

            public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default(CancellationToken))
            {
                return Task.FromResult<TResponse>(default);
            }

            public Task<object> Send(object request, CancellationToken cancellationToken = default)
            {
                return Task.FromResult<object>(default);
            }
        }
    }
}
