using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace VirtualChat.Repository.Repository;

/// <summary>
/// Repositoy patern
/// </summary>
/// <typeparam name="T"></typeparam>
public class Repository<T> : IRepository<T> where T : class
{
    #region Properties
    /// <summary>
    /// Data context of VirtualChat
    /// </summary>
    private VirtalChatDbContext _context;
    /// <summary>
    /// Database Set of entities
    /// </summary>
    private DbSet<T> _dbSet;
    #endregion

    #region Constructor
    public Repository(VirtalChatDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }
    #endregion

    #region CRUD Methods
    /// <summary>
    /// Get T by id
    /// </summary>
    /// <param name="id">Id of T</param>
    /// <returns>T entity</returns>
    public T Get(string id) => _dbSet.Find(id);

    /// <summary>
    /// Get all T entities
    /// </summary>
    /// <returns>Enumerable of T</returns>
    public IEnumerable<T> GetAll()
    {
        return _dbSet.AsEnumerable();
    }

    /// <summary>
    /// Delete T by id
    /// </summary>
    /// <param name="id">id of T</param>
    /// <exception cref="ArgumentNullException">Entity with current id does not exist</exception>
    public void Delete(string id)
    {
        T item = Get(id);
        if (item == null)
        {
            throw new ArgumentNullException();
        }
        _dbSet.Remove(item);
    }

    /// <summary>
    /// Insert T into database
    /// </summary>
    /// <param name="entity">T entity</param>
    /// <exception cref="ArgumentNullException">T entity is null</exception>
    public void Create(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException();
        }
        _dbSet.Add(entity);
    }

    /// <summary>
    /// Update T entity in database
    /// </summary>
    /// <param name="entity">T entity</param>
    /// <exception cref="ArgumentNullException">T entity does not exist</exception>
    public void Update(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException();
        }
        _dbSet.Update(entity);
    }

    /// <summary>
    /// Find IEnumerable of T by lambda expression
    /// </summary>
    /// <param name="expression">Lambda exprretion, predicate</param>
    /// <returns>Enumerable of T</returns>
    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return _dbSet.Where(expression).AsEnumerable();
    }

    /// <summary>
    /// Save all changes
    /// </summary>
    public void SaveChanges()
    {
        _context.SaveChanges();
    }
    #endregion
}