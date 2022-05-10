using CursoDesignPatterns_Alura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_Alura
{
    public class CalculadorDeImpostos
    {
        // ANTIGO 
        //public void RealizaCalculo(Orcamento orcamento, string imposto)
        //{
        //    if ("ICMS".Equals(imposto))
        //    {
        //        double icms = new ICMS().CalculaICMS(orcamento);
        //        Console.WriteLine(icms);
        //    }
        //    else if ("ISS".Equals(imposto))
        //    {
        //        double iss = new ISS().CalculaISS(orcamento);
        //        Console.WriteLine(iss);
        //    }
        //}

        //APLICANDO CORRECAO
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
