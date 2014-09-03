using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Domain;

namespace Zouave.Data
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly ZouaveObjContext _context;

        public UnitOfWork(IDbContext context)
        {
            _context = context as ZouaveObjContext;
        }

        public ZouaveObjContext Context
        {
            get { return _context; }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                _context.Dispose();
            }
        }
    }
}
