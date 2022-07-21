using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Libary
{
    /// <summary>
    /// Класс для круга
    /// </summary>
    public class Circle : IFigure
    {
        // Радиус
        float r { get; set; }

        /// <summary>
        /// Преобразование к строке объекта
        /// </summary>
        /// <param name="circle">Объект класса</param>
        public static implicit operator string(Circle circle)
        {
            return $"Круг с радиусом {circle.r}";
        }

        /// <summary>
        /// Поиск периметра
        /// </summary>
        /// <returns>Периметр (2*Pi*r)</returns>
        public float Perimeter()
        {
            return (float) Math.PI * 2 * r;
        }

        /// <summary>
        /// Поиск площади
        /// </summary>
        /// <returns>Площадь (Pi * r^2)</returns>
        public float Square()
        {
            return (float)Math.PI * r * r;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pre_r">Радиус</param>
        /// <exception cref="ArgumentException">Некорректный радиус</exception>
        public Circle(float pre_r)
        {
            if (pre_r <= 0)
                throw new ArgumentException("Радиус не может быть меньше или равным нулю");
            
            r = pre_r;
        }
    }
}
