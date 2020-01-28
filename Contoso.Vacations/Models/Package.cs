using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Vacations.Models
{
    public class Package
    {
        public int PackageId { get; set; }

        public string PackageName { get; set; }

        public int NumberOfNights { get; set; }

        public decimal Price { get; set; }
    }
}
