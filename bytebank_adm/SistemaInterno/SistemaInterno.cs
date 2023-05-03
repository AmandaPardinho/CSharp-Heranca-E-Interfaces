using bytebank_adm.Funcionarios;
using bytebank_adm.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha, string login)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha, login);
            if(usuarioAutenticado)
            {
                Console.WriteLine("Boas-vindas ao nosso sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }
        }
    }
}
