using GestorInventario.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorInventario.CQRS.Queries
{
    public class GetItemsCategoryQuery : IRequest<List<ItemCategory>>
    {
        public List<ItemCategory> ItemCategories { get; set; }
    }
}