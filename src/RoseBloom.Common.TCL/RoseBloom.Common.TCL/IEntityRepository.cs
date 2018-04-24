using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RoseBloom.Common.TCL
{
    public interface IEntityRepository
    {
        Entity EntityType { get; }
        Task<Entity> GetByIdAsync(string id);
        Task<IEnumerable<Entity>> GetAsync(); // we could use criteria
        Task<Entity> AddAsync(Entity toAdd);
        Task<Entity> UpdateAsync(Entity toUpdate);
        Task<bool> DeleteAsync(string id);

    }

    public interface IEntityRepository<T> : IEntityRepository
    {
        Task<T> AddAsync(T toadd);
        new Task<IEnumerable<T>> GetAsync();
        new Task<T> GetByIdAsync(string id);
        Task<T> UpdateAsync(T toUpdate);
    }
}
