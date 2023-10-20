using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    // M = base model -- UM= Update model -- GM = Get model -- AM = Add model 
    public interface IRepo<M, UM, GM, GAM, AM, T, U>
        where M : class
        where UM : class
        where GM : class
        where GAM : class
        where AM : class
        where T : class
        
    {
        IEnumerable<GAM> GetAll();
        GM Get(U id);

        AM Add(AM item);
        UM Update(UM item);
        void Delete(U id);
    }
}
