using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Core.Domain;
using Shop.Core.Dto.AccountsDtos;

namespace Shop.Core.ServiceInterface
{
    public interface IAccountsServices
    {
        Task<ApplicationUser> Register(ApplicationUserDto dto);
    }
}
