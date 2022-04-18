using App.Domain.Entities;
using App.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.BusinessInterface
{
    public interface IItemService
    {
        Task<IList<Item>> GetAll();
        Task<Item> GetById(long id);
        Item Create(ItemModel item);
        Item Update(ItemModel item, Int64 id);
        Boolean Delete(Int64 id);
        Task<IList<ItemModel>> SearchByName(string name);
    }
}
