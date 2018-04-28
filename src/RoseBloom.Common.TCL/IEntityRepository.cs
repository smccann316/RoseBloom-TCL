using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RoseBloom.Common.TCL
{
    public interface IEntityRepository<T> 
    {
        Task<T> AddAsync(T toadd);
        Task<IEnumerable<T>> GetAsync();
        Task<T> GetByIdAsync(string id);
        Task<T> UpdateAsync(T toUpdate);
        Task<bool> DeleteAsync(string id);
    }
}
