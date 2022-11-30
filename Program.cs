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
Console.Clear();

do
{
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
    Console.Clear();

    switch (opcao)
    {
        case "1":

            string opcaoPf;
            do
            {
                Console.WriteLine(@$"
===========================================
    Escolha uma das Opçoes abaixo
-------------------------------------------    
        1 - Cadastrar Pessoa Fisica
        2 - Listar Pessoa Fisica

        0 - Voltar ao Menu anterior    
===========================================");

                Console.WriteLine("Selecione uma Opcao");
                opcaoPf = Console.ReadLine();
                Console.Clear();

                switch (opcaoPf)
                {
                    case "1":


                        //endereco de pessoa fisica
                        Endereco endPf = new Endereco();
                        Console.WriteLine($"Informe seu Endereco:");
                        endPf.logradouro = Console.ReadLine();
                        Console.WriteLine($"Qual o Numero:");
                        endPf.numero = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Endereco Comercial? s/n:");
                        string enderecoPf = Console.ReadLine();

                        if (enderecoPf.ToUpper() == "S")
                        {
                            endPf.comercial = true;
                        }
                        else
                        {
                            endPf.comercial = false;
                        }

                        //pessoa fisica
                        PessoaFisica novaPessoaFisica = new PessoaFisica();
                        Console.WriteLine($"Digite seu Nome:");
                        novaPessoaFisica.nome = Console.ReadLine();
                        Console.WriteLine($"Informe a Data de Nascimento - xx/xx/xxxx:");
                        novaPessoaFisica.dataNascimento = Console.ReadLine();
                        novaPessoaFisica.endereco = endPf;
                        Console.WriteLine($"Seu Rendimento:");
                        novaPessoaFisica.rendimento = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Informe seu CPF com Pontos:");
                        novaPessoaFisica.cpf = Console.ReadLine();

                        //salva lista em memoria
                        //cadastroPf.Add(novaPessoaFisica);

                        using (StreamWriter sw = new StreamWriter($"./DadosPf/PessoaFisica.txt", append: true))
                        {

                            sw.WriteLine($"Nome: {novaPessoaFisica.nome},Data de Nascimento: {novaPessoaFisica.dataNascimento},Logradouro: {novaPessoaFisica.endereco.logradouro},Numero: {novaPessoaFisica.endereco.numero},Endereco Comercial: {novaPessoaFisica.endereco.comercial},Rendimento: {novaPessoaFisica.rendimento},CPF: {novaPessoaFisica.cpf}");
                            sw.Close();
                        }

                        Console.WriteLine("Cadastrado com Sucesso!");
                        Thread.Sleep(1500);
                        break;

                    case "2":
                        Console.WriteLine("----Lista de Pessoas----");
                        Console.WriteLine();

                        using (StreamReader arquivo = new StreamReader($"./DadosPf/PessoaFisica.txt"))
                        {
                            string linha;
                            while ((linha = arquivo.ReadLine()) != null)
                            {
                             Console.WriteLine($"{linha}");
                             
                            }
                            Utils.ParadaNoConsole("");
                        }

                        // ---listar dados da lista em memoria---
                        // if (cadastroPf.Count > 0)
                        // {
                        //     foreach (var pf in cadastroPf)
                        //     {

                        //         // exibindo os dados pessoa fisica
                        //         Console.WriteLine($"Nome: {pf.nome}");
                        //         Console.WriteLine($"Endereco: {pf.endereco.logradouro}");
                        //         Console.WriteLine($"Numero: {pf.endereco.numero}");
                        //         Console.WriteLine($"Comercial: {pf.endereco.comercial}");
                        //         Console.WriteLine($"CPF: {pf.cpf}");
                        //         Console.WriteLine($"Data de Nascimento: {pf.dataNascimento}");
                        //         Console.WriteLine($"Maior de idade: {metodoPf.ValidarDataNascimento(pf.dataNascimento)}");
                        //         Console.WriteLine($"Rendimento: R$ {pf.rendimento}");
                        //         Console.WriteLine($"Rendimento Liquido: R$ {pf.PagarImposto(pf.rendimento)}");
                        //         Console.WriteLine();
                        //     }
                        //     Utils.ParadaNoConsole("");
                        // }
                        // else
                        // {
                        //     Utils.ParadaNoConsole("A Lista esta Vazia !!!");

                        // }

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
                        Utils.ParadaNoConsole("");

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
            Utils.ParadaNoConsole("Obrigado por utilizar o sistema!");
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