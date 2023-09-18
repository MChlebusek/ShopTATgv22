﻿using Microsoft.AspNetCore.Mvc;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using Shop.Data;
using Shop.Models.Spaceship;

namespace Shop.Controllers
{
    public class SpaceshipsController : Controller
    {
        private readonly ShopContext _context;
        private readonly ISpaceshipServices _spaceshipServices;

        public SpaceshipsController
            (
            ShopContext context,
            ISpaceshipServices spaceshipServices
            ) 
        {
            _context = context;
            _spaceshipServices = spaceshipServices;
        }

        public IActionResult Index()


        {
            var result = _context.Spaceships
                .Select(x => new SpaeshipsIndexViewModel
                {
                    Id= x.Id,
                    Name= x.Name, 
                    Type= x.Type, 
                    EnginPower= x.EnginPower,
                    Passangers= x.Passangers,
                });


            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create(SpaceshipsCreateViewModel vm)
        {
            var dto = new SpaceshipDto()
            {
                Id = vm.Id,
                Name = vm.Name,
                Type = vm.Type,
                Passangers = vm.Passangers,
                EnginPower = vm.EnginPower,
                Crew = vm.Crew,
                Company = vm.Company,
                CargoWeight = vm.CargoWeight

            };

            var result = await _spaceshipServices.Create(dto);
            //return index
            return RedirectToAction(nameof(Index), vm);
        }


    }
}
