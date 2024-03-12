using System;

namespace TrilhaNet.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade)
        {
            if(tipoSuite == "Premium")
            ValorDiaria = 30;
            else if(tipoSuite == "Normal")
            ValorDiaria = 20;
            else if(tipoSuite == "Baixo preço")
            ValorDiaria = 10;
            
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
        }

        public string TipoSuite { get; set; }

        public int Capacidade { get; set; }

        public int ValorDiaria { get; set; }
    }
}