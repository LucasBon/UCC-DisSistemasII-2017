using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public class ClienteConocido : Cliente
    {
        private string _letraPrioridad;
        private int _factorPrioridad;

        public override string LetraCategoriaPrioridad => _letraPrioridad;
        
        public override int FactorPrioridad => _factorPrioridad;

        public void SetLetraCategoriaPrioridad (string value)
        {
            _letraPrioridad = value;
        }

        public void SetFactorPrioridad (int value)
        {
            _factorPrioridad = value;
        }
    }
}