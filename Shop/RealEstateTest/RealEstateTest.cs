using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;


namespace Shop.SpaceshipTest
{
    public class RealEstateTest : ShopTARge22.RealEstateTest.TestBase
    {
        [Fact]
        public async Task ShouldNot_AddEmptyRealEstate_WhenReturnResult()
        {   //Arrange ehk andmete ettevalmistus
            RealEstateDto dto = new RealEstateDto();
            //RealEstateDto realEstate = new(); sama mis eelmine, lihtsalt lühem
            dto.Address = "asd";
            dto.SizeSqrM = 1000;
            dto.RoomCount = 10;
            dto.Floor = 3;
            dto.BuildingType = "asd";
            dto.BuiltinYear = DateTime.Now;
            dto.CreatedAt = DateTime.Now;
            dto.UpdatedAt = DateTime.Now;

            //Act ehk sisuline tegevus mida teeb
            var result = await Svc<IRealEstateServices>().Create(dto);

            //Assert ehk sisestus
            Assert.NotNull(result); //iga kord kui tehakse unit test, kirjutatakse assert...
        }

        [Fact]
        public async Task ShouldNot_GetByIdRealEstate_WhenReturnsNotEqual()
        {
            //Arrage
            Guid guid = Guid.Parse("6c87369d-ced0-40c3-be4d-b71362bf0c27"); //see guid on olemas
            Guid wrongGuid = Guid.Parse(Guid.NewGuid().ToString()); //loob guidi, mida ei ole olemas
            

            //Act
            //peame kutsuma esile meetodi, mis on realEstateService classis
            //otsime läbi õige guidi, mis on olemas.

            await Svc<IRealEstateServices>().GetAsync(guid);

            //Assert
            //assertimise võrdlus, et võrrelda kahte GUIdi
            Assert.NotEqual(wrongGuid, guid);
        }

        [Fact]
        public async Task Should_GetByIdRealEstate_WhenReturnsEqual()
        {

            //Otsib Id põhjal realestate objekti üles

            //Arrange
            Guid guid1 = Guid.Parse("6c87369d-ced0-40c3-be4d-b71362bf0c27");
            Guid guid2 = Guid.Parse("6c87369d-ced0-40c3-be4d-b71362bf0c27"); //baasis

            //Act
            await Svc<IRealEstateServices>().GetAsync(guid2);

            //Assert
            Assert.Equal(guid1, guid2);
        }


        [Fact]
        public async Task Should_DeleteByIdRealEstate_WhenDeleteREalEstate()
        {
            RealEstateDto realEstate = MockRealEstateData();

            var addRealEstate = await Svc<IRealEstateServices>().Create(realEstate);
            var result = await Svc<IRealEstateServices>().Delete((Guid)addRealEstate.Id);

            Assert.Equal(addRealEstate, result);
        }
        [Fact]
        //ei thohiks kustutada id, kui antakse id ette.
        public async Task ShouldNot_DeleteByIdRealEstate_WhenDidNotDeleteRealEstate()
        {
            RealEstateDto realEstate = MockRealEstateData();

            var realEstate1 = await Svc<IRealEstateServices>().Create(realEstate);
            var realEstate2 = await Svc<IRealEstateServices>().Create(realEstate);
            var result = await Svc<IRealEstateServices>().Delete((Guid)realEstate2.Id);

            Assert.NotEqual(realEstate1.Id, result.Id);
        }

        [Fact]
        public async Task Should_UpdateRealEstate_WhenUpdateData()
        {
            //vaja luua guid, mida hakkame  kasutama upate puhul
            var guid = new Guid("6c87369d-ced0-40c3-be4d-b71362bf0c27");
            RealEstateDto dto = MockRealEstateData();

            //vaja saada domenist andmed kätte
            RealEstate realEstate = new();
            realEstate.Id = Guid.Parse("6c87369d-ced0-40c3-be4d-b71362bf0c27");
            realEstate.Address = "asd1243";
            realEstate.SizeSqrM = 1500;
            realEstate.RoomCount = 100;
            realEstate.Floor = 3;
            realEstate.BuildingType = "skyscraper";
            realEstate.BuiltinYear = DateTime.Now;
            realEstate.CreatedAt = DateTime.Now.AddYears(1);

            //kasutan domaini andmeid
            await Svc<IRealEstateServices>().Update(dto);

            Assert.Equal(realEstate.Id, guid);
            Assert.DoesNotMatch(realEstate.Address, dto.Address);
            Assert.DoesNotMatch(realEstate.Floor.ToString(), dto.Floor.ToString());
            Assert.NotEqual(realEstate.RoomCount, dto.RoomCount);
        }

        [Fact]
        public async Task Should_UpdateRealEstate_WhenUpdateDataVersion2()
        {
            RealEstateDto dto = MockRealEstateData();
            var createRealEstate = await Svc<IRealEstateServices>().Create(dto);

            RealEstateDto update = MockUpdateRealEstateData();
            var result = await Svc<IRealEstateServices>().Update(update);

            Assert.DoesNotMatch(result.Address, createRealEstate.Address);
            Assert.NotEqual(result.UpdatedAt, createRealEstate.UpdatedAt);
            //Assert.Equal(result.CreatedAt, createRealEstate.CreatedAt);
        }

        public async Task ShouldNot_UpdateRealEstate_WhenNotUpdateData()
        {
            RealEstateDto dto = MockRealEstateData();
            await Svc<IRealEstateServices>().Create(dto);

            RealEstateDto nullUpdate = MockNullRealEstate();
            await Svc<IRealEstateServices>().Update(nullUpdate);

            var nullId = nullUpdate.Id;

            Assert.True(dto.Id == nullId);
        }

        private RealEstateDto MockNullRealEstate()
        {
            RealEstateDto nullDto = new()
            {
                Id = null,
                Address = "asd123",
                SizeSqrM = 1232,
                RoomCount = 13,
                Floor = 45,
                BuildingType = "asd123",
                BuiltinYear = DateTime.Now.AddYears(1),
                CreatedAt = DateTime.Now.AddYears(1),
                UpdatedAt = DateTime.Now.AddYears(1),
            };

            return nullDto;
        }

        private RealEstateDto MockRealEstateData() //nö libaandmebaas
        {
            RealEstateDto realEstate = new()
            {
                Address = "asd",
                SizeSqrM = 123,
                RoomCount = 1,
                Floor = 2,
                BuildingType = "asd",
                BuiltinYear = DateTime.Now,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,

            };

            return realEstate;
        }

        private RealEstateDto MockUpdateRealEstateData()
        {
            RealEstateDto realEstate = new()
            {
                Address = "asdasd",
                SizeSqrM = 123123,
                RoomCount = 55,
                Floor = 33,
                BuildingType = "asd",
                BuiltinYear = DateTime.Now.AddYears(1),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now.AddYears(1),

            };
            return realEstate;
        }
    }
}