using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncontroRemoto_2.Interfaces;

namespace EncontroRemoto_2.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome;
        public Endereco? endereco;
        public float rendimento { get; set; }

        public abstract float PagarImposto(float parRendimento);
        
    }
}