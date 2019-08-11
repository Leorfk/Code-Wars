using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars.View
{
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            int maior = 0;
            int menor = 0;

            string[] numeros = numbers.Split(" ");

            for (int i = 0; i < numeros.Length; i++)
            {
                if (maior < int.Parse(numeros[i]))
                {
                    maior = int.Parse(numeros[i]);
                }
                if (menor > int.Parse(numeros[i]))
                {
                    menor = int.Parse(numeros[i]);
                }
            }
            return maior + " " + menor;
            //var parsed = numbers.Split().Select(int.Parse);
            //return parsed.Max() + " " + parsed.Min();
        }
        public static double SumArray(double[] array)
        {
            double somador = 0;
            for (int i = 0; i < array.Length; i++)
            {
                somador += array[i];
            }
            return somador;
        }
        public static string CountSheep(int n)
        {
            string ovelhas = "";
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    ovelhas += $"{i+1} sheep...";
                }
            }
            else
            {
                throw new ArgumentException();
            }
            return ovelhas;
        }
        public static bool IsUpper(string frase)
        {
            Regex pattern = new Regex(@"^[ [A-Z]{1,}$", RegexOptions.None);
            if (pattern.IsMatch(frase))
            {
                return true;
            }
                return false;
        }
        public static int Opposite(int number)
        {
            if (number > 0)
            {
                return int.Parse("-" + number.ToString());
            }
            else
            {
                return int.Parse(number.ToString().Replace("-", ""));
            }
        }
        public static string RepeatStr(int n, string s)
        {
            string aux = "";
            for (int i = 0; i < n; i++)
            {
                aux += s;
            }
            return aux;
        }
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];
            for (int i = 0; i < n; i++)
            {
                z[i] = x * (i + 1);
                Console.WriteLine(z[i]);
            }
            return z;
        }
        public static string ReverseWords(string str)
        {
            string[] lista = str.Split(" ");
            string fraseReversa = "";
            int indiceReferencia = lista.Length;
            for (int i = lista.Length; i > 0; i--)
            {
                if (i == indiceReferencia)
                {
                    fraseReversa += lista[i - 1];
                }
                else
                {
                    fraseReversa += " " + lista[i - 1];
                }
            }
            return fraseReversa;
        }
        public static string IsUltimasLetras(string str)
        {
            string textoInvertido = new string(str.Reverse().ToArray());
            return textoInvertido;
        }
        public static int[] InvertValues(int[] input)
        {
            int[] numerosContrarios = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                numerosContrarios[i] = input[i] - input[i] * 2;
                Console.WriteLine("Contra: " + numerosContrarios[i]);
                Console.WriteLine("Input: " + input[i]);
            }
            return numerosContrarios;
        }
        public static int FindShort(string s)
        {
            string[] listaPalavras = s.Split(' ');
            int menorPalavra = listaPalavras[0].Length;
            for (int i = 1; i < listaPalavras.Length; i++)
            {
                if (menorPalavra > listaPalavras[i].Length)
                {
                    menorPalavra = listaPalavras[i].Length;
                }
            }
            return menorPalavra;
        }
        public static int MaxNumber(int n)
        {
            string lista = n.ToString();
            char[] listaNumerica = new char[lista.Length];
            for (int i = 0; i < lista.Length; i++)
            {
                listaNumerica[i] = char.Parse(lista[i].ToString());
            }
            Array.Sort(listaNumerica);
            Array.Reverse(listaNumerica);
            string resultado = "";
            for (int i = 0; i < listaNumerica.Length; i++)
            {
                resultado += listaNumerica[i].ToString();
            }
            return int.Parse(resultado);
        }
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            List<int> numerosDivisiveis = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % divisor == 0)
                {
                    numerosDivisiveis.Add(numbers[i]);
                }
            }
            int[] resultado = new int[numerosDivisiveis.Count];
            for (int i = 0; i < resultado.Length; i++)
            {
                resultado[i] = numerosDivisiveis[i];
            }
            return resultado;
        }
        public static bool IsUltimasLetras(string str, string ending)
        {
            if (ending.Length > str.Length)
            {
                return false;
            }
            if (str.Substring(str.Length - ending.Length) == ending)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int SumOfABeach(string s)
        {
            Regex pattern = new Regex(@"sand|water|fish|sun", RegexOptions.IgnoreCase);
            var c = pattern.Split(s);
            return c.Length - 1;
        }
        public static string SpinWords(string sentence)
        {
            string[] formatacao = sentence.Split(" ");
            string novaFrase = "";
            for(int i = 0; i < formatacao.Length; i++)
            {
                if (formatacao[i].Length >= 5)
                {
                    string temp = new string(formatacao[i].Reverse().ToArray()) + " ";
                    novaFrase += temp;
                }
                else
                {
                    novaFrase += formatacao[i] + " "; 
                }
            }
            return novaFrase.TrimEnd(' ');
        }
    }
}

