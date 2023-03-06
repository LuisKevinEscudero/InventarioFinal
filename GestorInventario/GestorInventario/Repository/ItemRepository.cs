using GestorInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GestorInventario.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _context;

        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Item Add(Item item)
        {
            return _context.Items.Add(item);
        }

        public void Delete(Item item)
        {
            _context.Items.Remove(item);
        }

        public Item Get(int id)
        {
            var item = _context.Items
                .Include(m => m.Model)
                .Include(c => c.Category)
                .SingleOrDefault(i => i.Id == id);

            return item;
        }

        public List<Item> GetAll()
        {
            return _context.Items
                .Include(m => m.Model)
                .Include(c => c.Category)
                .ToList();
        }
    }
}