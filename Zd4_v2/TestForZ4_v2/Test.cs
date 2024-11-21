using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibForZd4_v2;
using System.IO;

namespace Testforzd4_v2
{
    [TestClass]
    public class Test
    {
       
        LibZd4_v2 ob1 = new  LibZd4_v2();
        
        [TestMethod]
        public void TestEmpty()//Проверка на Пустой текст
        {
            string provtxt = " ";
            string expected = "Недопустимая длинна"; //Ожидается
                string actual =ob1.Proverka(provtxt); // Фактически

            Assert.AreEqual(expected,actual);



        }
        [TestMethod]
        public void TestFileExist() //Проверка на существование файла
        {
            
            bool actual = ob1.FileExist(); //Фактически

            Assert.IsTrue(actual);



        }

        [TestMethod]
        public void TestMax() // Проверка на превышение длины строки
        {
            string provtxt = "ABCDEFGHIJKLMNOPQRSTUVWXYZQ"; // Текст
            string expected = "Недопустимая длинна"; // Ожидаемое
            string actual = ob1.Proverka(provtxt); // Фактическое

            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void TestRepeat()        //Проверка на повтор                                                              
        {
            string provtxt = "ABCDEFGHIJKLMNOPMQRSTUVW";     // Текст                               
            string expected = "Буква M повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void TestRepeat2()//Проверка на повтор
        {
            string provtxt = "AWWS";// Текст
            string expected = "Буква W повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }
       
        [TestMethod]
        public void TestRepeat4()//Проверка на повтор
        {
            string provtxt = "XXCW";// Текст
            string expected = "Буква X повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat5()//Проверка на повтор
        {
            string provtxt = "TRTF";// Текст
            string expected = "Буква T повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat6()//Проверка на повтор
        {
            string provtxt = "AAWE";// Текст
            string expected = "Буква A повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat7()//Проверка на повтор
        {
            string provtxt = "GGTRE";// Текст
            string expected = "Буква G повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat8()//Проверка на повтор
        {
            string provtxt = "IJJV";// Текст
            string expected = "Буква J повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat9()//Проверка на повтор
        {
            string provtxt = "WVVI";// Текст
            string expected = "Буква V повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat10()//Проверка на повтор
        {
            string provtxt = "ZZ";// Текст
            string expected = "Буква Z повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat11()//Проверка на повтор
        {
            string provtxt = "FUYYC";// Текст
            string expected = "Буква Y повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat12()//Проверка на повтор
        {
            string provtxt = "GOOL";// Текст
            string expected = "Буква O повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat13()//Проверка на повтор
        {
            string provtxt = "LLP";// Текст
            string expected = "Буква L повторяется несколько раз";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void TestGood()//Проверка на хороший результат
        {
            string provtxt = "FULAW";// Текст
            string expected = "AWFUL";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGood2()//Проверка на хороший результат
        {
            string provtxt = "UTBR";// Текст
            string expected = "BRUT";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGood3()//Проверка на хороший результат
        {
            string provtxt = "Fyubelw";// Текст
            string expected = "BELWFYU";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGood4()//Проверка на хороший результат
        {
            string provtxt = "FYUBELW";// Текст
            string expected = "BELWFYU";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGood5()//Проверка на хороший результат
        {
            string provtxt = "IEMCR";// Текст
            string expected = "CRIEM";// Ожидаемое
            string actual = ob1.Proverka(provtxt);// Фактическое

            Assert.AreEqual(expected, actual);
        }
    }
}
