using Devius.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devius.Core.Context
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntityBase
    {

        public Repository(DataContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }



        protected DbContext Context { get; }

        protected DbSet<TEntity> DbSet { get; }



        public IQueryable<TEntity> Set => DbSet;



        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await Context.Database.BeginTransactionAsync();
        }

        public async Task CreateAsync(TEntity entity)
        {
            await Context.AddAsync(entity);
        }

        public async Task CreateAsync(IEnumerable<TEntity> entities)
        {
            await Context.AddRangeAsync(entities);
        }

        public async Task<TEntity> FindAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
             Context.Update(entity);
        }
    }
}
