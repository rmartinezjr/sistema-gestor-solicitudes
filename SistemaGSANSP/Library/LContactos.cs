using SistemaGSANSP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGSANSP.Library
{
    public class LContactos
    {
        private ApplicationDbContext context;

        public LContactos(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
