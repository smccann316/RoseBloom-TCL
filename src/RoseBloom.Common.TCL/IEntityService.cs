using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseBloom.Common.TCL
{
    public interface IEntityService
    {
        Type EntityType { get; }
        Task<IEnumerable<Entity>> GetAsync();
        Task<Entity> GetByIdAsync(string id);
        Task<Entity> AddAsync(Entity toAdd);
        Task<Entity> UpdateAsync(Entity toUpdate);
        Task<bool> DeleteAsync(string id);
    }

    public interface IEntityService<T> : IEntityService where T : Entity
    {
        new Task<IEnumerable<T>> GetAsync();
        new Task<T> GetByIdAsync(string id);
        Task<T> AddAsync(T toAdd);
        Task<T> UpdateAsync(T toUpdate);
    }
}