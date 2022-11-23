using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncontroRemoto_2.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj (string parCnpj);
    }
}