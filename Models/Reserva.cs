using System;
using System.Xml.Serialization;

namespace TrilhaNet.Models
{
    public class Reserva
    {
        
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        List<Pessoa> Hospedes = new List<Pessoa>();

        public Suite Suite { get; set; }

        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Hospedes.Count > Suite.Capacidade)
                throw new ArgumentOutOfRangeException("A quantidade de hospedes excede a capacidade da suite.");
            foreach(Pessoa hospede in hospedes)
                Hospedes.Add(hospede);
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQauntidadeHospedes()
        {
            return Hospedes.Count;
        }
        
        public decimal CalcularDiaria()
        {
            decimal desconto = 0;
            if (DiasReservados > 10)
                desconto = DiasReservados * Suite.ValorDiaria / (100/10);

            return DiasReservados * Suite.ValorDiaria - desconto;
        }
    }
}