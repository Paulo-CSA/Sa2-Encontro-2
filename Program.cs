using System.Text.RegularExpressions;
using EncontroRemoto_2.Classes;

PessoaFisica metodoPf = new PessoaFisica();
List<PessoaJuridica> cadastroPj = new List<PessoaJuridica>();
List<PessoaFisica> cadastroPf = new List<PessoaFisica>();

Console.Clear();
Console.WriteLine($@"
===========================================
    Bem Vindo ao Sistema de Cadastro de 
        Pessoa Fisica e Juridica
===========================================
");

Utils.BarraCarregamento("Carregando ");

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
===========================================
    Escolha uma das Opçoes abaixo
-------------------------------------------    
        1 - Pessoa Fisica
        2 - Pessoa Juridica

        0 - Sair    
===========================================");

    Console.WriteLine("Selecione uma Opcao");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            
            string opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===========================================
    Escolha uma das Opçoes abaixo
-------------------------------------------    
        1 - Cadastrar Pessoa Fisica
        2 - Listar Pessoa FIsica

        0 - Voltar ao Menu anterior    
===========================================");

                Console.WriteLine("Selecione uma Opcao");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":


                        //endereco de pessoa fisica
                        Endereco endPf = new Endereco();
                        endPf.logradouro = "Endereco Fisico";
                        endPf.numero = 123;
                        endPf.comercial = false;
                        //pessoa fisica
                        PessoaFisica novaPessoaFisica = new PessoaFisica();
                        Console.WriteLine($"Digite seu Nome:");
                        novaPessoaFisica.nome = Console.ReadLine();
                        novaPessoaFisica.dataNascimento = "20/10/1980";
                        novaPessoaFisica.endereco = endPf;
                        novaPessoaFisica.rendimento = 1501f;
                        novaPessoaFisica.cpf = "123.456.789.00";

                        cadastroPf.Add(novaPessoaFisica);
                        Console.WriteLine("Cadastrado com Sucesso!");
                        Thread.Sleep(1500);
                        break;

                    case "2":
                        Console.WriteLine("----Lista de Pessoas----");
                        Console.WriteLine();
                        foreach (var pf in cadastroPf)
                        {
                            // exibindo os dados pessoa fisica
                            Console.WriteLine($"Nome: {pf.nome}");
                            Console.WriteLine($"Endereco: {pf.endereco.logradouro}");
                            Console.WriteLine($"Numero: {pf.endereco.numero}");
                            Console.WriteLine($"Comercial: {pf.endereco.comercial}");
                            Console.WriteLine($"CPF: {pf.cpf}");
                            Console.WriteLine($"Data de Nascimento: {pf.dataNascimento}");
                            Console.WriteLine($"Maior de idade: {metodoPf.ValidarDataNascimento(pf.dataNascimento)}");
                            Console.WriteLine($"Rendimento: R$ {pf.rendimento}");
                            Console.WriteLine($"Rendimento Liquido: R$ {pf.PagarImposto(pf.rendimento)}");
                            Console.WriteLine();
                        }
                        Console.WriteLine($"Aperte ENTER para continuar:");
                        Console.ReadLine();
                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcao Invalida!");
                        Console.ResetColor();
                        Thread.Sleep(1500);
                        break;
                }


            } while (opcaoPf != "0");
            break;

        case "2":
           

            string opcaoPj;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===========================================
    Escolha uma das Opçoes abaixo
-------------------------------------------    
        1 - Cadastrar Pessoa Juridica
        2 - Listar Pessoa Juridica

        0 - Voltar ao Menu anterior    
===========================================");

                Console.WriteLine("Selecione uma Opcao");
                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1":
                        //endereco de pessoa juridica
                        Endereco endPj = new Endereco();
                        endPj.logradouro = "Endereco Juridico";
                        endPj.numero = 59;
                        endPj.comercial = true;

                        //pessoa juridica
                        PessoaJuridica novaPessoaJuridica = new PessoaJuridica();
                        novaPessoaJuridica.nome = "Teste Juridico";
                        novaPessoaJuridica.razaoSocial = "Teste em pessoa Juridica";
                        novaPessoaJuridica.endereco = endPj;
                        novaPessoaJuridica.cnpj = "73.339.078/0001-09";
                        novaPessoaJuridica.teste = "12345678945125";
                        novaPessoaJuridica.rendimento = 10500f;

                        cadastroPj.Add(novaPessoaJuridica);
                        Console.WriteLine("Cadastrado com Sucesso!");
                        Thread.Sleep(1500);
                        break;

                    case "2":
                        Console.WriteLine("----Lista de Pessoas Juridica----");
                        Console.WriteLine();
                        foreach (var pj in cadastroPj)
                        {
                            //exibindo os dados pessoa juridica
                            Console.WriteLine($"Nome: {pj.nome}");
                            Console.WriteLine($"Razao Social: {pj.razaoSocial}");
                            Console.WriteLine($"CNPJ: {pj.cnpj}");
                            Console.WriteLine($"Endereco: {pj.endereco.logradouro}");
                            Console.WriteLine($"Numero: {pj.endereco.numero}");
                            Console.WriteLine($"Comercial: {pj.endereco.comercial}");
                            Console.WriteLine($"CNPJ: {pj.ValidarCnpj(pj.cnpj)}"); //com mascara
                            Console.WriteLine($"CNPJ1: {pj.ValidarCnpj(pj.teste)}"); //so digitos
                            Console.WriteLine($"Rendimento: R$ {pj.rendimento}");
                            Console.WriteLine($"Rendimento Liquido: R$ {pj.PagarImposto(pj.rendimento)}");
                            Console.WriteLine();
                            
                        }
                        Console.WriteLine($"Aperte ENTER para continuar:");
                        Console.ReadLine();
                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcao Invalida!");
                        Console.ResetColor();
                        Thread.Sleep(1500);
                        break;
                }

            } while (opcaoPj != "0");
            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar o sistema!");
            Utils.BarraCarregamento("Finalizando ");
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opcao Invalida!");
            Console.ResetColor();
            Thread.Sleep(1500);
            break;
    }

} while (opcao != "0");