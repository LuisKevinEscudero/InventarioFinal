using GestorInventario.Models;
using GestorInventario.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GestorInventario.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ItemRepository ItemRepository { get; }
        ItemModelRepository ItemModelRepository { get; }
        ItemCategoryRepository ItemCategoryRepository { get; }
        void Save();
        Task SaveAsync();
        void Reset();
        void Reset(ApplicationDbContext _context);
    }
}