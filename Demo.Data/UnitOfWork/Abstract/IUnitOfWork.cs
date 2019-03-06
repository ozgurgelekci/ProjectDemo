using System;
using Demo.Core.Entities.Abstract;
using Demo.Data.GenericRawSql.Abstract;
using Demo.Data.GenericRepository.Abstract;

namespace Demo.Data.UnitOfWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity;
        IGenericRawSql GetRawSql();

        /// <summary>
        /// Değişiklikleri kaydeder.
        /// </summary>
        /// <returns></returns>
        int SaveChanges();

        /// <summary>
        /// Transaction başlatır.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Kayıt esnasında problem olmazsa transactionı bitirir.
        /// </summary>
        void Commit();

        /// <summary>
        /// Kayıt esnasında problem olursa değişiklikleri geri alır.
        /// </summary>
        void RollBack();
    }
}
