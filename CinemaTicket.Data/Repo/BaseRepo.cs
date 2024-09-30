using CinemaTicket.Business.IRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Data.Repo
{
    public class BaseRepo<TEntity> : IBaseRepo<TEntity>
        where TEntity : class
    {
        private readonly DataContext _context;
        public BaseRepo(DataContext context)
        {
            _context = context;
        }

        protected IQueryable<TEntity> Query => _context.Set<TEntity>();


        public List<TEntity> GetAll()
        {
            return Query.AsNoTracking().ToList();
        }

        public TEntity GetEntityById(int id)
        {
            return _context.Find<TEntity>(id);
        }

        public void Insert(TEntity entity)
        {
            _context.Add(entity);
            Save();
        }
        public void Remove(int id)
        {
            var entity = _context.Find<TEntity>(id);
            _context.Remove(entity);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
            Save();
        }
    }
}
