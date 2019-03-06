using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using Demo.Core.Entities.Abstract;
using Demo.Data.Context;
using Demo.Data.GenericRawSql.Abstract;
using Demo.Data.GenericRepository.Abstract;
using Demo.Data.GenericRepository.Concrete;
using Demo.Data.UnitOfWork.Abstract;

namespace Demo.Data.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DemoContext _demoContext;
        private readonly CommonContext _commonContext;
        private DbContextTransaction _dbContextTransaction = null;
        private bool disposed = false;

        public UnitOfWork(DemoContext demoContext, CommonContext commonContext)
        {
            Database.SetInitializer<DemoContext>(null);

            if (_demoContext == null)
            {
                throw new ArgumentException("Context is null");
            }

            _demoContext = demoContext;
            _commonContext = commonContext;
        }

        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity
        {
            return new GenericRepository<TEntity>(_demoContext);
        }

        public IGenericRawSql GetRawSql()
        {
            return new GenericRawSql.Concrete.GenericRawSql(_commonContext);
        }

        public int SaveChanges()
        {
            int affectedRow = 0;
            try
            {
                _demoContext.SaveChanges();
            }
            catch (DbEntityValidationException dbEntityValidationException)
            {
                var message = string.Empty;
                foreach (var validationErrors in dbEntityValidationException.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        message += $"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}" + Environment.NewLine;
                    }
                }

                throw new Exception(message, dbEntityValidationException);
            }

            return affectedRow;
        }

        public void BeginTransaction()
        {
            _dbContextTransaction = _demoContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _dbContextTransaction.Commit();
        }

        public void RollBack()
        {
            _dbContextTransaction.Rollback();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _demoContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
