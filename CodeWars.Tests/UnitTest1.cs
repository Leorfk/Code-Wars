using NUnit.Framework;
using CodeWars.View;
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
        private static object[] sampleTestCases = new object[]
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

        [Test]
        public static void StringTest6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Kata.SpinWords("Just kidding there is still one more"));
        }
    }
}