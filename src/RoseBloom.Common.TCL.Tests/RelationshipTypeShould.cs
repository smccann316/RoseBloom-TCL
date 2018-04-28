using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using RoseBloom.Common.TCL.Entities;

namespace RoseBloom.Common.TCL.Tests
{
    public class RelationshipTypeShould
    {
        private  async void CraeteData()
        {
            var repo = new MemoryEntityRepository<RelationshipType>();
            var service = new RelationshipTypeService(repo);
            var rel1 = new RelationshipType
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Friend",
                Description = "A standard friend",
                Notes = "not a close friend but not as casual  as a coworker or acquaintance"
            };
            await service.AddAsync(rel1);
            rel1 = new RelationshipType
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Mother",
                Description = "Your Mother",
                Notes = "mother "
            };
            await service.AddAsync(rel1);

            rel1 = new RelationshipType
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Father",
                Description = "Your Father",
                Notes = "not a close friend but not as casual  as a coworker or acquaintance"
            };
            await service.AddAsync(rel1);

        }
    }
}
