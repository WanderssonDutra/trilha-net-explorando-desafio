using System;
using TrilhaNet.Models;

Pessoa pessoa = new Pessoa(nome: "Wandersson", sobrenome: "Dutra");
Pessoa pessoa1 = new Pessoa(nome: "Wandersson2", sobrenome: "Dutra");

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5);

Reserva reserva = new Reserva(diasReservados: 11);

List<Pessoa> hospedes = new List<Pessoa>();

hospedes.Add(pessoa);
hospedes.Add(pessoa1);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Tipo de suite: {reserva.Suite.TipoSuite} | Quantidade de hospedes: {reserva.ObterQauntidadeHospedes()} | Valor da hospedagem: {reserva.CalcularDiaria()}");