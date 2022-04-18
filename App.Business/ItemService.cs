using App.Domain.Entities;
using App.Domain.Interfaces.BusinessInterface;
using App.Domain.Interfaces.RepositoryInterfaces;
using App.Domain.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public class ItemService : IItemService
    {
        IItemRepository itemRepository;
        private readonly ILogger<ItemService> logger;
        public ItemService(
            IItemRepository itemRepository,
             ILogger<ItemService> _logger)
        {
            this.itemRepository = itemRepository;
            logger = _logger;
        }

        public Item Create(ItemModel item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Item>> GetAll()
        {
            return await itemRepository.GetAll();
        }

        public Task<Item> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ItemModel>> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public Item Update(ItemModel item, long id)
        {
            throw new NotImplementedException();
        }
    }
}
