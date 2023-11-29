using NLayer.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _contex;

        public UnitOfWork(AppDbContext contex)
        {
            _contex = contex;
        }

        public void Commit()
        {
            _contex.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _contex.SaveChangesAsync();   
        }
    }
}
