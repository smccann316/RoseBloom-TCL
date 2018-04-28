using System.Threading.Tasks;
using RoseBloom.Common.TCL.Entities;

// ReSharper disable once CheckNamespace
namespace RoseBloom.Common.TCL.Entities
{
    public interface IRelationshipTypeService : IEntityService<RelationshipType>
    {
        Task<RelationshipType> AddAsync(string name);
        Task<RelationshipType> UpdateAsync( string id,string name, string description, string notes);
    }
}