namespace MindBox_UnitTest
{
    [TestClass]
    public class Triangle_tests
    {
        /// <summary>
        /// ���� �������� ������������ � ��������� ��������� 
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
        /// ���� ������ ������� ������������
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
        /// ���� ������ ��������� ������������
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
        /// �������� �� ����������� ������������� (��)
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
        /// �������� �� ����������� ������������ (���)
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