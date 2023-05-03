using bytebank_adm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.SistemaInterno
{
    public interface IAutenticavel 
    {
        public string Senha { get; set; }

        public string Login { get; set; }

        public bool Autenticar(string senha, string login);

    }
}
