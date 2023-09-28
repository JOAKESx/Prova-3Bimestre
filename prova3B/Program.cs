using System;
using prova3B;

Funcionario f = new Funcionario();
f.Nome = "Jurandir";
f.CPF = "000.000.000-00";
f.Matricula = 1;
f.Sexo = "Masculino";
f.Salario = 2.000;

Medico m = new Medico();
m.Nome = "José";
m.CPF = "686.768.452-82";
m.Matricula = 2;
m.Sexo = "Masculino";
m.CRM = "não sei  o que é";
m.Salario = 2.000 + 440;
m.Especialidade = "Cardiologista";

Administrativo adm = new Administrativo();
adm.Nome = "Renato";
adm.CPF = "615.429.031-19";
adm.Matricula = 3;
adm.Salario = 2.000 + 250 + 340;
adm.Funcao = "Analista";

Console.WriteLine("ESCOLHA UMA OPÇÃO:");
Console.WriteLine(" 1 - CADASTRAR MÉDICO");
Console.WriteLine(" 2 - CADASTRAR ADMINISTRATIVO");

