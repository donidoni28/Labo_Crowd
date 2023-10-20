using DAL.Repository.Interfaces;
using DAL.Repository.Models;

namespace BLL.Services
{
    public class ProjectService 
    {
        private readonly IProjectRepo _repo;
        public ProjectService(IProjectRepo repo)
        {
            _repo = repo;
        }

        
        public ProjectAddModel Add(ProjectAddModel usr)
        {
            return _repo.Add(usr);
        }

        public IEnumerable<ProjectGetAllModel> GetAll()
        {
            return _repo.GetAll();
        }

        public ProjectGetModel Get(int id)
        {
            return _repo.Get(id);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public ProjectUpdateModel Update(ProjectUpdateModel usr)
        {
            return _repo.Update(usr);
        }

    }
}
