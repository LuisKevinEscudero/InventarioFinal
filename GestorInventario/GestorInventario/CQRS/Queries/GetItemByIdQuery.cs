using GestorInventario.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorInventario.CQRS.Queries
{
    public class GetItemByIdQuery : IRequest<Item>
    {
        public int Id { get; set; }

        public GetItemByIdQuery(int id)
        {
            Id = id;
        }
    }
}