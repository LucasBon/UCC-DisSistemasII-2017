using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public class MotivoAtencion
    {
        private int _id;
        private string _letraDescriptiva;
        private string _nombre;
        private Dictionary<DayOfWeek, RangoHora> _mapaDisponibilidad;

        public string LetraDescriptiva { get => _letraDescriptiva; set => _letraDescriptiva = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public Dictionary<DayOfWeek, RangoHora> Disponibildiad { get => _mapaDisponibilidad; private set => _mapaDisponibilidad = value; }
        public int Id { get => _id; set => _id = value; }

        public MotivoAtencion() { } // No usar, solo para EF

        public MotivoAtencion(string nombre, string letraDescriptiva)
        {
            this.Id = 0;
            this.LetraDescriptiva = letraDescriptiva;
            this.Nombre = nombre;
            this.Disponibildiad = new Dictionary<DayOfWeek, RangoHora>();

            //Creo el motivo de atención menu
            MotivoAtencionMenu maMenu = new MotivoAtencionMenu(this);
        }

        public MotivoAtencion(string nombre, string letrasDescriptiva, TimeSpan inicio, TimeSpan fin, bool incluirFinDeSemana) : this(nombre, letrasDescriptiva)
        {
            foreach (DayOfWeek d in Enum.GetValues(typeof(DayOfWeek)))
            {
                if (!incluirFinDeSemana && (d.Equals(DayOfWeek.Sunday) || d.Equals(DayOfWeek.Saturday)))
                    continue;

                setDisponbilidadDelDia(d, inicio, fin);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;

            if (obj == null) return false;

            MotivoAtencion otro = obj as MotivoAtencion;
            if (otro == null) return false;

            if (this.Id > 0 && otro.Id > 0)
            {
                return this.Id.Equals(otro.Id);
            }

            return this.Nombre.Equals(otro.Nombre, StringComparison.CurrentCultureIgnoreCase);
        }

        public override int GetHashCode()
        {
            return this.Nombre.ToUpper().GetHashCode();
        }

        public void setDisponbilidadDelDia(DayOfWeek dia, TimeSpan inicio, TimeSpan fin)
        {
            if (this.Disponibildiad.ContainsKey(dia))
            {
                this.Disponibildiad[dia] = new RangoHora(inicio, fin);
            }
            else
            {
                this.Disponibildiad.Add(dia, new RangoHora(inicio, fin));
            }
        }

        public bool disponible()
        {
            return disponible(DateTime.Now.DayOfWeek, DateTime.Now.TimeOfDay);
        }

        public bool disponible(DayOfWeek dia, TimeSpan hora)
        {
            if (!this.Disponibildiad.ContainsKey(dia)) return false;

            return this.Disponibildiad[dia].Inicio <= hora && hora <= this.Disponibildiad[dia].Fin;
        }

        

    }
}