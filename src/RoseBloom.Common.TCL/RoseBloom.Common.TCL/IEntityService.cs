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
        Task<List<Entity>> GetAsync();
        Task<Entity> GetByIdAsync(string id);
        Task<Entity> AddAsync(Entity toAdd);
        Task<Entity> UpdateAsync(Entity toUpdate);
        Task<bool> DeleteAsync(string id);
    }
}
