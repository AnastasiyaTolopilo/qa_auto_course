using _03_CandidateConstructor;

namespace _04_University_UnitTests
{
    [TestClass]
    public class CourseUnitTest
    {
        [TestMethod]
        public void CheckCourseIsEquelPositive()
        {
            Course courseMath1 = new("Mathematics", "Basics of algebra and geometry");
            Course courseMath2 = new("Mathematics", "Basics of algebra and geometry");

            Assert.IsTrue(courseMath1.Equals(courseMath2));
        }

        [TestMethod]
        public void CheckCourseIsEquelNegative()
        {
            Course courseMath = new("Mathematics", "Basics of algebra and geometry");
            Course coursePhysics = new("Physics", "Study of the properties and phenomena of inanimate nature");

            Assert.IsFalse(courseMath.Equals(coursePhysics));
        }
    }
}