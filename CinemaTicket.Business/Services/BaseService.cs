using CinemaTicket.Business.IRepo;
using CinemaTicket.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Services
{
    public class BaseService<TEntity, TRepo> : IBaseService<TEntity>
        where TEntity : class
        where TRepo : IBaseRepo<TEntity>
    {
        protected readonly TRepo _repo;

        public BaseService(TRepo repo)
        {
            _repo = repo;
        }

        public void Insert(TEntity entity)
        {
            _repo.Insert(entity);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }

        public void Update(TEntity entity)
        {
            _repo.Update(entity);
        }

        public List<TEntity> GetAll()
        {
            return _repo.GetAll();
        }

        public TEntity GetEntityById(int id)
        {
            return _repo.GetEntityById(id);
        }

    }
}
