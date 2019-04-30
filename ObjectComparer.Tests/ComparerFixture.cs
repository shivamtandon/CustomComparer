using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectComparer.Tests.TestModels;

namespace ObjectComparer.Tests
{
    [TestClass]
    public class ComparerFixture
    {
        [TestMethod]
        public void Null_values_are_similar_test()
        {
            string first = null, second = null;
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Similar_string_values()
        {
            string first = "Test", second = "Test";
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }


        [TestMethod]
        public void Different_string_values()
        {
            string first = "Test", second = "test";
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Values_are_similar()
        {
            int first = 5, second = 5;
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Values_are_different()
        {
            int first = 5, second = 10;
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void ArrayType_same_values()
        {
            int[] first = new int[] { 10, 20, 30 };
            int[] second = new int[] { 10, 20, 30 };
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void ArrayType_different_values()
        {
            int[] first = new int[] { 10, 20, 30 };
            int[] second = new int[] { 10, 40, 50 };
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Unordered_ArrayType_same_values()
        {
            int[] first = new int[] { 10, 20, 30 };
            int[] second = new int[] { 20, 10, 30 };
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void ComplexType__same_values()
        {
            Student One = new Student
            {
                Marks = new[] { 80, 90, 100 },
                Id = 1,
                Name = "MrX",
                Address = new Address()
                {
                    Country = "India",
                    Cities = new[] { "Pune", "Noida" }
                }
            };

            Student Two = new Student
            {
                Marks = new[] { 80, 90, 100 },
                Id = 1,
                Name = "MrX",
                Address = new Address()
                {
                    Country = "India",
                    Cities = new[] { "Pune", "Noida" }
                }
            };
            Assert.IsTrue(Comparer.AreSimilar(One, Two));
        }

        [TestMethod]
        public void ComplexType__diffrent_values()
        {
            Student One = new Student
            {
                Marks = new[] { 80, 90, 100 },
                Id = 1,
                Name = "MrX",
                Address = new Address()
                {
                    Country = "India",
                    Cities = new[] { "Pune", "Noida" }
                }
            };

            Student Two = new Student
            {
                Marks = new[] { 80, 90, 100 },
                Id = 1,
                Name = "MrsX",
                Address = new Address()
                {
                    Country = "India",
                    Cities = new[] { "Pune", "Noida" }
                }
            };
            Assert.IsFalse(Comparer.AreSimilar(One, Two));
        }
    }
}
