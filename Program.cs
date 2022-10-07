using System;
using System.Text.RegularExpressions;

// criar uma pessoa física
// preencher o nome
// imprimir no console

using FS11__UC12_ER2.Classes;

// PessoaFisica eduardo = new PessoaFisica();

// eduardo.dataNascimento = "1982/07/20";
// System.Console.WriteLine( eduardo.ValidarDataNascimento("1982/07/20") ); 

// Console.WriteLine($"*************************");
// Console.WriteLine();

// string nome = "Eduardo";
// Console.WriteLine($"{nome.Substring(0, 2)}");


// PessoaFisica jose = new PessoaFisica();
// PessoaJuridica robertoImoveis = new PessoaJuridica();

// eduardo.nome = "Eduardo Costa";

// System.Console.WriteLine("Nome do Cabra: " + eduardo.nome);
// System.Console.WriteLine($"Nome do Cara: {eduardo.nome}");
// Console.WriteLine($"Qual é o seu nome?");

//preenchendo um objeto de Endereço
// Endereco novoEndereco = new Endereco();
//          novoEndereco.logradouro = "Rua de Casa";
//          novoEndereco.numero = 50;
//          novoEndereco.comercial = false;

// PessoaFisica eduardo = new PessoaFisica();
//        eduardo.nome = "Eduardo Costa";
//        eduardo.rendimento = 1000.99;
//        eduardo.endereco = novoEndereco;

// //exibir os dados do eduardo
// Console.WriteLine($"Nome: {eduardo.nome}");
// Console.WriteLine($"Rendimento: R${eduardo.rendimento}");
// Console.WriteLine($"Endereço:");

// Console.WriteLine($"\tRua: {eduardo.endereco.logradouro}");
// Console.WriteLine($"\tNúmero: {eduardo.endereco.numero}");
// Console.WriteLine($"\tComercial: {eduardo.endereco.comercial}");

Endereco novoEndSenai = new Endereco();
    novoEndSenai.logradouro = "Rua Niterói";
    novoEndSenai.numero = 180;
    novoEndSenai.comercial = true;

PessoaJuridica senai = new PessoaJuridica();
    senai.razaoSocial = "Serviço de Nacional de Aprendizagem Industrial";
    // senai.cnpj = "12.222.444/0001-90";
    senai.cnpj = "12222444000190";
    senai.nome = "SENAI";
    senai.rendimento = 100000.80;
    senai.endereco = novoEndSenai;

PessoaJuridica metodosPJ = new PessoaJuridica();


Console.WriteLine($"Cnpj {senai.cnpj} é válido? {metodosPJ.ValidarCnpj(senai.cnpj)}");

//exibir os dados do eduardo
// Console.WriteLine($"Fantasia: {senai.nome}");
// Console.WriteLine($"Razão: {senai.razaoSocial}");
// Console.WriteLine($"CNPJ:{senai.cnpj}");
// Console.WriteLine($"Rendimento: R$ {senai.rendimento}");

// Console.WriteLine($"\tRua: {senai.endereco.logradouro}");
// Console.WriteLine($"\tNúmero: {senai.endereco.numero}");
// Console.WriteLine($"\tComercial: {senai.endereco.comercial}");

// Console.WriteLine(@$"
//                 Fantasia: {senai.nome}
//     $Razão: {senai.razaoSocial}
// ");


// ***************** SUBSTRING *****************
//             0123456
// string nome = "Eduardo";
// Console.WriteLine(nome);
// Console.WriteLine( nome.Substring(0, 3)  );
// Console.WriteLine( nome.Substring(1, 2)  );
// Console.WriteLine( nome.Substring(4, 1)  );

// string cnpj = "12.222.444/0001-90";
// string cnpj2 = "12222444000190";
// Console.WriteLine( cnpj.Substring(11, 4)  );
// Console.WriteLine( cnpj2.Substring(8, 4)  );

// Console.WriteLine($"CNPJ TAMNHO: {cnpj.Length}");
// Console.WriteLine($"CNPJ TAMNHO: {cnpj2.Length}");


// ***************** REGEX *****************

// String data = "30/09/2022";
// bool dtValida = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");

// Console.WriteLine($"A data {data} é válida? {dtValida}"); 


















