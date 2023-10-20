using DAL.Entity;
using DAL.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IParticipationRepo
        : IRepo<ParticipationModel, ParticipationUpdateModel, ParticipationGetModel, ParticipationGetAllModel, ParticipationAddModel, ParticipationEntity, int>
    {
        ParticipationEntity AddModelToEntity(ParticipationAddModel model);
        ParticipationEntity UpdateModelToEntity(ParticipationUpdateModel model);


        ParticipationGetAllModel ToGetAllModel(ParticipationEntity entity);
        ParticipationGetModel ToGetModel(ParticipationEntity entity);

    }
}
