using DAL.Repository.Interfaces;
using DAL.Repository.Models;

namespace BLL.Services
{
    public class ParticipationService
    {
        private readonly IParticipationRepo _repo;
        public ParticipationService(IParticipationRepo repo)
        {
            _repo = repo;
        }

        public ParticipationAddModel Add(ParticipationAddModel usr)
        {
            return _repo.Add(usr);
        }

        public IEnumerable<ParticipationGetAllModel> GetAll()
        {
            return _repo.GetAll();
        }

        public ParticipationGetModel Get(int id)
        {
            return _repo.Get(id);
        }


        public void DeleteUser(int id)
        {
            _repo.Delete(id);
        }

        public ParticipationUpdateModel Edit(ParticipationUpdateModel usr)
        {
            return _repo.Update(usr);
        }
    }
}
