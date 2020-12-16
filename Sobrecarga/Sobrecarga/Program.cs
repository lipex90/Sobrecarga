using System;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidato municipio = new Candidato();
            Candidato cargo = new Candidato();
            Candidato profissao = new Candidato();
            Candidato patrimonio = new Candidato();
            Candidato partido = new Candidato();
            Candidato ficha = new Candidato();
            Candidato nome = new Candidato();
            
            Console.WriteLine("Digite o nome do candidato ");
            nome.Nome = Console.ReadLine();
            Console.WriteLine("Digite o lugar Município");
            municipio.Municipio = Console.ReadLine();
            Console.WriteLine("Qual tipo de partido você é ?");
            partido.Partido = Console.ReadLine();
            Console.WriteLine("Por favor informe seu salário do patrimônio.");
            patrimonio.Patrimonio = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor qual é a sua profissão?");
            profissao.Profissao = Console.ReadLine();
            Console.WriteLine("Sua ficha está limpa ?");
            ficha.Ficha = Console.ReadLine();
            Console.Clear();
            if (ficha.Ficha == "Sim" || ficha.Ficha == "SIM "
                || ficha.Ficha == "s"|| ficha.Ficha == "sim")
            {
                Console.WriteLine("Candidato "+nome.Nome+" cadastrado com Sucesso!");
                Console.WriteLine("Dados para conferência:");
                Console.WriteLine("Candidato a prefeito de "+municipio.Municipio);
                Console.WriteLine("Nome: "+nome.Nome);
                Console.WriteLine("Partido: "+partido.Partido);
                Console.WriteLine("Patrimônio declarado: "+patrimonio.Patrimonio);
                Console.WriteLine("Profissão: "+profissao);
                ficha.Ficha = "sim";
                Console.WriteLine("Ficha limpa: "+ficha.Ficha);

            }
            else if ((ficha.Ficha == "Não" || ficha.Ficha == "nao"
                || ficha.Ficha == "n" || ficha.Ficha == "NAO"))
                 {
                Console.WriteLine("Candidato" + nome.Nome + "cadastrado com Sucesso!");
                Console.WriteLine("Dados para conferência:");
                Console.WriteLine("Candidato a prefeito de " + municipio.Municipio);
                Console.WriteLine("Nome: " + nome.Nome);
                Console.WriteLine("Partido: " + partido.Partido);
                Console.WriteLine("Patrimônio declarado: " + patrimonio.Patrimonio);
                Console.WriteLine("Profissão: " + profissao);
                ficha.Ficha = "não";
                Console.WriteLine("Ficha limpa: " + ficha.Ficha);
                 }

        }
    }
}
