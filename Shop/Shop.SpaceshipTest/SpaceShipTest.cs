using NuGet.Frameworks;
using Shop.Core.Domain;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.SpaceshipTest
{
    public class SpaceShipTest : TestBase
    {
        [Fact]
        public async Task ShouldNot_AddEmptySpaceship_WhenReturnresult()
        {


            SpaceshipDto dto= new SpaceshipDto(); 

            dto.Name = "Name";
            dto.Type = "Type";
            dto.Passangers = 123;
            dto.EnginPower = 123;
            dto.Crew = 123;
            dto.Company = "asd";
            dto.CargoWeight = 123;

            dto.CreatedAt= DateTime.Now;
            dto.Modifieted=DateTime.Now;

            var result = await Svc<ISpaceshipServices>().Create(dto);

            Assert.NotNull(result);

        }

        [Fact] 
        //chack a path for elements
        public async Task ShouldNot_GetByIdSpaceship_WhenReturnNotEqual()

        {
            //Arrange
            Guid guid = Guid.Parse("67457d6e-854d-4112-b467-776ef280574c");
            //kuidas teha automaatselt teeb guidi ???
            Guid wrongGuid =Guid.Parse(Guid.NewGuid().ToString());

            //Act
            await Svc<ISpaceshipServices>().GetAsync(guid);

            //Assert
            Assert.NotEqual(guid, wrongGuid);

            //Guid Wronggugid = Guid.NewGuid();
            //Random random = new Random();
            //int i = random.Next();
        }

        [Fact]
        public async Task Should_GetBySpaceship_WhenReturnsEqual()
        {
            // Arrange
            Guid databaseGuid = Guid.Parse("67457d6e-854d-4112-b467-776ef280574c");
            Guid getGuid = Guid.Parse("67457d6e-854d-4112-b467-776ef280574c");
            // Act
            await Svc<ISpaceshipServices>().GetAsync(getGuid);

            // Assert

            Assert.Equal(databaseGuid, getGuid);
        }

        [Fact]
        public async Task Should_DeleteByIdSpaceship_WhenDeleteSpaceship()
        {
            // Arrange
            SpaceshipDto spaceship = MockSpaceshipData();

            // Act

            var addSpaceship = await Svc<ISpaceshipServices>().Create(spaceship);
            var result = await Svc<ISpaceshipServices>().Delete((Guid)addSpaceship.Id);

            // Assert
            Assert.Equal(result, addSpaceship);
            
        }

        [Fact]
        public async Task ShouldNot_DeleteByIdSpaceship_WhenDidNotDeleteTheWrightSpaceship()
        {
            // Arrange
            SpaceshipDto spaceship = MockSpaceshipData();

            var addSpaceship = await Svc<ISpaceshipServices>().Create(spaceship);
            var addSpaceship2 = await Svc<ISpaceshipServices>().Create(spaceship);

            var result = await Svc<ISpaceshipServices>().Delete((Guid)addSpaceship2.Id);

                        Assert.NotEqual(result.Id, addSpaceship.Id);
        }

        [Fact]
        public async Task Should_UpdateSpaceship_WhenUpdateData()
        {
            var guid = new Guid("67457d6e-854d-4112-b467-776ef280574c");
            //Arrange
            //old data from db
            Spaceship spaceship = new Spaceship();

            //new data
            SpaceshipDto dto = MockSpaceshipData();

            spaceship.Id = Guid.Parse("67457d6e-854d-4112-b467-776ef280574c");
            spaceship.Name = "asd";
            spaceship.Type = "asdasd";
            spaceship.Passangers = 12344;
            spaceship.EnginPower = 12355;
            spaceship.Crew = 123;
            spaceship.Company = "asdasd";
            spaceship.CargoWeight = 1223445;
            spaceship.CreatedAt = DateTime.Now.AddYears(1);
            spaceship.Modifieted = DateTime.Now.AddYears(1);
            //Act

            await Svc<ISpaceshipServices>().Update(dto);

            //Assert

            Assert.Equal(spaceship.Id, guid);
            Assert.NotEqual(spaceship.EnginPower, dto.EnginPower);
            Assert.Equal(spaceship.Crew, dto.Crew);
            Assert.DoesNotMatch(spaceship.Passangers.ToString(), dto.Passangers.ToString());

            //??
        }

        [Fact]
        public async Task Should_UpdateSpaceship_WhenUpdateDataVersion2()
        {
            SpaceshipDto dto = MockSpaceshipData();
            var createSpaceship = await Svc<ISpaceshipServices>().Create(dto);


            SpaceshipDto update = MockUpdateSpaceshipData();
            var updateSpaceship = await Svc<ISpaceshipServices>().Update(update);

            Assert.DoesNotMatch(updateSpaceship.Name, createSpaceship.Name);
            Assert.NotEqual(updateSpaceship.EnginPower, createSpaceship.EnginPower);
            Assert.Equal(updateSpaceship.Crew, createSpaceship.Crew);
            Assert.DoesNotMatch(updateSpaceship.Passangers.ToString(), createSpaceship.Passangers.ToString());

        }

        private SpaceshipDto MockUpdateSpaceshipData()
        {
            SpaceshipDto update = new()
            {
                Name = "asdaa",
                Type = "asddd",
                Passangers = 123555,
                EnginPower = 12355,
                Crew = 12355,
                Company = "asdhh",
                CargoWeight = 12355,
                CreatedAt = DateTime.Now,
                Modifieted = DateTime.Now,
            };

            return update;
        }

        private SpaceshipDto MockSpaceshipData()
        {
            SpaceshipDto spaceship = new()
            {
                Name = "asd",
                Type ="asd",
                Passangers = 123,
                EnginPower= 123,
                Crew = 123,
                Company = "asd",
                CargoWeight = 123,
                CreatedAt = DateTime.Now,
                Modifieted = DateTime.Now,
            };

            return spaceship;

        }
    }
}
