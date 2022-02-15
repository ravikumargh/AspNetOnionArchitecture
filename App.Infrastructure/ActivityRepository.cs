using App.Domain.Interfaces.RepositoryInterfaces;
using App.Domain.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure
{
    public class ActivityRepository : IActivityRepository
    {
        ApplicationDbContext context;
        private readonly ILogger<ActivityRepository> logger;
        public ActivityRepository(ApplicationDbContext context, ILogger<ActivityRepository> _logger)
        {
            this.context = context;
            logger = _logger;
        }

        public Task<Activity> Create(ActivityModel activity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Activity>> GetAll()
        {
            try
            {
                return (IList<Activity>)await context.Activity.ToListAsync();
                 
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<Activity> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ActivityModel>> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Activity> Update(ActivityModel activity)
        {
            throw new NotImplementedException();
        }
    }
}
