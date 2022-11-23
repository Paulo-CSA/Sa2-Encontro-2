using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncontroRemoto_2.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNascimento (string parDtNasc);
    }
}