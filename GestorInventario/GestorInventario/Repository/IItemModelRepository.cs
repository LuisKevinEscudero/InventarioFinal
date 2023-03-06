using GestorInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorInventario.Repository
{
    public interface IItemModelRepository
    {
        IEnumerable<ItemModel> GetAll();
        ItemModel Get(int id);
        void Add(ItemModel itemModel);
        void Remove(ItemModel itemModel);
    }
}