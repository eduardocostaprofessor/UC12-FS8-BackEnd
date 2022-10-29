using System;
using System.Text.RegularExpressions;

using FS11__UC12_ER2.Classes;
//Objetos utilitários genéricos
PessoaJuridica metodosPJ = new PessoaJuridica();
PessoaFisica metodosPF = new PessoaFisica();
List<PessoaFisica> listaPf = new List<PessoaFisica>();//cira uma lista de pessoa física (Array de Objetos)


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
                  // Utils.BarraCarregamento("Cadastrando", 3, 300);

            string opcaoPf;
            do //SUBMENU DE PESSOA FÍSICA
            {
                Console.Clear();
                Console.WriteLine(@$"
==================================================
|         Escolha uma das seguintes opções       |
|------------------------------------------------|
|          1 - Cadastrar Pessoa Física           |
|          2 - Listar Pessoa Física              |
|                                                |
|          0 - Voltar ao menu anterior           |
==================================================
");

                Console.Write("Opção: ");
                opcaoPf = Console.ReadLine();//espera o usuário digitar

                switch (opcaoPf)
                {
                    case "1": //aqui vamos cadastrar uma pessoa física
                        //Endereço
                        // Endereco endPf = new Endereco();
                        // Console.WriteLine($"Qual é o endereço?");
                        // endPf.logradouro = Console.ReadLine();
                        // Console.WriteLine($"Qual é número?");
                        // endPf.numero = int.Parse(Console.ReadLine());
                        // Console.WriteLine($"Endereço é comercial? S/N");
                        // string enderecoComercial = Console.ReadLine();

                        // if (enderecoComercial.ToUpper() == "S")
                        // {
                        //     endPf.comercial = true;
                        // }
                        // else
                        // {
                        //     endPf.comercial = false;
                        // }

                        //Dados Pessoais
                        PessoaFisica novaPf = new PessoaFisica();
                        novaPf.PreencherDadosTeste();
                        //Cadastrar no TXT

                        using (StreamWriter arquivo = new StreamWriter($"./DadosPf/PessoaFisica.txt", append: true))
                        {
                            arquivo.WriteLine($"{novaPf.nome},{novaPf.endereco.logradouro},{novaPf.endereco.numero}");
                            arquivo.Close();
                        }


                        // Console.WriteLine($"Qual é o nome?");
                        // novaPf.nome = Console.ReadLine();
                        // Console.WriteLine($"Qual é o cpf?");
                        // novaPf.cpf = Console.ReadLine();
                        // Console.WriteLine($"Qual é a data de nascimento? Ex: 20/09/1990");
                        // novaPf.dataNascimento = Console.ReadLine();
                        // Console.WriteLine($"Qual é rendimento?");
                        // novaPf.rendimento = double.Parse(Console.ReadLine());
                        // novaPf.endereco = endPf;

                        // guarda a pessoa física na lista
                        // listaPf.Add(novaPf);


                        //fazer parada no sistema
                        Utils.ParadaNoConsole("Pessoa Física cadastrada com sucesso");
                        break;

                    case "2":
                        //aqui vamos listar pessoa física
                        Console.WriteLine($"listar uma pessoa física");
                        using (StreamReader arquivo = new StreamReader($"./DadosPf/PessoaFisica.txt"))
                        {
                            string linha;

                            while ( (linha = arquivo.ReadLine()) != null )
                            {
                                Console.WriteLine($"{linha}");
                                
                            }
                        }

                        // if (listaPf.Count > 0) //lista
                        // {
                        //     foreach (PessoaFisica pf in listaPf) //imprime cada pessoa da lista
                        //     {
                        //         pf.Imprimir(); //vide o método - imprime todas as propriedades da classe 

                        //     }

                        // }
                        // else
                        // {
                        //     Console.ForegroundColor = ConsoleColor.DarkRed;
                        //     Console.WriteLine($"Lista Vazia");
                        //     Console.ResetColor();
                        //     Thread.Sleep(2000);
                        // }

                        //fazer parada no sistema
                        Utils.ParadaNoConsole("*** Fim da listagem ***");
                        break;

                    case "0":
                        //voltar ao menu anterior
                        Console.WriteLine($"voltar ao menu anterior");
                        break;

                    default:
                        //voltar ao menu anterior
                        Console.ForegroundColor = ConsoleColor.Red;
                        //fazer parada no sistema
                        Utils.ParadaNoConsole("opção inválida do submenu");
                        Console.ResetColor();
                        break;
                }


            } while (opcaoPf != "0");

            Console.Clear();
            break;

        case "2":// Pessoa Jurídica


            //  parada no sistema
            Utils.ParadaNoConsole("Digite ENTER para continuar ... ");
            Console.Clear();
            break;

        case "0":// Sair
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Obrigado por utilizar o nosso sistema !!!");
            Console.ResetColor();
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção Inválida, escolha outra opção");
            Console.ResetColor();
            break;
    }

} while (opcao != "0");


















// CÓDIGO PRA USAR DE BASE - LEITURA E EXIBIÇÃO MOCADA/FIXA DE DADOS

// Endereço da PESSOA FÍSICA
// Endereco endPf = new Endereco();
// endPf.logradouro = "Rua de Casa";
// endPf.numero = 123;
// endPf.comercial = false;

// //cadastra a pessoa física
// PessoaFisica joao = new PessoaFisica();
// joao.nome = "João da Silva";
// joao.cpf = "12345670977";
// joao.dataNascimento = "20/09/1990";
// joao.rendimento = 3590.98;
// joao.endereco = endPf;

// //exibir os dados pessoa física
// Console.WriteLine(@$"
//     Nome: {joao.nome}
//     Endereço: {joao.endereco.logradouro}
//     Número: {joao.endereco.numero}
//     Endereço Comercial: {joao.endereco.comercial}
//     Data Nascimento {joao.dataNascimento}
//     Maior de Idade: {metodosPF.ValidarDataNascimento(joao.dataNascimento)}
//     CPF: {joao.cpf}
//     Rendimento Bruto: R${joao.rendimento}
//     Rendimento Líquido: R${metodosPF.PagarImposto(joao.rendimento)}
// ");



//Cadastro Pessoa Jurídica
// Endereco novoEndSenai = new Endereco();
// novoEndSenai.logradouro = "Rua Niterói";
// novoEndSenai.numero = 180;
// novoEndSenai.comercial = true;

// PessoaJuridica senai = new PessoaJuridica();
// senai.razaoSocial = "Serviço de Nacional de Aprendizagem Industrial";
// senai.cnpj = "12.222.444/0002-90";
// // senai.cnpj = "122224440002909";
// senai.nome = "SENAI";
// senai.rendimento = 12000;
// senai.endereco = novoEndSenai;

// // Exibir os dados Pessoa Jurídica
// Console.WriteLine(@$"
//     Razão Social: {senai.razaoSocial}
//     Nome Fantasia: {senai.nome}
//     Endereço: {senai.endereco.logradouro}
//     Número: {senai.endereco.numero}
//     Endereço Comercial: {senai.endereco.comercial}
//     CNPJ: {senai.cnpj}
//     CNPJ Válido: {metodosPJ.ValidarCnpj(senai.cnpj)}
//     Rendimento Bruto: R${senai.rendimento}
//     Rendimento Líquido: R${metodosPJ.PagarImposto(senai.rendimento)}
// ");