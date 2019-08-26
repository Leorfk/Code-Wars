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
                    ovelhas += $"{i + 1} sheep...";
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
            for (int i = 0; i < formatacao.Length; i++)
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
        public static string Solve(string s)
        {
            int verificador = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (IsUpper(s[i].ToString()))
                {
                    verificador -= 1;
                }
                else
                {
                    verificador += 1;
                }
            }
            if (verificador == 0 || verificador > 0)
            {
                return s.ToLower();
            }
            else
            {
                return s.ToUpper();
            }

        }
        public static string BreakCamelCase(string str)
        {
            string separadas = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == str[i].ToString().ToUpper())
                {
                    separadas += " " + str[i];
                }
                else
                {
                    separadas += str[i];
                }
            }
            Console.WriteLine(separadas);
            return separadas;
        }
        public static int СenturyFromYear(int year)
        {
            if (year % 100 > 0)
            {
                return 1 + (year / 100);
            }
            return year / 100;
        }
        public static int[] UpArray(int[] num)
        {
            if (num == null || num[0] == 0)
            {
                throw new ArgumentException();
            }
            string numero = "";
            for (int i = 0; i < num.Length; i++)
            {
                numero += num[i];
            }
            int numeroInteiro = 1 + int.Parse(numero);
            string n = numeroInteiro.ToString();
            int[] novoNumero = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
            {
                novoNumero[i] = int.Parse(n[i].ToString());
                Console.WriteLine(novoNumero[i] + "---" + numeroInteiro.ToString()[i]);
            }
            return novoNumero;
        }
        public static string ReverseLetter(string str)
        {
            return new string(str.Reverse().ToArray());
        }
        public static string Disemvowel(string str)
        {
            return str.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "").Replace("O", "");
        }
        public static bool ValidParentheses(string input)
        {
            if (input.Length == 0 || input[0] == ')' || input[input.Length - 1] == '(')
            {
                return false;
            }
            else if (input[0] == '(' && input[input.Length - 1] == ')')
            {
                int contador = 0;
                foreach (char parentese in input)
                {
                    if (parentese == '(')
                    {
                        contador += 1;
                    }
                    if (parentese == ')')
                    {
                        contador -= 1;
                    }
                }
                if (contador == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static int CountSmileys(string[] smileys)
        {
            return smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
        }
        public static String Accum(string s)
        {
            s = s.ToUpper();
            string final = s[0].ToString();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j == 0)
                    {
                        final += "-" + s[i];
                    }
                    final += s[i].ToString().ToLower();
                }
            }
            return final;
        }
        public static string PrinterError(String s)
        {
            int contador = 0;
            Regex pattern = new Regex(@"[n-z]", RegexOptions.IgnoreCase);
            foreach (char cor in s)
            {
                if (pattern.IsMatch(cor.ToString()))
                {
                    contador += 1;
                }
            }
            return contador + "/" + s.Length;
        }
        public static string Likes(string[] name)
        {
            if (name.Length == 0)
            {
                return "no one likes this";
            }
            else if (name.Length == 1)
            {
                return $"{name[0]} likes this";
            }
            else if (name.Length == 2)
            {
                return $"{name[0]} and {name[1]} like this";
            }
            else if (name.Length == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            else if (name.Length > 3)
            {
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
            return "";
        }
        public static List<string> Wave(string str)
        {
            char letra = ' ';
            StringBuilder sb = new StringBuilder(str);
            List<string> boludo = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                letra = char.Parse(str[i].ToString().ToUpper());
                boludo.Add(str.Replace(str[i], letra));
            }
            foreach (string palavra in boludo)
            {
                Console.WriteLine(palavra);
            }
            return boludo;
        }
    }
}