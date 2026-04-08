using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDeContatos2
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Tipo { get; set; }

        public string Mostrar()
        {
            return $"{Nome} possui o {Tipo}: {Telefone}";
        }

        public bool PossuiTelefoneValido()
        {
            //Telefone com 9 caracteres é valido
            return false;
        }
    }
}
