using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace GabrovoUltraWebApp.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext context;

        public Repository(GabrovoUltraContext _context)
        {
            this.context = _context;
        }

        private DbSet<T> DbSet<T>() where T : class
        => this.context.Set<T>();
        public async Task AddAsync<T>(T entity) where T : class
        => await DbSet<T>().AddAsync(entity);

        public async Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class
        =>    await DbSet<T>().AddRangeAsync(entities);

        public IQueryable<T> All<T>() where T : class
        => DbSet<T>();

        public IQueryable<T> All<T>(Expression<Func<T, bool>> search) where T : class
        => DbSet<T>().Where(search);
        
        public IQueryable<T> AllReadonly<T>() where T : class
        => DbSet<T>().AsNoTracking();

        public IQueryable<T> AllReadonly<T>(Expression<Func<T, bool>> search) where T : class
        => DbSet<T>().Where(search).AsNoTracking();
       

        public void Delete<T>(T entity) where T : class
        {
            EntityEntry dbEntityEntry = this.context.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet<T>().Attach(entity);
            }
            
            dbEntityEntry.State = EntityState.Deleted;
        }

        /// <summary>
        /// Deletes an entity by its primary key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public async Task<T?> DeleteAsync<T>(object id) where T : class
        {
            T? entity = await GetByIdAsync<T>(id);
            if (entity == null)
            {
                return null;
            }
            Delete<T>(entity);
            return entity;
        }

        public void DeleteRange<T>(IEnumerable<T> entities) where T : class
        => DbSet<T>().RemoveRange(entities);

        public void DeleteRange<T>(Expression<Func<T, bool>> deleteWhereClause) where T : class
        => DbSet<T>().RemoveRange(DbSet<T>().Where(deleteWhereClause));

        public void Detach<T>(T entity) where T : class
        {
           EntityEntry dbEntityEntry = this.context.Entry(entity);
            dbEntityEntry.State = EntityState.Detached;
        }

        public void Dispose()
        => this.context.Dispose();

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        => await DbSet<T>().FindAsync(id);
       

        public async Task<T?> GetByIdsAsync<T>(object[] id) where T : class
        => await DbSet<T>().FindAsync(id);

        public async Task<int> SaveChangesAsync()
        => await this.context.SaveChangesAsync();

        public void Update<T>(T entity) where T : class
        => DbSet<T>().Update(entity);

        public void UpdateRange<T>(IEnumerable<T> entities) where T : class
        => DbSet<T>().UpdateRange(entities);
        //TODO : Implement EntityExists method
        //public async Task<bool> EntityExists<T>(T entity) where T : class
        //{
        //    var entityType = typeof(T);
        //    var properties = entityType.GetProperties().ToList();
        //    return await DbSet<T>().AnyAsync(e =>
        //    {
        //        foreach (var property in properties)
        //        {
        //            if (property.GetValue(e) != property.GetValue(entity))
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    });
        
    }
}
