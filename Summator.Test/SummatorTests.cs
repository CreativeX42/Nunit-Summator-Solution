using NUnit.Framework;

namespace Summator.Test
{
    public class SummatorTests

    {
        [Test]
       public void Test_TwoPossitiveNumbers()
        {
            int expected = Summator.Sum(new int[] { 5, 7 });

            int actual = 12;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            int result = Summator.Sum(new int[] { 5 });
            Assert.That(result == 5);
        }
        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            int expected = Summator.Sum(new int[] { -7,-9, });
            Assert.That(expected == -16);
        }
        [Test]
        public void Test_Sum_TwoNegativeZero()
        {
            int expected = Summator.Sum(new int[] { 0,0, });
            Assert.That(expected == 0);
        }
        [Test]
        public void Test_Sum_bigValues()
        {
            int expected = Summator.Sum(new int[] { 200000000, 200000000, 200000000 });
            Assert.AreEqual(expected, 600000000);
        }
       
    }

}