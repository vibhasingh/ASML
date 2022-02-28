// (C) ASML 2022 Submitted for Interview assignment

using NUnit.Framework;

namespace ASML.InterviewTest.UnitTest
{
    [TestFixture]
    public class SequenceAnalysisTest
    {
        [SetUp]
        public void SetUp()
        {
            _sequenceAnalysis = new SequenceAnalysis.SequenceAnalysis();
        }

        private SequenceAnalysis.SequenceAnalysis _sequenceAnalysis;

        [TestCase("This IS a STRING", "GIINRSST")]
        [TestCase("India is a COUNTRY", "CNORTUY")]
        [TestCase("ASML Eindhoven", "ALMS")]
        [TestCase("I am AN ENGINEER", "AEEEGIINNNR")]
        [TestCase("I am DEVELOPER", "DEEEILOPRV")]
        [TestCase("C# is a POWERFUL language", "CEFLOPRUW")]
        [TestCase("This 122 4541 845 2is WITCHER", "CEHIRTW")]
        [TestCase("", "")]
        [TestCase("Workstation 5", "")]
        [TestCase("winDows UNIVERSAL platform", "AEILNRSUV")]
        [TestCase("123 456 789 123 456 78910", "")]
        [TestCase("IPAD is a good Device", "ADIP")]
        [TestCase("AM A HAPPY person", "AAAHMPPY")]
        [TestCase("Software '~***/DEVELOPMENT!!", "DEEELMNOPTV")]
        public void Given_An_InputStatement_Then_AllUpperCaseWordsAreSorted(string statement, string upperCaseString)
        {
            Assert.AreEqual(upperCaseString, _sequenceAnalysis.ExecuteAlgorithm(statement));
        }

        [TestCase("This is a simple english sentence without any capital lettered words.", "")]
        public void Given_An_InvalidInputStatement_WithNoCapital_Then_Empty_Is_Returned(string statement,
            string upperCaseString)
        {
            Assert.AreEqual(upperCaseString, _sequenceAnalysis.ExecuteAlgorithm(statement));
        }
    }
}