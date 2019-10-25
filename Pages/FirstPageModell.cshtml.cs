using System.Collections.Generic;
using System.Linq;
using MasigasigTrackingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MasigasigTrackingSystem.Pages.TestingPages
{
    public class FirstPageModel : PageModel
    {


        public List<SelectListItem> DriverList { get; set; }

        [BindProperty]
        public DropdownListViewModel DropdownListViewModel { get; set; }

        public void OnGet()
        {
            // fake Drivers from DB
            var Drivers = new Driver[]{
                new Driver(){ID = "id1", FullName = "name1"},
                new Driver(){ID = "id2", FullName = "name2"},
                new Driver(){ID = "id3", FullName = "name3"},
                new Driver(){ID = "id4", FullName = "name4"},
                new Driver(){ID = "id5", FullName = "name5"},
            };
            DriverList= Drivers.Select(a =>
                new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.FullName,
                    //Selected = false,
                }).ToList();
            DropdownListViewModel = new DropdownListViewModel();

            DropdownListViewModel.Drivers = DriverList;
        }

        public IActionResult OnGetDropdownListAsync(int tc)
        {
            // Fake Drivers From DB
            var Drivers = new Driver[]{
                new Driver(){ID = "id1", FullName = "name1"},
                new Driver(){ID = "id2", FullName = "name2"},
                new Driver(){ID = "id3", FullName = "name3"},
                new Driver(){ID = "id4", FullName = "name4"},
                new Driver(){ID = "id5", FullName = "name5"},
            };
            var list= Drivers.Select(a =>
                new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.FullName,
                    //Selected = false,
                }).ToList();
            return Partial("/Pages/TestingPages/_SecondPage.cshtml", new DropdownListViewModel
            {
                Drivers = list,
                ID= tc,
            });
        }
    }
}