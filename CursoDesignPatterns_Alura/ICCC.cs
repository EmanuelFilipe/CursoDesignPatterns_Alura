using CursoDesignPatterns_Alura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_Alura
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double valor = 0.0;

            if (orcamento.Valor < 1000.0)
                valor = orcamento.Valor * 0.05;
            else if (orcamento.Valor > 1000.0 && orcamento.Valor < 3000.0)
                valor = orcamento.Valor * 0.07;
            else
                valor = orcamento.Valor * 0.08 + 30.0;

            return valor;
        }
    }
}
