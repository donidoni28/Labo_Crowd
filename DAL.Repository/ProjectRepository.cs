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
    public class ProjectRepository : BaseRepository
            <ProjectModel, ProjectUpdateModel, ProjectGetModel, ProjectGetAllModel, ProjectAddModel, ProjectEntity, int>
        , IProjectRepo
    {
        public ProjectRepository(string cnstr) : base(cnstr)
        {

        }

        public override ProjectEntity AddModelToEntity(ProjectAddModel model)
        {
            if (model == null) return null;
            return new ProjectEntity()
            {
                Name = model.Name,
                Amount = model.Amount,
            };
        }
        public override ProjectEntity UpdateModelToEntity(ProjectUpdateModel model)
        {
            if (model == null) return null;
            return new ProjectEntity()
            {
                IdProject = model.IdProject,
                Name = model.Name,
                Amount = model.Amount
            };
        }
        public override ProjectGetAllModel ToGetAllModel(ProjectEntity entity)
        {
            if (entity == null) return null;
            return new ProjectGetAllModel()
            {
                IdProject = entity.IdProject,
                Name = entity.Name,
                Amount = entity.Amount
            };
        }
        public override ProjectGetModel ToGetModel(ProjectEntity entity)
        {
            if (entity == null) return null;
            return new ProjectGetModel()
            {
                IdProject = entity.IdProject,
                Name = entity.Name,
                Amount = entity.Amount,
                CreatedAt = entity.CreatedAt,
                EndDate = entity.EndDate,
                PublishDate = entity.PublishDate
            };
        }
    }
    }
