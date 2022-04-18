using App.Domain.Entities;
using App.Domain.Interfaces.RepositoryInterfaces;
using App.Domain.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure
{
    public class ItemRepository : IItemRepository
    {
        ApplicationDbContext context;
        private readonly ILogger<ItemRepository> logger;
        public ItemRepository(ApplicationDbContext context, ILogger<ItemRepository> _logger)
        {
            this.context = context;
            logger = _logger;
        }

        public Task<Item> Create(ItemModel item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Item>> GetAll()
        {
            try
            {
                return (IList<Item>)await context.Activity.ToListAsync();
                 
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<Item> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ItemModel>> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Item> Update(ItemModel item)
        {
            throw new NotImplementedException();
        }
    }
}
