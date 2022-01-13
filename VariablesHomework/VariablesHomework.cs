using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VariablesHomework
{
    [TestClass]
    public class Variables
    {
        [TestMethod]
        public void Declaration()
        {
            int number = 25;
            Assert.IsTrue(number == 25); // Make this pass

            bool boolean = true;
            Assert.IsTrue(boolean == true); // Make this pass

            double decimalValue = 99.9;
            Assert.IsTrue(decimalValue == 99.9); // Make this pass

            float floatingDecimalValue = 25.4f;
            Assert.IsTrue(floatingDecimalValue == 25.4f); // Make this pass

            string words = "I am a programmer now";
            Assert.IsTrue(words == "I am a programmer now"); // Make this pass

            char character = 'z';
            Assert.IsTrue(character == 'z'); // Make this pass
        }

        [TestMethod]
        public void Assignment()
        {
            int t = 25;
            Assert.IsTrue(t == 25); // Make this pass

            int y = 100;
            Assert.IsTrue(y == 100); // Then make this pass

            float f = 3.5f;
            Assert.IsTrue(f == 3.5f); // Make this pass

            f = 99.9f;
            Assert.IsTrue(f == 99.9f); // Then make this pass

            bool b = false;
            Assert.IsTrue(b == false); // Make this pass

            b = false;
            Assert.IsTrue(b == false); // Then make this pass

            double d = 10.0;
            Assert.IsTrue(d == 10.0); // Make this pass

            double x = 20.0;
            Assert.IsTrue(x == 20.0); // Then make this pass


            string s = "word";
            Assert.IsTrue(s == "word"); // Make this pass

            string p = "next";
            Assert.IsTrue(p == "next"); // Then make this pass

            char c = 'a';
            Assert.IsTrue(c == 'a'); // Make this pass

            char g = 'c';
            Assert.IsTrue(g == 'c'); // Then make this pass

            int z = y;
            Assert.IsTrue(z == 100); // Make this pass
        }

        // Refer to this if you need help https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators
        [TestMethod]
        public void Operators()
        {
            int a = 0;
            int b = a + 13; 
            Assert.IsTrue(b == 13); // Make this pass

            float f = 12.3f;
            float c = f - 7.43f;
            Assert.IsTrue(c == 4.8700004f); // Make this pass
            Assert.IsTrue(f == 12.3f); // Make this pass

            bool d = false;
            bool e = !d;
            Assert.IsTrue(e == true); // Make this pass

            int anotherInt = 12;
            int g = -anotherInt; 
            Assert.IsTrue(g == -12); // Make this pass

            int yetAnotherInt = 23456;
            int t = yetAnotherInt * 3;
            Assert.IsTrue(t == 70368); // Make this pass

            int z = 23456;
            z *= 3;
            Assert.IsTrue(z == 70368); // Make this pass

            int h = 23;
            h++;
            Assert.IsTrue(h == 24); // Make this pass

            h--;
            Assert.IsTrue(h == 23); // Make this pass

            ++h;
            Assert.IsTrue(h == 24); // Make this pass

            --h;
            Assert.IsTrue(h == 23); // Make this pass
            h += 1;
            Assert.IsTrue(h == 24); // Make this pass
            h -= 1;
            Assert.IsTrue(h == 23); // Make this pass

            string l = "Hello! ";
            string m = l + "You!";
            Assert.IsTrue(m == "Hello! You!"); // Make this pass

            int v = 5;
            int x = v % 4;
            Assert.IsTrue(x == 1); // Make this pass

            int finalInt = 15;
            int divisionResult = 15 / 3;
            Assert.IsTrue(divisionResult == 5); // Make this pass

            finalInt = 15;
            finalInt /= 3;
            Assert.IsTrue(finalInt == 5); // Make this pass

            int orderOfOperations = 2;
            orderOfOperations = 2 + 12 * (orderOfOperations * 3);
            Assert.IsTrue(orderOfOperations == 74); // Make this pass
        }

        [TestMethod]
        public void Ranges()
        {
            Assert.IsTrue(int.MaxValue == 2147483647/*Answer here*/); // Make this pass
            Assert.IsTrue(int.MinValue == -2147483648/*Answer here*/); // Make this pass
            Assert.IsTrue(float.MaxValue == 3.4028235E+38f/*Answer here*/); // Make this pass
            Assert.IsTrue(float.MinValue == -3.4028235E+38f/*Answer here*/); // Make this pass
            Assert.IsTrue(double.MaxValue == 1.7976931348623158E+308/*Answer here*/); // Make this pass
            Assert.IsTrue(double.MinValue == -1.7976931348623158E+308/*Answer here*/); // Make this pass
        }

        [TestMethod]
        public void Overflow()
        {
            unchecked // ignore this, it simple means im telling the compiler i know what I am doing.
            {
                Assert.IsTrue(int.MaxValue + 1 == int.MinValue/*Answer here*/); // Make this pass
                Assert.IsTrue(int.MinValue - 1 == int.MaxValue/*Answer here*/); // Make this pass
                Assert.IsTrue(float.MaxValue + 1 == float.MaxValue/*Answer here*/); // Make this pass
                Assert.IsTrue(float.MinValue - 1 == float.MinValue/*Answer here*/); // Make this pass
                Assert.IsTrue(double.MaxValue + 1 == double.MaxValue/*Answer here*/); // Make this pass
                Assert.IsTrue(double.MinValue - 1 == double.MinValue/*Answer here*/); // Make this pass
            }
        }

        [TestMethod]
        public void Conversion()
        {
            int i = 13;
            double d = i;
            Assert.IsTrue(d == 13/*Answer here*/); // Make this pass

            // Why does that compile andwork but this doesnt?
            // double d = 15.5;
            // int c = d;
        }

        [TestMethod]
        public void Casting()
        {
            // what am i doing here that make the above work?
            double d = 15.5;
            int c = (int)d;
            Assert.IsTrue(c == 15/*Answer here*/); // Make this pass

            string e = d.ToString();
            Assert.IsTrue(e == "15.5"); // Make this pass
        }

        [TestMethod]
        public void Parsing()
        {
            string a = "67";
            int b = int.Parse(a);
            Assert.IsTrue(b == 67); // Make this pass
        }
    }
}
