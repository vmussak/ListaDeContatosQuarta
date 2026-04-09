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

        public string MensagemErro { get; set; }

        public string Mostrar()
        {
            return $"{Nome} possui o {Tipo}: {Telefone}";
        }

        public bool PossuiTelefoneValido()
        {
            if (Telefone.Length != 11)
                return false;

            var somenteNumeros = long.TryParse(Telefone, out _);
            if(!somenteNumeros)
                return false;

            return true;
        }

        public bool PossuiNomeValido()
        {
            if (Nome.Length == 0)
                return false;

            if (Nome.Length > 15)
                return false;

            return true;
        }

        public bool PossuiTipoValido()
        {
            if (Tipo == "Celular")
                return true;

            if (Tipo == "Fixo")
                return true;

            return false;
        }

        public bool Validar()
        {
            if (!PossuiTelefoneValido())
            {
                MensagemErro = "Telefone inválido";
                return false;
            }

            if (!PossuiNomeValido())
            {
                MensagemErro = "Nome inválido";
                return false;
            }

            if (!PossuiTipoValido())
            {
                MensagemErro = "Tipo inválido";
                return false;
            }

            return true;
        }
    }
}
