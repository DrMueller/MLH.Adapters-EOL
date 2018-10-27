using Mmu.Mlh.Adapters.Areas.Services;
using Mmu.Mlh.Adapters.Areas.Services.Implementation;
using Mmu.Mlh.Adapters.UnitTests.TestingInfrastructure.TestAdapters;
using Mmu.Mlh.Adapters.UnitTests.TestingInfrastructure.TestDtos;
using Mmu.Mlh.Adapters.UnitTests.TestingInfrastructure.TestModels;
using Mmu.Mlh.ServiceProvisioning.Areas.Provisioning.Services;
using Moq;
using NUnit.Framework;

namespace Mmu.Mlh.Adapters.UnitTests.TestingAreas.Areas.Services
{
    [TestFixture]
    public class AdapterResolverUnitTests
    {
        private Mock<IServiceLocator> _serviceLocatorMock;
        private AdapterResolver _sut;

        [SetUp]
        public void Align()
        {
            _serviceLocatorMock = new Mock<IServiceLocator>();
            _sut = new AdapterResolver(_serviceLocatorMock.Object);
        }

        [Test]
        public void FetchingAdapterByAdapteeTypes_RequestsAdapterByAdapteeType()
        {
            // Arrange
            var individualDtoAdapter = new IndividualDtoAdapter();
            _serviceLocatorMock.Setup(f => f.GetService<IAdapter<IndividualDto, Individual>>()).Returns(individualDtoAdapter);

            // Act
            var actualAdapter = _sut.ResolveByAdapteeTypes<IndividualDto, Individual>();

            // Assert
            Assert.AreEqual(individualDtoAdapter, actualAdapter);
        }

        [Test]
        public void FetchingAdapterByAdapterType_RequestsAdapterByAdapterType()
        {
            // Arrange
            var organisationDtoAdapter = new OrganisationDtoAdapter();
            _serviceLocatorMock.Setup(f => f.GetService<IOrganisationDtoAdapter>()).Returns(organisationDtoAdapter);

            // Act
            var actualAdapter = _sut.ResolveByAdapterType<IOrganisationDtoAdapter>();

            // Assert
            Assert.AreEqual(organisationDtoAdapter, actualAdapter);
        }
    }
}