using System;
using System.Text.RegularExpressions;

using FS11__UC12_ER2.Classes;
//Objetos utilitários genéricos
PessoaJuridica metodosPJ = new PessoaJuridica();
PessoaFisica metodosPF = new PessoaFisica();


//Cabeçalho boas vindas
Console.WriteLine(@$"
==================================================
|     Bem vindo ao sistema de cadastro de        |
|        Pessoas Físicas e Jurídicas             |
==================================================
");

Utils.BarraCarregamento("Iniciando o Sistema", 3, 500);

// ************************* MENU DE OPÇÕES **********************
string? opcao;

do
{
    Console.WriteLine(@$"
==================================================
|         Escolha uma das seguintes opções       |
|------------------------------------------------|
|               1 - Pessoa Física                |
|               2 - Pessoa Jurídica              |
|                                                |
|               0 - Sair                         |
==================================================
");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();//espera o usuário digitar
    Console.Clear();

    switch (opcao)
    {
        case "1": // Pessoa Física
            Utils.BarraCarregamento("Cadastrando", 3, 300);
            // Endereço da pessoa física
            Endereco endPf = new Endereco();
            endPf.logradouro = "Rua de Casa";
            endPf.numero = 123;
            endPf.comercial = false;
            //cadastra a pessoa física
            PessoaFisica joao = new PessoaFisica();
            joao.nome = "João da Silva";
            joao.cpf = "12345670977";
            joao.dataNascimento = "20/09/1990";
            joao.rendimento = 3590.98;
            joao.endereco = endPf;

            //exibir os dados
            Console.WriteLine(@$"
                Nome: {joao.nome}
                Endereço: {joao.endereco.logradouro}
                Número: {joao.endereco.numero}
                Endereço Comercial: {joao.endereco.comercial}
                Data Nascimento {joao.dataNascimento}
                Maior de Idade: {metodosPF.ValidarDataNascimento(joao.dataNascimento)}
                CPF: {joao.cpf}
                Rendimento Bruto: R${joao.rendimento}
                Rendimento Líquido: R${metodosPF.PagarImposto(joao.rendimento)}
            ");

            //  parada no sistema
            Console.Write($"Digite ENTER para continuar ... ");
            Console.ReadLine();
            Console.Clear();
            break;

        case "2":// Pessoa Jurídica
            //Cadastro
            Endereco novoEndSenai = new Endereco();
            novoEndSenai.logradouro = "Rua Niterói";
            novoEndSenai.numero = 180;
            novoEndSenai.comercial = true;

            PessoaJuridica senai = new PessoaJuridica();
            senai.razaoSocial = "Serviço de Nacional de Aprendizagem Industrial";
            senai.cnpj = "12.222.444/0002-90";
            // senai.cnpj = "122224440002909";
            senai.nome = "SENAI";
            senai.rendimento = 12000;
            senai.endereco = novoEndSenai;

            // Exibir os dados
            Console.WriteLine(@$"
                Razão Social: {senai.razaoSocial}
                Nome Fantasia: {senai.nome}
                Endereço: {senai.endereco.logradouro}
                Número: {senai.endereco.numero}
                Endereço Comercial: {senai.endereco.comercial}
                CNPJ: {senai.cnpj}
                CNPJ Válido: {metodosPJ.ValidarCnpj(senai.cnpj)}
                Rendimento Bruto: R${senai.rendimento}
                Rendimento Líquido: R${metodosPJ.PagarImposto(senai.rendimento)}
            ");

            //  parada no sistema
            Console.Write($"Digite ENTER para continuar ... ");
            Console.ReadLine();
            Console.Clear();
            break;

        case "0":// Sair
            Console.WriteLine($"Obrigado por utilizar o nosso sistema !!!");
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção Inválida, escolha outra opção");
            Console.ResetColor();
            break;
    }

} while (opcao != "0");



