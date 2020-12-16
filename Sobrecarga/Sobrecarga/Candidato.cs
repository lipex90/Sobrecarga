using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrecarga
{
    class Candidato
    {
        
        public string Ficha { get; set; }
        public string Partido { get; set; }
        public double Patrimonio { get; set; }
        public string Profissao { get; set; }
        public string Cargo { get; set; }
        public string Municipio { get; set; }
        public string Nome { get; set; }

        public Candidato()
        {

        }

        public Candidato(string ficha, string partido, double patrimonio,
            string profissao, string cargo, string municipio,string nome )
        {
            Ficha = ficha;
            Partido = partido;
            Patrimonio = patrimonio;
            Profissao = profissao;
            Cargo = cargo;
            Municipio = municipio;
            Nome = nome;
        }
    }
}
