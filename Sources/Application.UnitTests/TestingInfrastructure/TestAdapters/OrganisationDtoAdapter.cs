using Mmu.Mlh.Adapters.Areas.Services;
using Mmu.Mlh.Adapters.UnitTests.TestingInfrastructure.TestDtos;
using Mmu.Mlh.Adapters.UnitTests.TestingInfrastructure.TestModels;

namespace Mmu.Mlh.Adapters.UnitTests.TestingInfrastructure.TestAdapters
{
    public class OrganisationDtoAdapter : IAdapter<OrganisationDto, Organisation>, IOrganisationDtoAdapter
    {
        public OrganisationDto Adapt(Organisation model)
        {
            return new OrganisationDto
            {
                Name = model.Name
            };
        }

        public Organisation Adapt(OrganisationDto dto)
        {
            return new Organisation(dto.Name);
        }
    }
}