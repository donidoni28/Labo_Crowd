using DAL.Entity;
using DAL.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IProjectRepo 
        : IRepo<ProjectModel, ProjectUpdateModel, ProjectGetModel, ProjectGetAllModel, ProjectAddModel, ProjectEntity, int>
    {
        ProjectEntity AddModelToEntity(ProjectAddModel model);
        ProjectEntity UpdateModelToEntity(ProjectUpdateModel model);

        ProjectGetAllModel ToGetAllModel(ProjectEntity entity);
        ProjectGetModel ToGetModel(ProjectEntity entity);
    }
}
