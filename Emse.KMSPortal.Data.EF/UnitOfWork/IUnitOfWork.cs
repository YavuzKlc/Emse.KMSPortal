using Emse.Framework;
using System;

namespace Emse.KMSPortal.Data.EF.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        int SaveChanges();
    }
}
