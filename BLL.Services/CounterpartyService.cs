using DAL.Repository.Interfaces;
using DAL.Repository.Models;

namespace BLL.Services
{
    public class CounterpartyService
    {
        private readonly ICounterpartyRepo _repo;
        public CounterpartyService(ICounterpartyRepo repo)
        {
            _repo = repo;
        }

        
        public CounterpartyAddModel Add(CounterpartyAddModel usr)
        {
            return _repo.Add(usr);
        }


        public IEnumerable<CounterpartyGetAllModel> GetAll()
        {
            return _repo.GetAll();
        }

        public CounterpartyGetModel Get(int id)
        {
            return _repo.Get(id);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public CounterpartyUpdateModel Edit(CounterpartyUpdateModel usr)
        {
            return _repo.Update(usr);
        }
    }
}
