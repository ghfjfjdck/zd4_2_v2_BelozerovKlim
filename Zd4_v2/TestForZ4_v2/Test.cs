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
        public void TestEmpty()//�������� �� ������ �����
        {
            string provtxt = " ";
            string expected = "������������ ������"; //���������
                string actual =ob1.Proverka(provtxt); // ����������

            Assert.AreEqual(expected,actual);



        }
        [TestMethod]
        public void TestFileExist() //�������� �� ������������� �����
        {
            
            bool actual = ob1.FileExist(); //����������

            Assert.IsTrue(actual);



        }

        [TestMethod]
        public void TestMax() // �������� �� ���������� ����� ������
        {
            string provtxt = "ABCDEFGHIJKLMNOPQRSTUVWXYZQ"; // �����
            string expected = "������������ ������"; // ���������
            string actual = ob1.Proverka(provtxt); // �����������

            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void TestRepeat()        //�������� �� ������                                                              
        {
            string provtxt = "ABCDEFGHIJKLMNOPMQRSTUVW";     // �����                               
            string expected = "����� M ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void TestRepeat2()//�������� �� ������
        {
            string provtxt = "AWWS";// �����
            string expected = "����� W ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }
       
        [TestMethod]
        public void TestRepeat4()//�������� �� ������
        {
            string provtxt = "XXCW";// �����
            string expected = "����� X ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat5()//�������� �� ������
        {
            string provtxt = "TRTF";// �����
            string expected = "����� T ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat6()//�������� �� ������
        {
            string provtxt = "AAWE";// �����
            string expected = "����� A ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat7()//�������� �� ������
        {
            string provtxt = "GGTRE";// �����
            string expected = "����� G ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat8()//�������� �� ������
        {
            string provtxt = "IJJV";// �����
            string expected = "����� J ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat9()//�������� �� ������
        {
            string provtxt = "WVVI";// �����
            string expected = "����� V ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat10()//�������� �� ������
        {
            string provtxt = "ZZ";// �����
            string expected = "����� Z ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat11()//�������� �� ������
        {
            string provtxt = "FUYYC";// �����
            string expected = "����� Y ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat12()//�������� �� ������
        {
            string provtxt = "GOOL";// �����
            string expected = "����� O ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void TestRepeat13()//�������� �� ������
        {
            string provtxt = "LLP";// �����
            string expected = "����� L ����������� ��������� ���";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void TestGood()//�������� �� ������� ���������
        {
            string provtxt = "FULAW";// �����
            string expected = "AWFUL";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGood2()//�������� �� ������� ���������
        {
            string provtxt = "UTBR";// �����
            string expected = "BRUT";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGood3()//�������� �� ������� ���������
        {
            string provtxt = "Fyubelw";// �����
            string expected = "BELWFYU";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGood4()//�������� �� ������� ���������
        {
            string provtxt = "FYUBELW";// �����
            string expected = "BELWFYU";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGood5()//�������� �� ������� ���������
        {
            string provtxt = "IEMCR";// �����
            string expected = "CRIEM";// ���������
            string actual = ob1.Proverka(provtxt);// �����������

            Assert.AreEqual(expected, actual);
        }
    }
}
