namespace MindBox_UnitTest
{
    [TestClass]
    public class Triangle_tests
    {
        /// <summary>
        /// Тест создания треугольника с неверными сторонами 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Triangle_creating0()
        {
            // act
            Triangle abc = new Triangle(0, -3, 10);
            // assert
        }

        /// <summary>
        /// Тест поиска площади треугольника
        /// </summary>
        [TestMethod]
        public void Triangle_square()
        {
            // arrange
            Triangle abc = new Triangle(3, 4, 5);
            float square_prediction = 6;
            // act
            float result = abc.Square();
            // assert
            Assert.AreEqual(square_prediction, result);
        }

        /// <summary>
        /// Тест поиска периметра треугольника
        /// </summary>
        [TestMethod]
        public void Triangle_perimeter()
        {
            // arrange
            Triangle abc = new Triangle(3, 4, 5);
            float p_prediction = 12;
            // act
            float result = abc.Perimeter();
            // assert
            Assert.AreEqual(p_prediction, result);
        }

        /// <summary>
        /// Является ли треугольник прямоугольным (да)
        /// </summary>
        [TestMethod]
        public void Triangle_is_right1()
        {
            // arrange
            Triangle abc = new Triangle(3, 4, 5);
            // act
            bool result = abc.Is_right();
            // assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Является ли тругеальник примогульным (нет)
        /// </summary>
        [TestMethod]
        public void Triangle_is_right_0()
        {
            // arragne
            Triangle abc = new Triangle(4, 4, 5);
            // act
            bool result = abc.Is_right();
            // assert
            Assert.IsTrue(!result);
        }
    }
}