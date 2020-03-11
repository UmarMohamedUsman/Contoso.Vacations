using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso.Vacations.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Contoso.Vacations.Controllers
{
    [Route("api/[controller]")]
    public class PackagesController : Controller
    {

        private List<Package> _packages = new List<Package>
         {
                    new Package { PackageId = 1, PackageName = "Maui", NumberOfNights=7, Price=3008},
                    new Package { PackageId = 2, PackageName = "Honolulu", NumberOfNights = 5, Price = 2005 },
                    new Package { PackageId = 3, PackageName = "Big Island", NumberOfNights = 6, Price = 2500 },
                    new Package { PackageId = 4, PackageName = "Miami Beach", NumberOfNights = 7, Price = 2800 },
                    new Package { PackageId = 5, PackageName = "Nassau Bahamas", NumberOfNights = 4, Price = 1999 }
         };


        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Package> Get()
        {
            Console.WriteLine("Total number of Vacation Packages: " + _packages.Count);
            return _packages;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Package Get(int id)
        {
            Package package = _packages.Find(x => x.PackageId == id);

            if (package != null)
            {
                Console.WriteLine("Vacation Package ID {0} found ", id);
                return package;
            }
            else
            {
                Console.Error.WriteLine("Vacation Package ID {0} not found ", id);
                return null;
            }
        }
    }
}
