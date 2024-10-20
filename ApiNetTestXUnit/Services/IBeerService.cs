using ApiNetTestXUnit.Models;

namespace ApiNetTestXUnit.Services
{
    public interface IBeerService
    {
        public IEnumerable<Beer> Get();
        public Beer? Get(int id);
    }
}
