using Microsoft.AspNetCore.Mvc.Rendering;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Application.Services.Repository.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace MyAppCQRSPattern.Application.Services.Repository
{
    public class GenderRepository : IGenderRepository
    {
        private readonly IApplicationDbContext _appDbContext;
        public GenderRepository(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }

        public IEnumerable<SelectListItem> GetDropdownSelectListItemsForGender()
        {
            return _appDbContext.Genders.Select(s => new SelectListItem()
            {
                Text = s.Name,
                Value = s.GenderId.ToString()
            });
        }

    }
}
