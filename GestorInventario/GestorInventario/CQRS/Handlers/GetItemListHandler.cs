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
    public class GetItemListHandler : IRequestHandler<GetItemListQuery, List<Item>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetItemListHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<List<Item>> Handle(GetItemListQuery request, CancellationToken cancellationToken)
        {
            var items = _unitOfWork.ItemRepository.GetAll().ToList();
            return Task.FromResult(items);
        }

    }
}