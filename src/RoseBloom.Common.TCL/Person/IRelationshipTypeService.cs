using System.Threading.Tasks;
using RoseBloom.Common.TCL.Entities;

namespace RoseBloom.Common.TCL.Person
{
    public interface IRelationshipTypeService : IEntityService<RelationshipType>
    {
        Task<RelationshipType> AddAsync(string name);
    }
}