using GestorInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Repository
{
    public interface IItemRepository
    {
        Item Add(Item item);
        void Delete(Item item);
        Item Get(int id);
        List<Item> GetAll();
    }
}
