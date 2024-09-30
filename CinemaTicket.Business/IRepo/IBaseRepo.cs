using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.IRepo
{
    public interface IBaseRepo<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Remove(int id);
        void Update(TEntity entity);
        List<TEntity> GetAll();
        TEntity GetEntityById(int id);
        void Save();
    }
}
