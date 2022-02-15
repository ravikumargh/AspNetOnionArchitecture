using App.Domain.Interfaces.BusinessInterface;
using App.Domain.Interfaces.RepositoryInterfaces;
using App.Domain.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public class ActivityService : IActivityService
    {
        IActivityRepository activityRepository;
        private readonly ILogger<ActivityService> logger;
        public ActivityService(
            IActivityRepository activityRepository,
             ILogger<ActivityService> _logger)
        {
            this.activityRepository = activityRepository;
            logger = _logger;
        }

        public Activity Create(ActivityModel activity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Activity>> GetAll()
        {
            return await activityRepository.GetAll();
        }

        public Task<Activity> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ActivityModel>> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public Activity Update(ActivityModel activity, long id)
        {
            throw new NotImplementedException();
        }
    }
}
