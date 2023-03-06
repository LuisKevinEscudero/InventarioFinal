using GestorInventario.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorInventario.CQRS.Queries
{
    public class GetItemsModelQuery : IRequest<List<ItemModel>>
    {
        public List<ItemModel> ItemModels { get; set; }
    }
}