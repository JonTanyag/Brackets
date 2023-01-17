using System;
using MatchingBrackets;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace MatchingBraces.UnitTest
{
    public class TestBrackets
    {

        [TestCase("{hello} world{}", true)]
        [TestCase("{hello{ world}", false)]
        [TestCase("{hello}} world{}", false)]
        [TestCase("", true)]
        public void TestCheckMatchingBrackets(string input, bool expected)
        {
            BracketsService service = new BracketsService();
            bool result = service.CheckMatchingBrackets(input);
            Assert.AreEqual(expected, result);
        }

    }
}

