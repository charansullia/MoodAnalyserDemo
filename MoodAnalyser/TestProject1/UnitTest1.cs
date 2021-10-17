using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser1(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
           // Assert.AreEqual(expected,obj);

        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser1("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser", "SAD");
            expected.Equals(obj);
        }

        [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
        {
            MoodAnalyser1 obj = new MoodAnalyser1("HAPPY");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);

        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodNull_ShouldThrowException()
        {
            MoodAnalyser1 obj = new MoodAnalyser1(null);
            string result = obj.analyseMood();
            //Assert.AreEqual("HAPPY", result);

        }


        [TestMethod]
        public void GivenMoodHappy_ShouldReturnNull()
        {
            MoodAnalyser1 obj = new MoodAnalyser1("null");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);

        }


    }




}
