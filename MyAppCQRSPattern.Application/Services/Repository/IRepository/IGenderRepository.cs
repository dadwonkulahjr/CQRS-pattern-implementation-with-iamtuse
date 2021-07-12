using Microsoft.AspNetCore.Mvc.Rendering;
using MyAppCQRSPattern.Application.Common.Interfaces;
using System.Collections.Generic;

namespace MyAppCQRSPattern.Application.Services.Repository.IRepository
{
    public interface IGenderRepository 
    {
        IEnumerable<SelectListItem> GetDropdownSelectListItemsForGender();
    }
}
