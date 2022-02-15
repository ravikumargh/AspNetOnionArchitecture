using App.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.BusinessInterface
{
    public interface IActivityService
    {
        Task<IList<Activity>> GetAll();
        Task<Activity> GetById(long id);
        Activity Create(ActivityModel activity);
        Activity Update(ActivityModel activity, Int64 id);
        Boolean Delete(Int64 id);
        Task<IList<ActivityModel>> SearchByName(string name);
    }
}
