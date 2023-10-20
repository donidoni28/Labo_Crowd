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
    public class ParticipationRepository
        : BaseRepository<ParticipationModel, ParticipationUpdateModel, ParticipationGetModel, ParticipationGetAllModel, ParticipationAddModel, ParticipationEntity, int>
        , IParticipationRepo
    {
        public ParticipationRepository(string cnstr) : base(cnstr)
        {
        }

        public override ParticipationEntity AddModelToEntity(ParticipationAddModel model)
        {
            if (model == null) return null;
            return new ParticipationEntity()
            {
               IdUser = model.IdUser,
               IdCounterparty = model.IdCounterparty,
               DateOfParticipation = model.DateOfParticipation 
            };
        }

        public override ParticipationGetAllModel ToGetAllModel(ParticipationEntity entity)
        {
            if (entity == null) return null;
            return new ParticipationGetAllModel()
            {
                IdUser = entity.IdUser,
                IdCounterparty = entity.IdCounterparty,
                DateOfParticipation = entity.DateOfParticipation

            };
        }

        public override ParticipationGetModel ToGetModel(ParticipationEntity entity)
        {
            if (entity == null) return null;
            return new ParticipationGetModel()
            {
                IdUser = entity.IdUser,
                IdCounterparty = entity.IdCounterparty,
                DateOfParticipation = entity.DateOfParticipation
            };
        }

        public override ParticipationEntity UpdateModelToEntity(ParticipationUpdateModel model)
        {
            if (model == null) return null;
            return new ParticipationEntity()
            {
                IdUser = model.IdUser,
                IdCounterparty = model.IdCounterparty,
                DateOfParticipation = model.DateOfParticipation
            };
        }
    }
}
