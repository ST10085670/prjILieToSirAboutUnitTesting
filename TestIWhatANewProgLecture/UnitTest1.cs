using prjILieToSirAboutUnitTesting;

namespace TestIWhatANewProgLecture
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestgetName()
        {
            DOWhatEver doWhat = new DOWhatEver();
            string Actual = doWhat.getName();
            string Expected = "Aphiwe";
            Assert.AreEqual(Expected, Actual);
         }
        [TestMethod]
        public void TestgetDate()
        {
        DOWhatEver dOWhat = new DOWhatEver();
            string Actual = dOWhat.getDate();
            string Expected = "2001/12/27";
            Assert.AreEqual (Expected, Actual);
        }
        [TestMethod]
        public void TestgetEmail()
        {
            DOWhatEver dOWhat = new DOWhatEver();
            string Actual = dOWhat.getEmail();
            string Expected = "aphiwe@gmail.com";
            Assert.AreEqual(Expected, Actual);

        }
    }
}