using System.Collections.Generic;
using _02TDDKarateChop;
using NUnit.Framework;

namespace KarateTests
{
    [TestFixture]

    public class KarateTests
    {
        // private readonly List<int> SortedListArray = new List<int> { };

        // test case Chop(3, []) --> -1
        // 3 is inToFind, arrayofIntsIsEmpty, -1 is answer
        [TestCase(3, -1)]

        public void KarateTest_GivenIntAndListOfInts_ReturnIndex(int intToFind, List<int> arrayOfInts)
        {
            KarateChopper tester = new KarateChopper();

            int expected = -1;
            int actual = tester.Chop(intToFind, arrayOfInts);

            Assert.IsTrue(expected == actual);

        }



    }
}
