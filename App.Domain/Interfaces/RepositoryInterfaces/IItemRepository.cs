using App.Domain.Entities;
using App.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.RepositoryInterfaces
{
    public interface IItemRepository
    {
        Task<IList<Item>> GetAll();
        Task<Item> GetById(long id);
        Task<Item> Create(ItemModel item);
        Task<Item> Update(ItemModel item);
        Task<Boolean> Delete(Int64 id);
        Task<IList<ItemModel>> SearchByName(string name);
    }
}
