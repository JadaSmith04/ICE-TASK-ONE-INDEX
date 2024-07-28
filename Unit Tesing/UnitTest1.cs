using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ice_Task_1__Linked_lists;

namespace Unit_Tesing
{
    [TestClass]
    public class StudentTests
    {
        private Student student;

        [TestInitialize]
        public void SetUp()
        {
            student = new Student("ST10040040", "Jada", "Computer Science");
        }

        [TestMethod]
        public void Test_GetStudentNumber()
        {
            
            string expected = "ST10040040";

            
            string actual = (string)student["studentnumber"];

            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetStudentName()
        {
            
            string expected = "Jada";

            
            string actual = (string)student["studentname"];

           
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetStudentCourse()
        {
            
            string expected = "Computer Science";

            
            string actual = (string)student["studentcourse"];

          
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetStudentName()
        {
        
            string expected = "Charlene";

            
            student["studentname"] = expected;
            string actual = (string)student["studentname"];

            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetStudentCourse()
        {
            
            string expected = "Teacher Intermediate phase";

           
            student["studentcourse"] = expected;
            string actual = (string)student["studentcourse"];

            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStudentNumber()
        {
            Student stud = new Student("ST10040040", "Jada", "Computer Science");
            Assert.AreEqual(stud["studentnumber"], "ST10040040");
        }
    }
}
