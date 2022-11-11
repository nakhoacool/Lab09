using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void ScoreIs9_GradeExpectedIsA()
        {
            Student s = new Student();
            s.Score = 9.0;
            char grade = s.getLetterScore();
            Assert.AreEqual('A', grade);
        }

        [TestMethod]
        public void ScoreIs7_GradeExpectedIsB()
        {
            Student s = new Student();
            s.Score = 7.0;
            char grade = s.getLetterScore();
            Assert.AreEqual('B', grade);
        }

        [TestMethod]
        public void ScoreIs6_GradeExpectedIsC()
        {
            Student s = new Student();
            s.Score = 6.0;
            char grade = s.getLetterScore();
            Assert.AreEqual('C', grade);
        }

        [TestMethod]
        public void ScoreIs4_GradeExpectedIsD()
        {
            Student s = new Student();
            s.Score = 4.0;
            char grade = s.getLetterScore();
            Assert.AreEqual('D', grade);
        }

        [TestMethod]
        public void ScoreIs2_GradeExpectedIsE()
        {
            Student s = new Student();
            s.Score = 2.0;
            char grade = s.getLetterScore();
            Assert.AreEqual('E', grade);
        }

        [TestMethod]
        public void ScoreIs11_ReturnException()
        {
            String expectedMessage = "Score must not exeed 10.0";
            String message = null;
            Student s = new Student();
            try {
                s.Score = 11.0;
            }
            catch(Exception ex)
            {
                message = ex.Message;
            }
            Assert.AreEqual(expectedMessage, message);
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void ScoreIsMinus5_ReturnException()
        {
            String expectedMessage = "Score must not exeed 10.0";
            String message = null;
            Student s = new Student();
            s.Score = -5;
        }

        [TestMethod]
        public void ScoreIs5_ReturnNoException()
        {
            String expectedMessage = null;
            String message = null;
            Student s = new Student();
            try
            {
                s.Score = 5.0;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            Assert.AreEqual(expectedMessage, message);
        }
    }
}