using System.Collections.Generic;

namespace NumerosRomanos
{
    public class Conversor
    {
        private Dictionary<int, string> arabicosConflitantes = new Dictionary<int, string>
        {
            {1,"I"},
            {4,"IV"},
            {5,"V"},
            {9,"IX"},
            {10,"X"},
            {40,"XL"},
            {50,"L"},
            {90,"XC"},
            {100,"C"},
            {400,"CD"},
            {500,"D"},
            {900,"CM"},
            {1000,"M"}
        };

        private List<int> inteirosConflitantes = new List<int>
        {
            1,4,5,9,10,40,50,90,100,400,500,900,1000
        };

        private Dictionary<char, int> algarisomosRomanos = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int ConverterRomanoParaArabico(string valor)
        {
            var resultado = 0;

            var romanos = valor.ToUpper().ToCharArray();

            for (int i = 0; i <= romanos.Length - 1; i++)
            {
                if (i == romanos.Length - 1)
                {
                    resultado += algarisomosRomanos[romanos[i]];
                    return resultado;
                }

                var romanoAtual = algarisomosRomanos[romanos[i]];

                var proximoRomano = i + 1;
                var next = algarisomosRomanos[romanos[proximoRomano]];

                if (romanoAtual < next)
                    resultado -= romanoAtual;

                if (romanoAtual >= next)
                    resultado += romanoAtual;
            }
            return resultado;
        }

        public string ConverterArabicoParaRomano(int valor)
        {
            string resultadoRomano = "";

            if (valor < 0 || valor >= 4000)
                return "VALOR INVÁLIDO";

            int contador = inteirosConflitantes.Count;

            while (valor > 0)
            {
                while (valor / inteirosConflitantes[contador - 1] >= 1)
                {
                    int resultadoAgora = inteirosConflitantes[contador - 1];
                    valor -= resultadoAgora;
                    resultadoRomano += arabicosConflitantes[resultadoAgora];
                    contador = inteirosConflitantes.Count;
                }
                contador--;
            }
            return resultadoRomano;
        }
    }
}
