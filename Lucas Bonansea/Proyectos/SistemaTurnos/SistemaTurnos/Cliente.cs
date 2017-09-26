using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTurnos
{
    public abstract class Cliente
    {
        public abstract string LetraCategoriaPrioridad { get;  }         
        public abstract int FactorPrioridad { get;  }
    }
}
