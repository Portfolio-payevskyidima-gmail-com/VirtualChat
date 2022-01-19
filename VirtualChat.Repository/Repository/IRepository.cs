using System.Linq.Expressions;

namespace VirtualChat.Repository.Repository;

/// <summary>
/// Repositoy patern
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T> where T : class
{
    /// <summary>
    /// Get T by id
    /// </summary>
    /// <param name="id">Id of T</param>
    /// <returns>T entity</returns>
    T Get(string id);
    /// <summary>
    /// Get all T entities
    /// </summary>
    /// <returns>Enumerable of T</returns>
    IEnumerable<T> GetAll();
    /// <summary>
    /// Delete T by id
    /// </summary>
    /// <param name="id">id of T</param>
    /// <exception cref="ArgumentNullException">Entity with current id does not exist</exception>
    void Delete(string id);
    /// <summary>
    /// Update T entity in database
    /// </summary>
    /// <param name="entity">T entity</param>
    /// <exception cref="ArgumentNullException">T entity does not exist</exception>
    void Update(T entity);
    /// <summary>
    /// Insert T into database
    /// </summary>
    /// <param name="entity">T entity</param>
    /// <exception cref="ArgumentNullException">T entity is null</exception>
    void Create(T entity);
    /// <summary>
    /// Find IEnumerable of T by lambda expression
    /// </summary>
    /// <param name="expression">Lambda exprretion, predicate</param>
    /// <returns>Enumerable of T</returns>
    IEnumerable<T> Find(Expression<Func<T, Boolean>> expression);
    /// <summary>
    /// Save all changes
    /// </summary>
    void SaveChanges();
}