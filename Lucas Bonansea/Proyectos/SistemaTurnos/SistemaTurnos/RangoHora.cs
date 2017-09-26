using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public class RangoHora
    {
        private TimeSpan _inicio;
        private TimeSpan _fin;

        public TimeSpan Inicio { get => _inicio; set => _inicio = value; }
        public TimeSpan Fin { get => _fin; set => _fin = value; }

        public RangoHora(TimeSpan inicio, TimeSpan fin)
        {
            this.Inicio = inicio;
            this.Fin = fin;
        }

        public RangoHora(): this (new TimeSpan(0,0,0), new TimeSpan(23, 59, 59)) {}

        public override bool Equals(object obj)
        {
            if (obj == this) return true;

            if (obj == null) return false;

            RangoHora otro = obj as RangoHora;
            if (otro == null) return false;

            return this.Inicio.Equals(otro.Inicio) && this.Fin.Equals(otro.Fin);
        }

        public override int GetHashCode()
        {
            return this.Inicio.GetHashCode() + this.Fin.GetHashCode();
        }
    }
}