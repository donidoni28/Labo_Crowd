using DAL.Entity;
using DAL.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface ICounterpartyRepo : IRepo<CounterpartyModel, CounterpartyUpdateModel, CounterpartyGetModel, CounterpartyGetAllModel,CounterpartyAddModel,CounterpartyEntity,int>
    {
        CounterpartyEntity AddModelToEntity(CounterpartyAddModel model);
        CounterpartyEntity UpdateModelToEntity(CounterpartyUpdateModel model);

        CounterpartyGetAllModel ToGetAllModel(CounterpartyEntity entity);
        CounterpartyGetModel ToGetModel(CounterpartyEntity entity);
    }
}
