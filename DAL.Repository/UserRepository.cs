using DAL.Entity;
using DAL.Repository.Interfaces;
using DAL.Repository.Models;

namespace DAL.Repository
{
    public class UserRepository 
        : BaseRepository
            <UserModel, UserUpdateModel, UserGetModel, UserGetAllModel, UserAddModel, UserEntity, int>
        , IUserRepo
    {
        public UserRepository(string cnstr) : base(cnstr)
        {
            
        }

        public override UserEntity AddModelToEntity(UserAddModel model)
        {
            if (model == null) return null;
            return new UserEntity()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password
            };
        }
        public override UserEntity UpdateModelToEntity(UserUpdateModel model)
        {
            if (model == null) return null;
            return new UserEntity()
            {
                IdUser = model.IdUser,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password
            };
        }
        public override UserGetAllModel ToGetAllModel(UserEntity entity)
        {
            if (entity == null) return null;
            return new UserGetAllModel()
            {
                IdUser = entity.IdUser,
                FirstName = entity.FirstName,
                Email = entity.Email
            };
        }
        public override UserGetModel ToGetModel(UserEntity entity)
        {
            if (entity == null) return null;
            return new UserGetModel()
            {
                IdUser = entity.IdUser,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                Password = entity.Password
            };
        }
   
    }
}