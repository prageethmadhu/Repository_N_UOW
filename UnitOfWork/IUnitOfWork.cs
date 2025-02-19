using System;
using new_api_layout.Model;
using new_api_layout.Repositories;

namespace new_api_layout.UnitOfWork;

public interface IUnitOfWork
{
        IRepository<Product> Products { get; }
        Task<int> SaveChangesAsync();
}
