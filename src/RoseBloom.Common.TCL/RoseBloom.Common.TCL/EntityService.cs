using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseBloom.Common.TCL
{
    public class EntityService<T> : IEntityService where T : Entity
    {
        Type IEntityService.EntityType => typeof(T);

        Task<Entity> IEntityService.AddAsync(Entity toAdd)
        {
            throw new NotImplementedException();
        }

        Task<bool> IEntityService.DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<List<Entity>> IEntityService.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<Entity> IEntityService.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<Entity> IEntityService.UpdateAsync(Entity toUpdate)
        {
            throw new NotImplementedException();
        }
    }

}
