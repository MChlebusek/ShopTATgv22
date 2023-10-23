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
            Guid guid = Guid.Parse("67457d6e-854d-4112-b467-776ef280574c");
            //kuidas teha automaatselt teeb guidi ???
            Guid wrongGuid =Guid.Parse(Guid.NewGuid().ToString());




            //Guid Wronggugid = Guid.NewGuid();
            //Random random = new Random();
            //int i = random.Next();
        }



    }
}
