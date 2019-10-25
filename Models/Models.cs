using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MasigasigTrackingSystem.Models
{
    public class Driver 
    {
        public string ID {get;set;}
        public string FullName {get;set;}

    }
    public class DropdownListViewModel
    {
        public int ID { get; set; }
        public IList<SelectListItem> Drivers { get; set; }
    }
}