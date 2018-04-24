using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoseBloom.Common.TCL.Entities;

namespace RoseBloom.Common.TCL.Person
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
            //create item
            return await base.AddAsync(rt);
        }
    }
}
