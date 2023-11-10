using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> listaHistorico;

        public CalculadoraImp()
        {
            listaHistorico = new List<string>();
        }

        public int Somar (int val1, int val2)
        {
            int resultado = val1 + val2;

            listaHistorico.Insert(0, $"{val1} + {val2} = {resultado}");

            return resultado;
        }

        public int Subtrair (int val1, int val2)
        {
            int resultado = val1 - val2;

            listaHistorico.Insert(0, $"{val1} - {val2} = {resultado}");

            return resultado;
        }

        public int Multiplicar (int val1, int val2)
        {
            int resultado = val1 * val2;

            listaHistorico.Insert(0, $"{val1} * {val2} = {resultado}");

            return resultado;
        }

        public int Dividir (int val1, int val2)
        {
            int resultado = val1 / val2;

            listaHistorico.Insert(0, $"{val1} / {val2} = {resultado}");

            return resultado;
        }

        public List<string> Historico ()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}