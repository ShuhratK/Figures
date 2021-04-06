using System;

namespace Figures
{
    /*
     Задание:

    Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

    Юнит-тесты

    Легкость добавления других фигур

    Вычисление площади фигуры без знания типа фигуры

    Проверку на то, является ли треугольник прямоугольным
*/
    
    public abstract class Shape
    {
        public abstract float getArea();
    }

    public class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override float getArea()
        {
            return (float)Math.PI * (radius * radius);
        }
    }

    public class Triangle : Shape
    {
        private float sideA;
        private float sideB;
        private float sideC;
        
        public override float getArea()
        {
            float p = (sideA + sideB + sideC) / 2.0f;
            return (float)Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public bool isRight()
        {
            return sideA * sideA == (sideB * sideB) + (sideC * sideC) ||
                   sideB * sideB == (sideA * sideA) + (sideC * sideC) ||
                   sideC * sideC == (sideB * sideB) + (sideA * sideA);

        }
         
        
    }
    
}