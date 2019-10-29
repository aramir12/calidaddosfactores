using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calidad.DosFactores.Models
{
    public class ApplicationUser:IdentityUser
    {
        public virtual string TfaKey { get; set; }

    }
}
