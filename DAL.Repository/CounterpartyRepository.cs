using DAL.Entity;

using DAL.Repository.Interfaces;
using DAL.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CounterpartyRepository
        : BaseRepository<CounterpartyModel, CounterpartyUpdateModel, CounterpartyGetModel, CounterpartyGetAllModel, CounterpartyAddModel, CounterpartyEntity, int>
        , ICounterpartyRepo
    {
        public CounterpartyRepository(string cnstr) : base(cnstr)
        {
        }

        public override CounterpartyEntity AddModelToEntity(CounterpartyAddModel model)
        {
            if (model == null) return null;
            return new CounterpartyEntity()
            {
                Description = model.Description,
                Amount = model.Amount
            };
        }

        public override CounterpartyGetAllModel ToGetAllModel(CounterpartyEntity entity)
        {
            if (entity == null) return null;
            return new CounterpartyGetAllModel()
            {
                IdCounterparty = entity.IdCounterparty,
                Description = entity.Description,
                Amount = entity.Amount
            };
        }

        public override CounterpartyGetModel ToGetModel(CounterpartyEntity entity)
        {
            if (entity == null) return null;
            return new CounterpartyGetModel()
            {
                IdCounterparty = entity.IdCounterparty,
                Description = entity.Description,
                Amount = entity.Amount
            };
        }

        public override CounterpartyEntity UpdateModelToEntity(CounterpartyUpdateModel model)
        {
            if (model == null) return null;
            return new CounterpartyEntity()
            {
                IdCounterparty = model.IdCounterparty,
                Description = model.Description,
                Amount = model.Amount
            };
        }
    }
}

//using Crowd.Entity;
//using Crowd.Repositorie.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Crowd.Repositorie.Models
//{
//    public class CounterpartyRepository
//        : BaseRepository<CounterpartyModel, CounterpartyUpdateModel, CounterpartyGetModel, CounterpartyGetAllModel, CounterpartyAddModel, CounterpartyEntity, int>
//    , ICounterpartyRepo
//    {
//        public CounterpartyRepository(string cnstr) : base(cnstr)
//        {

//        }
//        public override CounterpartyEntity AddModelToEntity(CounterpartyAddModel model)
//        {
//            if (model == null) return null;
//            return new CounterpartyEntity()
//            {
//                IdCounterparty = model.IdCounterparty,
//                Amount = model.Amount,
//                Description = model.Description

//            };
//        }

//        public override CounterpartyGetAllModel ToGetAllModel(CounterpartyEntity entity)
//        {
//            if (entity == null) return null;
//            return new CounterpartyGetAllModel()
//            {
//                IdCounterparty = entity.IdCounterparty,
//                Amount = entity.Amount,
//                Description = entity.Description
//            };
//        }

//        public override CounterpartyGetModel ToGetModel(CounterpartyEntity entity)
//        {
//            if (entity == null) return null;
//            return new CounterpartyGetModel()
//            {
//                IdCounterparty = entity.IdCounterparty,
//                Amount = entity.Amount,
//                Description = entity.Description
//            };
//        }

//        public override CounterpartyEntity UpdateModelToEntity(CounterpartyUpdateModel model)
//        {
//            if (model == null) return null;
//            return new CounterpartyEntity()
//            {
//                IdCounterparty = model.IdCounterparty,
//                Amount = model.Amount,
//                Description = model.Description
//            };
//        }
//    }
//}
