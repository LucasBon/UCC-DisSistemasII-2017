using System;
using System.ComponentModel;

namespace PlayaInteligenteModel
{
    public class Cliente
    {
        private string _dominio;

        public string Dominio { get => _dominio; set => _dominio = value; }

        public Cliente() { }

        public Cliente(string dominio)
        {
            this.Dominio = dominio;
        }
    }
}