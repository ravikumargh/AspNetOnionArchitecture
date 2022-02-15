using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Business.Interfaces
{
    public interface IApplicationDBContext
    {
        DbSet<Activity> Activity { get; set; }


    }
}
