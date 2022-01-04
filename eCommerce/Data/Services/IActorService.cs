using eCommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCommerce.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAll();

        Actor GetById(int id);

        void Add(Actor actor);

        void Update(int id, Actor NewActor);

        void Delete(int id);
    }
}
