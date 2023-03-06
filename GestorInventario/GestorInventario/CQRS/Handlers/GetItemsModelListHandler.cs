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
    public class GetItemsModelListHandler : IRequestHandler<GetItemsModelQuery, List<ItemModel>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetItemsModelListHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<List<ItemModel>> Handle(GetItemsModelQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_unitOfWork.ItemModelRepository.GetAll().ToList());
        }
    }
}