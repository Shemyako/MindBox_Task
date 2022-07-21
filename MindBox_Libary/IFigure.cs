using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Libary
{
    /// <summary>
    /// Интерфейс для фигур 
    /// Определяет необходимость наличия площади и периметра
    /// </summary>
    internal interface IFigure
    {
        // Площадь
        float Square();
        // Периметр
        float Perimeter();
    }
}
