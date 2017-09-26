using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public class Turno
    {
        private Cliente _cliente;
        private MotivoAtencion _motivoAtencion;
        private TimeSpan _momentoObtencion;
        private string _codigo;
        private int _id;

        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public MotivoAtencion MotivoAtencion { get => _motivoAtencion; set => _motivoAtencion = value; }
        public TimeSpan MomentoObtencion { get => _momentoObtencion; set => _momentoObtencion = value; }        
        public string Codigo { get => _codigo; set => _codigo = value; }
        public int Id { get => _id; set => _id = value; }

        public Turno() { }

        public Turno(MotivoAtencion motivo) : this (motivo, new ClienteAnonimo()) { }

        public Turno(MotivoAtencion motivo, Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public string anunciar ()
        {
            return Codigo;
        }
    }
}