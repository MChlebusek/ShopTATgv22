using Shop.Core.Domain;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;

namespace KinderGartenTest
{
    public class KinderGartenTest: TestBase
    {
        [Fact]
        public async Task ShouldNot_AddEmptyKinderGarten_WhenReturnResult()
        {   //Arrange ehk andmete ettevalmistus
            KinderGartenDto dto = new KinderGartenDto();
            //RealEstateDto realEstate = new(); sama mis eelmine, lihtsalt lühem
            dto.GroupName = "asd";
            dto.ChildrenCount = 10;
            dto.KindergartenName = "asd";
            dto.Teacher = "asd";
            dto.CreatedAt = DateTime.Now;
            dto.UpdatedAt = DateTime.Now;

            //Act ehk sisuline tegevus mida teeb
            var result = await Svc<IKindergartenServices>().Create(dto);

            //Assert ehk sisestus
            Assert.NotNull(result); //iga kord kui tehakse unit test, kirjutatakse assert...
        }

        [Fact]
        public async Task ShouldNot_GetByIdKinderGarte_WhenReturnsNotEqual()
        {
            //Arrage
            Guid guid = Guid.Parse("6c87369d-ced0-40c3-be4d-b71362bf0c27"); //see guid on olemas
            Guid wrongGuid = Guid.Parse(Guid.NewGuid().ToString()); //loob guidi, mida ei ole olemas


            //Act
            //peame kutsuma esile meetodi, mis on realEstateService classis
            //otsime läbi õige guidi, mis on olemas.

            await Svc<IKindergartenServices>().GetAsync(guid);

            //Assert
            //assertimise võrdlus, et võrrelda kahte GUIdi
            Assert.NotEqual(wrongGuid, guid);
        }

        [Fact]
        public async Task Should_GetByIdKinderGarten_WhenReturnsEqual()
        {

            //Otsib Id põhjal realestate objekti üles

            //Arrange
            Guid guid1 = Guid.Parse("6c87369d-ced0-40c3-be4d-b71362bf0c27");
            Guid guid2 = Guid.Parse("6c87369d-ced0-40c3-be4d-b71362bf0c27"); //baasis

            //Act
            await Svc<IKindergartenServices>().GetAsync(guid2);

            //Assert
            Assert.Equal(guid1, guid2);
        }


        [Fact]
        public async Task Should_DeleteByIdKinderGartene_WhenDeleteREalEstate()
        {
            KinderGartenDto KinderGarten = MockKinderGartenData();

            var addKinderGarten = await Svc<IKindergartenServices>().Create(KinderGarten);
            var result = await Svc<IKindergartenServices>().Delete((Guid)addKinderGarten.Id);

            Assert.Equal(addKinderGarten, result);
        }
        [Fact]
        //ei thohiks kustutada id, kui antakse id ette.
        public async Task ShouldNot_DeleteByIdKinderGarten_WhenDidNotDeleteRealEstate()
        {
            KinderGartenDto KinderGarten = MockKinderGartenData();

            var KinderGarten1 = await Svc<IKindergartenServices>().Create(KinderGarten);
            var KinderGarten2 = await Svc<IKindergartenServices>().Create(KinderGarten);
            var result = await Svc<IKindergartenServices>().Delete((Guid)KinderGarten2.Id);

            Assert.NotEqual(KinderGarten1.Id, result.Id);
        }

        [Fact]
        public async Task Should_UpdateKinderGarten_WhenUpdateData()
        {
            //vaja luua guid, mida hakkame  kasutama upate puhul
            var guid = new Guid("6c87369d-ced0-40c3-be4d-b71362bf0c27");
            KinderGartenDto dto = MockKinderGartenData();

            //vaja saada domenist andmed kätte
            KinderGarten KinderGarten = new();
            KinderGarten.Id = Guid.Parse("6c87369d-ced0-40c3-be4d-b71362bf0c27");
            KinderGarten.GroupName = "asd1243";
            KinderGarten.ChildrenCount = 1500;
            KinderGarten.KindergartenName = "assd";
            KinderGarten.Teacher = "assd";
            KinderGarten.CreatedAt = DateTime.Now.AddYears(1);

            //kasutan domaini andmeid
            await Svc<IKindergartenServices>().Update(dto);

            Assert.Equal(KinderGarten.Id, guid);
            Assert.DoesNotMatch(KinderGarten.GroupName, dto.GroupName);
            Assert.DoesNotMatch(KinderGarten.ChildrenCount.ToString(), dto.ChildrenCount.ToString());
            Assert.NotEqual(KinderGarten.Teacher, dto.Teacher);
        }

        [Fact]
        public async Task Should_UpdateKinderGarten_WhenUpdateDataVersion2()
        {
            KinderGartenDto dto = MockKinderGartenData();
            var createKinderGarten = await Svc<IKindergartenServices>().Create(dto);

            KinderGartenDto update = MockUpdateKinderGartenData();
            var result = await Svc<IKindergartenServices>().Update(update);

            Assert.DoesNotMatch(result.GroupName, createKinderGarten.GroupName);
            Assert.NotEqual(result.UpdatedAt, createKinderGarten.UpdatedAt);

        }

        [Fact]
        public async Task ShouldNot_UpdateKinderGarten_WhenNotUpdateData()
        {
            KinderGartenDto dto = MockKinderGartenData();
            await Svc<IKindergartenServices>().Create(dto);

            KinderGartenDto nullUpdate = MockNullKinderGarten();
            await Svc<IKindergartenServices>().Update(nullUpdate);

            var nullId = nullUpdate.Id;

            Assert.True(dto.Id == nullId);
        }

        private KinderGartenDto MockNullKinderGarten()
        {
            KinderGartenDto nullDto = new()
            {
                Id = null,
                GroupName = "asd123",
                ChildrenCount = 1232,
                KindergartenName = "asd123",
                Teacher = "asd123",
                CreatedAt = DateTime.Now.AddYears(1),
                UpdatedAt = DateTime.Now.AddYears(1),
            };

            return nullDto;
        }

        private KinderGartenDto MockKinderGartenData() //nö libaandmebaas
        {
            KinderGartenDto KinderGarten = new()
            {
                GroupName = "asd",
                ChildrenCount = 123,
                KindergartenName = "asd",
                Teacher = "asd",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,

            };

            return KinderGarten;
        }

        private KinderGartenDto MockUpdateKinderGartenData()
        {
            KinderGartenDto KinderGarten = new()
            {
                GroupName = "asd123",
                ChildrenCount = 1232,
                KindergartenName = "asd123",
                Teacher = "asd123",
                CreatedAt = DateTime.Now.AddYears(1),
                UpdatedAt = DateTime.Now.AddYears(1),

            };
            return KinderGarten;
        }
    }
}
