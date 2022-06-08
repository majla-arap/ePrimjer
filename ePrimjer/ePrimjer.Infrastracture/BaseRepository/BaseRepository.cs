using ePrimjer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ePrimjer.Infrastracture.BaseRepository
{
    public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : class
    {
        protected DatabaseContext _dbcontext;
        protected DbSet<TEntity> _dbset;

        public BaseRepository(DatabaseContext dbc)
        {
            _dbcontext = dbc;
            _dbset= _dbcontext.Set<TEntity>();
        }
        public List<TEntity> Get()
        {
            return _dbset.ToList();
        }
    }
}
