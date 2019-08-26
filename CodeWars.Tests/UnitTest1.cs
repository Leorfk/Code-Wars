using NUnit.Framework;
using CodeWars.View;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
        [Test]
        public void Test2()
        {
            double[] arr = { 80, 7, 2, 1, -10, 7, 3 };
            Assert.AreEqual(90, Kata.SumArray(arr));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(Kata.CountSheep(1), ("1 sheep..."));
            Assert.AreEqual(Kata.CountSheep(2), ("1 sheep...2 sheep..."));
            Assert.AreEqual(Kata.CountSheep(3), ("1 sheep...2 sheep...3 sheep..."));
        }
        [Test]
        public void Test4()
        {
            Assert.True(Kata.IsUpper("CCCCC"));
            Assert.False(Kata.IsUpper("cccccccIGGYIHIUGI"));
            Assert.False(Kata.IsUpper("Leonardo Rodrigues Ferreira"));
            Assert.True(Kata.IsUpper("LEONARDO RODRIGUES FERREIRA"));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(-1, Kata.Opposite(1));
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual("***", Kata.RepeatStr(3, "*"));
        }
        [Test]
        public static void CountBy1()
        {
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, Kata.CountBy(1, 5), "Array does not match");
        }

        [Test]
        public static void CountBy2()
        {
            Assert.AreEqual(new int[] { 2, 4, 6, 8, 10 }, Kata.CountBy(2, 5), "Array does not match");
        }
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("world! hello", Kata.ReverseWords("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", Kata.ReverseWords("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", Kata.ReverseWords("foobar"));
            Assert.AreEqual("kata editor", Kata.ReverseWords("editor kata"));
            Assert.AreEqual("boat your row row row", Kata.ReverseWords("row row row your boat"));
        }
        [Test]
        public void World()
        {
            Assert.AreEqual("dlrow", Kata.IsUltimasLetras("world"));
        }
        [Test]
        public void InverteNumeros()
        {
            Assert.AreEqual(new int[] { -1, -2, -3, -4, -5 }, Kata.InvertValues(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { -1, 2, -3, 4, -5 }, Kata.InvertValues(new int[] { 1, -2, 3, -4, 5 }));
            Assert.AreEqual(new int[] { }, Kata.InvertValues(new int[] { }));
            Assert.AreEqual(new int[] { 0 }, Kata.InvertValues(new int[] { 0 }));
        }
        [Test]
        public void PalavraMenor()
        {
            Assert.AreEqual(3, Kata.FindShort("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, Kata.FindShort("turns out random test cases are easier than writing out basic ones"));
        }
        [TestCase(213, 321)]
        [TestCase(7389, 9873)]
        [TestCase(63792, 97632)]
        [TestCase(566797, 977665)]
        [TestCase(1000000, 1000000)]
        public void NumeroMaximo(int input, int expected)
        {
            Assert.That(Kata.MaxNumber(input), Is.EqualTo(expected));
        }
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 2, ExpectedResult = new int[] { 2, 4, 6 })]
        public static int[] TesteDonumerosDivisiveis(int[] numbers, int divisor)
        {
            return Kata.DivisibleBy(numbers, divisor);
        }
        private static readonly object[] sampleTestCases = new object[]
        {
              new object[] {"samurai", "ai", true},
              new object[] {"sumo", "omo", false},
              new object[] {"ninja", "ja", true},
              new object[] {"sensei", "i", true},
              new object[] {"samurai", "ra", false},
              new object[] {"abc", "abcd", false},
              new object[] {"abc", "abc", true},
              new object[] {"abcabc", "bc", true},
              new object[] {"ails", "fails", false},
              new object[] {"fails", "ails", true},
              new object[] {"this", "fails", false},
              new object[] {"abc", "", true},
              new object[] {":-)", ":-(", false},
              new object[] {"!@#$%^&*() :-)", ":-)", true},
              new object[] {"abc\n", "abc", false},
        };
        [Test, TestCaseSource("sampleTestCases")]
        public void SampleTest(string str, string ending, bool expected)
        {
            Assert.AreEqual(expected, Kata.IsUltimasLetras(str, ending));
        }
        [Test]
        public void CacaPalavras()
        {
            Assert.AreEqual(1, Kata.SumOfABeach("SanD"));
            Assert.AreEqual(1, Kata.SumOfABeach("sunshine"));
            Assert.AreEqual(4, Kata.SumOfABeach("sunsunsunsun"));
            Assert.AreEqual(1, Kata.SumOfABeach("123FISH321"));
        }
        [Test]
        public static void StringTest1()
        {
            Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
        }

        [Test]
        public static void StringTest2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void StringTest3()
        {
            Assert.AreEqual("This is a test", Kata.SpinWords("This is a test"));
        }

        [Test]
        public static void StringTest4()
        {
            Assert.AreEqual("This is rehtona test", Kata.SpinWords("This is another test"));
        }

        [Test]
        public static void StringTest5()
        {
            Assert.AreEqual("You are tsomla to the last test", Kata.SpinWords("You are almost to the last test"));
        }
        [TestCase("code", "code")]
        [TestCase("CODe", "CODE")]
        [TestCase("COde", "code")]
        [TestCase("Code", "code")]
        public void BasicTests(string s, string expected)
        {
            Assert.That(Kata.Solve(s), Is.EqualTo(expected));
        }
        [Test]
        public void Seculos()
        {
            Assert.AreEqual(18, Kata.СenturyFromYear(1705));
            Assert.AreEqual(19, Kata.СenturyFromYear(1900));
            Assert.AreEqual(17, Kata.СenturyFromYear(1601));
            Assert.AreEqual(20, Kata.СenturyFromYear(2000));
        }
        [Test]
        public void Test00001()
        {
            var num = new int[] { 2, 3, 9 };
            var newNum = new int[] { 2, 4, 0 };
            Assert.AreEqual(newNum, Kata.UpArray(num));
        }

        [Test]
        public void Test00002()
        {
            var num = new int[] { 4, 3, 2, 5 };
            var newNum = new int[] { 4, 3, 2, 6 };
            Assert.AreEqual(newNum, Kata.UpArray(num));
        }
        [Test]
        public void BasicTestsReverse()
        {
            Assert.AreEqual("nahsirk", Kata.ReverseLetter("krishan"));
            Assert.AreEqual("nortlu", Kata.ReverseLetter("ultron"));
            Assert.AreEqual("cba", Kata.ReverseLetter("abc"));
            Assert.AreEqual("nahsirk", Kata.ReverseLetter("krishan"));
        }
        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", Kata.Disemvowel("This website is for losers LOL!"));
        }
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, Kata.ValidParentheses("()"));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(false, Kata.ValidParentheses(")(((("));
        }
        [Test]
        public void Sorrisos()
        {
            Assert.AreEqual(4, Kata.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }));
            Assert.AreEqual(2, Kata.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }));
            Assert.AreEqual(1, Kata.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
            Assert.AreEqual(0, Kata.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }));
        }
        private static void Testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void Letras()
        {
            Testing(Kata.Accum("ZpglnRxqenU"), "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu");
            Testing(Kata.Accum("NyffsGeyylB"), "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb");
            Testing(Kata.Accum("MjtkuBovqrU"), "M-Jj-Ttt-" +
                "Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu");
            Testing(Kata.Accum("EvidjUnokmM"), "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm");
            Testing(Kata.Accum("HbideVbxncC"), "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc");
        }
        [Test]
        public static void Test()
        {
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.AreEqual("3/56", Kata.PrinterError(s));
        }
        [Test, Description("It should return correct text")]
        public void Likes()
        {
            Assert.AreEqual("no one likes this", Kata.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", Kata.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", Kata.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", Kata.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
        [TestCase]
        public void BasicTest1()
        {
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            Assert.AreEqual(result, Kata.Wave("hello"), "it should return '" + result + "'");
        }
        [TestCase]
        public void BasicTest2()
        {
            List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
            Assert.AreEqual(result, Kata.Wave("codewars"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest3()
        {
            List<string> result = new List<string> { };
            Assert.AreEqual(result, Kata.Wave(""), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest4()
        {
            List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            Assert.AreEqual(result, Kata.Wave("two words"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest5()
        {
            List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
            Assert.AreEqual(result, Kata.Wave(" gap "), "it should return '" + result + "'");
        }
    }
}
