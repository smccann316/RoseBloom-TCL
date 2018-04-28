using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseBloom.Common.TCL
{
    public class MemoryEntityRepository<T> : IEntityRepository<T> where T : Entity
    {
        public List<T> MemoryList { get; }
        public Type EntityType => typeof(T);

        public MemoryEntityRepository()
        {
            MemoryList = new List<T>();
            // create a list in memory with the T 
        }
        
        public  Task<T> AddAsync(T toadd)
        {
           MemoryList.Add(toadd);
            return Task.FromResult(toadd);
        }

        public Task<IEnumerable<T>> GetAsync()
        {
            return Task.FromResult((IEnumerable<T>)MemoryList);
        }

        public Task<T> GetByIdAsync(string id)
        {
            var entity = MemoryList.Single(e => e.Id == id);
            return Task.FromResult(entity);
        }

        public Task<T> UpdateAsync(T toUpdate)
        {
            var entity = MemoryList.Single(e => e.Id == toUpdate.Id);
            var index = MemoryList.IndexOf(entity);
            if (index != -1)
                MemoryList[index] = toUpdate;
            return Task.FromResult(toUpdate);
        }

        public Task<bool> DeleteAsync(string id)
        {
            var entity = MemoryList.Single(e => e.Id == id);
            MemoryList.Remove(entity);
            return Task.FromResult(true);
        }
    }
}
