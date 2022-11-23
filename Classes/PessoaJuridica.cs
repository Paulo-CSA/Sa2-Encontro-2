using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using EncontroRemoto_2.Interfaces;

namespace EncontroRemoto_2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? razaoSocial { get; set; }

        public string? cnpj { get; set; }

        public string? teste { get; set; }

        public override float PagarImposto(float parRendimento)
        {
            if (parRendimento <= 5000)
            {
                return parRendimento - (parRendimento / 100) * 6;
            }
            else if (parRendimento >= 5001 && parRendimento <= 10000)
            {
                return parRendimento - (parRendimento / 100) * 8;
            }
            else
            {
                return parRendimento - (parRendimento / 100) * 10;
            }
        }

        public bool ValidarCnpj(string parCnpj)
        {
            if (Regex.IsMatch(parCnpj, @"(^\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$"))
            {
                if (parCnpj.Length == 18)
                {
                    if(parCnpj.Substring(11,4) == "0001"){
                        return true;
                    }
                }
                else if (parCnpj.Length == 14)
                {
                    if(parCnpj.Substring(8,4) == "0001"){
                        return true;
                    }
                }
            }

            return false;
        }
    }
}