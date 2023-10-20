using DAL.DataAccess;
namespace DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class BaseRepository<M, UM, GM, GAM, AM, T, U> : IRepo<M, UM, GM, GAM, AM, T, U>
    where M : class
    where UM : class
    where GM : class
    where GAM : class
    where AM : class
    where T : class
    
{
    private readonly ApiDbContext _dbContext;
    public BaseRepository(string cnstr)
    {
        _dbContext = new ApiDbContext(cnstr);
    }
    public AM Add(AM item)
    {
        _dbContext.Set<T>().Add(AddModelToEntity(item));
        _dbContext.SaveChanges();
        return item;
    }

    public void Delete(U id)
    {
        T item = _dbContext.Set<T>().Find(id);
        _dbContext.Set<T>().Remove(item);
        _dbContext.SaveChanges();
    }

    public GM Get(U id)
    {
        return ToGetModel(_dbContext.Set<T>().Find(id));
    }

    public IEnumerable<GAM> GetAll()
    {
        return _dbContext.Set<T>().ToList().Select(s => ToGetAllModel(s)).AsEnumerable<GAM>();
    }

    public UM Update(UM item)
    {
        _dbContext.Set<T>().Update(UpdateModelToEntity(item));
        _dbContext.SaveChanges();
        return item;
    }

    //public abstract AM GetAddModel(M model);

    public abstract T AddModelToEntity(AM model);
    public abstract T UpdateModelToEntity(UM model);
    public abstract GAM ToGetAllModel(T entity);
    public abstract GM ToGetModel(T entity);


    //public abstract M ToModel(T entite);
    //public abstract GM ToGetModel(T entite);
    //public abstract GAM ToGetAllModel(T entite);


    //// All returned Void method like _dbContext.update() need to be converted to entity
    //public abstract T ToEntite(M model);
    //public abstract T ToEntite(UM updateModel);
    //public abstract T ToEntite(AM updateModel);



}
