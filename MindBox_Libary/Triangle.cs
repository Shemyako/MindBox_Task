namespace MindBox_Libary
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : IFigure
    {
        // Стороны треугольника
        float a { set; get; }
        float b { set;  get; }
        float c { set; get; }

        /// <summary>
        /// Преобразование к строке объекта
        /// </summary>
        /// <param name="circle">Объект класса</param>
        public static implicit operator string(Triangle triangle)
        {
            return $"Треугольник со сторонами: {triangle.a}, {triangle.b}, {triangle.c}";
        }

        /// <summary>
        /// Поиск площади
        /// </summary>
        /// <returns>Площадь (формула Герона)</returns>
        public float Square()
        {
            // Полумериметр для формулы
            float p = this.Perimeter() / 2;
            // Формула Герона
            return (float)Math.Sqrt(p * (p-a) * (p-b) * (p-c));
        }

        /// <summary>
        /// Поиск периметра
        /// </summary>
        /// <returns>Сумма длин всех сторон (Периметр)</returns>
        public float Perimeter()
        {
            return a + b + c;
        }

        /// <summary>
        /// Прямоугольный ли треугольник
        /// </summary>
        /// <returns>bool, выполняется ли теорема Пифагора</returns>
        public bool Is_right()
        {
            if (a * a == b * b + c * c)
                return true;
            else return false;
        }

        /// <summary>
        /// Конструктор создания треугольника
        /// </summary>
        /// <param name="pre_a">Первая сторона треугольника</param>
        /// <param name="pre_b">Вторая сторона треугольника</param>
        /// <param name="pre_c">Третья сторона треугольника</param>
        /// <exception cref="ArgumentException">Стороны меньше либо равны нулю</exception>
        public Triangle(float pre_a, float pre_b, float pre_c)
        {
            // Ищем наибольшую сторону, её ставим на 'a'
            if (pre_a <= 0 || pre_b <= 0 || pre_c <= 0)
                throw new ArgumentException("Стороны треугольника равны нулю или меньше оного");
            else if (pre_a > pre_b && pre_a > pre_c)
            {
                a = pre_a;
                b = pre_b;
                c = pre_c;
            }
            else if (pre_b > pre_a && pre_b > pre_c)
            {
                a = pre_b;
                b = pre_a;
                c = pre_c;
            }
            else
            {
                a = pre_c;
                b = pre_b;
                c = pre_a;
            }
        }
    }
}