using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public class ClienteAnonimo : Cliente
    {
        private const string LETRA_ANONIMO = "A";
        private const int FACTOR_PRIORIDAD = 1;

        public override string LetraCategoriaPrioridad { get => LETRA_ANONIMO; }
        public override int FactorPrioridad { get => FACTOR_PRIORIDAD; }
    }
}