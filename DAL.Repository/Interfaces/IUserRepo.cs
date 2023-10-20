using DAL.Entity;
using DAL.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IUserRepo : IRepo<UserModel, UserUpdateModel, UserGetModel, UserGetAllModel, UserAddModel, UserEntity, int>
    {
        // need to controll endpoints dependecies via models
        UserEntity AddModelToEntity(UserAddModel model);
        UserEntity UpdateModelToEntity(UserUpdateModel model);

        // need to controll Output of query via models
        UserGetAllModel ToGetAllModel(UserEntity entity);
        UserGetModel ToGetModel(UserEntity entity);

        
    }
}
