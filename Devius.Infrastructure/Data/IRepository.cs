using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devius.Infrastructure.Data
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> Set { get; }

        
        Task<TEntity> FindAsync(Guid id);

        Task CreateAsync(TEntity entity);

        Task CreateAsync(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Remove(TEntity entity);



        Task<IDbContextTransaction> BeginTransactionAsync();

        Task SaveChangesAsync();


    }
}
