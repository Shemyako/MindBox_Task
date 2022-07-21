
namespace MindBox_UnitTest
{
    [TestClass]
    public class Circle_tests
    {
        /// <summary>
        /// Создаю круг с неверным радиусом
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Circle_creation()
        {
            // act
            Circle o = new Circle(-5);
            // assert
        }

        /// <summary>
        /// Проверяю площадь круга
        /// </summary>
        [TestMethod]
        public void Circle_square()
        {
            // arrange
            Circle o = new Circle(5);
            float prediction = 78.53982F;
            // act
            float result = o.Square();
            // assert
            Assert.AreEqual(prediction, result);
        }

        /// <summary>
        /// Проверяю периметр круга
        /// </summary>
        [TestMethod]
        public void Circle_perimeter()
        {
            // arrange
            Circle o = new Circle(5);
            float prediction = 31.415928F;
            // act
            float result = o.Perimeter();
            // assert
            Assert.AreEqual(prediction, result);
        }
    }
}
