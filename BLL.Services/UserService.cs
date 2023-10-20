using DAL.Repository.Interfaces;
using DAL.Repository.Models;

namespace BLL.Services
{
    
    public class UserService 
    {
        private readonly IUserRepo _repo;
        public UserService(IUserRepo repo)
        {
            _repo = repo;
        }

        public UserAddModel Add(UserAddModel usr)
        {
            return _repo.Add(usr);
        }

        public IEnumerable<UserGetAllModel> GetAll()
        {
            return _repo.GetAll();
        }

        public UserGetModel Get(int id)
        {
            return _repo.Get(id);
        }
       
        
        public void Delete(int id)
        {
            _repo.Delete(id);
        }
        public UserUpdateModel Update(UserUpdateModel usr)
        {
            return _repo.Update(usr);
        }
        
        
    }
}
