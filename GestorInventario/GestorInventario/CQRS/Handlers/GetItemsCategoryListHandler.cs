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
    public class GetItemsCategoryListHandler : IRequestHandler<GetItemsCategoryQuery, List<ItemCategory>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetItemsCategoryListHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<List<ItemCategory>> Handle(GetItemsCategoryQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_unitOfWork.ItemCategoryRepository.GetAll().ToList());
        }
    }
}