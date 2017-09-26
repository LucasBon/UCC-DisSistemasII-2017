using System;
using System.Collections.Generic;

namespace PlayaInteligenteModel
{
    public class Darsena
    {
        private int _numero;
        private EstadoDarsena _estado;

        public int Numero { get => _numero; set => _numero = value; }
        public EstadoDarsena Estado { get => _estado; set => _estado = value; }

        public void reservar()
        {
            throw new System.NotImplementedException();
        }

        public void ocupar(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public void liberar()
        {
            throw new System.NotImplementedException();
        }
    }
}