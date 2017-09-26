using System;
using System.ComponentModel;

namespace PlayaInteligenteModel
{
    public interface DarsenaController
    {
        void ocuparDarsena(Darsena darsena);
        void liberarDarsena(string darsena);
    }
}