using App.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.RepositoryInterfaces
{
    public interface IActivityRepository
    {
        Task<IList<Activity>> GetAll();
        Task<Activity> GetById(long id);
        Task<Activity> Create(ActivityModel activity);
        Task<Activity> Update(ActivityModel activity);
        Task<Boolean> Delete(Int64 id);
        Task<IList<ActivityModel>> SearchByName(string name);
    }
}
