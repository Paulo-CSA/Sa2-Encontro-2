using System.Text.RegularExpressions;
using EncontroRemoto_2.Classes;

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
            PessoaFisica metodoPf = new PessoaFisica();
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
            //exibindo os dados pessoa fisica
            Console.WriteLine($"Nome: {novaPessoaFisica.nome}");
            Console.WriteLine($"Endereco: {novaPessoaFisica.endereco.logradouro}");
            Console.WriteLine($"Numero: {novaPessoaFisica.endereco.numero}");
            Console.WriteLine($"Comercial: {novaPessoaFisica.endereco.comercial}");
            Console.WriteLine($"CPF: {novaPessoaFisica.cpf}");
            Console.WriteLine($"Data de Nascimento: {novaPessoaFisica.dataNascimento}");
            Console.WriteLine($"Maior de idade: {metodoPf.ValidarDataNascimento(novaPessoaFisica.dataNascimento)}");
            Console.WriteLine($"Rendimento: R$ {novaPessoaFisica.rendimento}");
            Console.WriteLine($"Rendimento Liquido: R$ {novaPessoaFisica.PagarImposto(novaPessoaFisica.rendimento)}");
            Console.WriteLine($"Aperte ENTER para continuar:");
            Console.ReadLine();
            break;

        case "2":
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
            //exibindo os dados pessoa juridica
            Console.WriteLine($"Nome: {novaPessoaJuridica.nome}");
            Console.WriteLine($"Razao Social: {novaPessoaJuridica.razaoSocial}");
            Console.WriteLine($"CNPJ: {novaPessoaJuridica.cnpj}");
            Console.WriteLine($"Endereco: {novaPessoaJuridica.endereco.logradouro}");
            Console.WriteLine($"Numero: {novaPessoaJuridica.endereco.numero}");
            Console.WriteLine($"Comercial: {novaPessoaJuridica.endereco.comercial}");
            Console.WriteLine($"CNPJ: {novaPessoaJuridica.ValidarCnpj(novaPessoaJuridica.cnpj)}"); //com mascara
            Console.WriteLine($"CNPJ1: {novaPessoaJuridica.ValidarCnpj(novaPessoaJuridica.teste)}"); //so digitos
            Console.WriteLine($"Rendimento: R$ {novaPessoaJuridica.rendimento}");
            Console.WriteLine($"Rendimento Liquido: R$ {novaPessoaJuridica.PagarImposto(novaPessoaJuridica.rendimento)}");
            Console.WriteLine($"Aperte ENTER para continuar:");
            Console.ReadLine();
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