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
        private readonly IEntityRepository<T> _repository;
        
        public EntityService(IEntityRepository<T> repo)
        {
            _repository = repo;
        }

        protected async Task<T> AddAsync(T toAdd)
        {
           return  await _repository.AddAsync(toAdd);

        }
        async Task<Entity> IEntityService.AddAsync(Entity toAdd)
        {
            return  await AddAsync((T) toAdd);
        }

       
        async Task<bool> IEntityService.DeleteAsync(string id)
        {
            return await _repository.DeleteAsync(id);
        }

        protected async Task<IEnumerable<T>> GetAsync()
        {
            return await _repository.GetAsync();
        }
        async Task<IEnumerable<Entity>> IEntityService.GetAsync()
        {
            return await GetAsync();
        }

        protected async Task<T> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }
        async Task<Entity> IEntityService.GetByIdAsync(string id)
        {
            return await GetByIdAsync(id);
        }

        protected async Task<T> UpdateAsync(T toUpdate)
        {
            return await _repository.UpdateAsync(toUpdate);
        }
         async Task<Entity> IEntityService.UpdateAsync(Entity toUpdate)
        {
            return await UpdateAsync((T)toUpdate);
        }
    }

}
