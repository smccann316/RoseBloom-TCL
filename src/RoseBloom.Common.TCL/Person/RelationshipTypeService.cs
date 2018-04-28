using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoseBloom.Common.TCL.Entities;

// ReSharper disable once CheckNamespace
namespace RoseBloom.Common.TCL.Entities
{
    public class RelationshipTypeService : EntityService<RelationshipType>, IRelationshipTypeService
    {
        public RelationshipTypeService(IEntityRepository<RelationshipType> repo) : base(repo)
        {
        }


        public async Task<RelationshipType> AddAsync(string name)
        {
            var rt = new RelationshipType
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Mom",
                Description = "My Mom",
                Notes = "This is a test"
            };
            
            return await base.AddAsync(rt);
        }

        public async Task<RelationshipType> UpdateAsync( string id,string name = "", string description ="", string notes = "")
        {
            // get relation type by id 
            var rt = await  base.GetByIdAsync(id);
            if (name != "")
                rt.Name = name;
            if (description != "")
                rt.Description = description;
            if (notes != "")
                rt.Notes = notes;
            var updatedRt = await base.UpdateAsync(rt);
            return rt;

        }

      
    }
}
