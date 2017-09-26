using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public class ClientePriorizado : Cliente
    {
        private const string LETRA_PRIORIDAD = "P"; //TODO: Ver de sacarlo de metadata o de configuración de la sucursal 
        private const int FACTOR_PRIORIDAD = 2;

        public override string LetraCategoriaPrioridad => LETRA_PRIORIDAD;

        public override int FactorPrioridad => FACTOR_PRIORIDAD;
    }
}