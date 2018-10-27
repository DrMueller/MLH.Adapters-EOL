using Mmu.Mlh.Adapters.Areas.Services;
using Mmu.Mlh.Adapters.UnitTests.TestingInfrastructure.TestDtos;
using Mmu.Mlh.Adapters.UnitTests.TestingInfrastructure.TestModels;

namespace Mmu.Mlh.Adapters.UnitTests.TestingInfrastructure.TestAdapters
{
    public class IndividualDtoAdapter : IAdapter<IndividualDto, Individual>
    {
        public IndividualDto Adapt(Individual model)
        {
            return new IndividualDto
            {
                FirstName = model.FirstName
            };
        }

        public Individual Adapt(IndividualDto dto)
        {
            return new Individual(dto.FirstName);
        }
    }
}