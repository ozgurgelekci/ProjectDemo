using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Demo.Core.Entities.Abstract;

namespace Demo.Data.GenericRepository.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        /// <summary>
        /// Entitye göre tüm listeyi getirir.
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Where clause a göre tüm listeyi getirir.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Id ye göre entity getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(object id);

        /// <summary>
        /// Where clause a göre entity getirir.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        TEntity Get(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Verilen entityi ekler.
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);

        /// <summary>
        /// Liste olarak verilen entityleri ekler.
        /// </summary>
        /// <param name="entityList"></param>
        void AddRange(List<TEntity> entityList);

        /// <summary>
        /// Verilen entityi günceller.
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// Verilen entityi siler.
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);
    }
}
