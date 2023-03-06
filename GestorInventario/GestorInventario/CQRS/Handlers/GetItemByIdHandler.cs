using GestorInventario.CQRS.Queries;
using GestorInventario.Models;
using GestorInventario.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Web;

namespace GestorInventario.CQRS.Handlers
{
    public class GetItemByIdHandler : IRequestHandler<GetItemByIdQuery, Item>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetItemByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public Task<Item> Handle(GetItemByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_unitOfWork.ItemRepository.Get(request.Id));
        }
    }
}