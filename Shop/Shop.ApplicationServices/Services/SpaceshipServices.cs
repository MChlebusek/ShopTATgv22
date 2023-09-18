﻿using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using Shop.Data;

namespace Shop.ApplicationServices.Services
{
    public class SpaceshipServices : ISpaceshipServices
    {

        private readonly ShopContext _context;

        public SpaceshipServices 
            (
                ShopContext context
            )
        {
            _context=context;
        }

        public async Task<Spaceship>  Create(SpaceshipDto dto)
        {
            Spaceship spaceship= new Spaceship();   

            spaceship.Id= Guid.NewGuid();
            spaceship.Name = dto.Name;
            spaceship.Type = dto.Type;
            spaceship.Passangers = dto.Passangers;
            spaceship.EnginPower = dto.EnginPower;
            spaceship.Crew= dto.Crew; 
            spaceship.Company= dto.Company;
            spaceship.CargoWeight= dto.CargoWeight; 
            spaceship.CreatedAt= DateTime.Now; 
            spaceship.Modifieted= DateTime.Now;

            await _context.Spaceships.AddAsync( spaceship );
            await _context.SaveChangesAsync();



            return spaceship;
        }
        public async Task<Spaceship> Update(SpaceshipDto dto)
        {
            var domain = new Spaceship()
            {
                Id = dto.Id,
                Name = dto.Name,
                Type = dto.Type,
                Passangers = dto.Passangers,
                EnginPower = dto.EnginPower,
                Crew = dto.Crew,
                Company = dto.Company,
                CargoWeight = dto.CargoWeight,
                CreatedAt = dto.CreatedAt,
                Modifieted = DateTime.Now,



            };

            _context.Spaceships.Update( domain ); 
            await _context.SaveChangesAsync();


            return domain;
        }

        public async Task<Spaceship> Delete(Guid id)
        {
            var spaceshipId=await _context.Spaceships
                .FirstOrDefaultAsync(x=>x.Id==id);

            _context.Spaceships.Remove(spaceshipId);    
            await _context.SaveChangesAsync();

            return spaceshipId;
        }



        public async Task<Spaceship> GetAsync(Guid id)
        {
            var result=await _context.Spaceships
                .FirstOrDefaultAsync(x=>x.Id==id);

            return result;
        }
    }
}