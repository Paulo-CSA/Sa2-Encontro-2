using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncontroRemoto_2.Interfaces;

namespace EncontroRemoto_2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }
        public string? dataNascimento { get; set; }

        public override float PagarImposto(float parRendimento)
        {
            if (parRendimento <= 1500)
            {
                return parRendimento;
            }
            else if (parRendimento >= 1501 && parRendimento <= 5000)
            {
                return parRendimento - (parRendimento / 100) * 3;
            }
            else
            {
                return parRendimento - (parRendimento / 100) * 5;
            }
        }

        public bool ValidarDataNascimento(string parDtNasc)
        {
            DateTime dataConvertida; 

            if (DateTime.TryParse(parDtNasc, out dataConvertida)){
               
                DateTime dataAtual = DateTime.Today;
               
                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                
                if (anos >= 18)
                {
                    return true;
                }
            }
           return false;
        }
    }
}