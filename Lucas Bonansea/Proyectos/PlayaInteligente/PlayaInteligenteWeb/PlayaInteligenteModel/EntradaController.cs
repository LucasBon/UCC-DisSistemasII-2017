using System;
using System.ComponentModel;

namespace PlayaInteligenteModel
{
    public interface EntradaController
    {
        Darsena buscarDarsenaLibre();
        Estadia iniciarEstadia(Cliente cliente, Darsena darsena);
    }
}