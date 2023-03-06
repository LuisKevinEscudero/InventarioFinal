using GestorInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorInventario.ViewModels
{
    public class ItemFormViewModel
    {
        public Item Item { get; set; }
        public List<ItemModel> ItemModels { get; set; }
        public List<ItemCategory> ItemCategories { get; set; }
    }
}