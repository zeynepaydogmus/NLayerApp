using NLayer.Core.UnitOfWork;

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
