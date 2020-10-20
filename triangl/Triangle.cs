using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangl
{
    class Triangle
    {
        public double a; // первая сторона
        public double b; // вторая сторона
        public double c; // третья сторона
        public double h; // высота
        public string answer;// тип треугольника
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(double A, double B, double C, double H)
        {
            a = A;
            b = B;
            c = C;
            h = H;
        }
        public Triangle(double H, double B)
        {
            b = B;
            h = H;
        }
        public string outputA() // выводим сторону а, данный метод возвращает строковое значение
        {
            return Convert.ToString(a); // a - ссылка на внутренее поле обьекта класса
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string outputH()
        {
            return Convert.ToString(h);
        }
        public double HeightOfTriangle()//нахождение высоты
        {
            double p;
            p = 0.5 * (a + b + c);
            h = 2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a;
            return h;
        }
        public double AreaOfTriangle() // нахождение площади
        {
            double S;
            S = 1 / 2 * b * h;
            return S;
        }
        public double Perimeter() // сумма всех сторон типо double
        {
            double p = 0;
            p = a + b + c; // вычисление
            return p; // возврат
        }
        public double Surface() // аналогично периметру
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Round(Math.Sqrt((p * (p - a) * (p - b) * (p - c))), 2);
            return s;
        }
        public double GetSetA // свойство позволяющее установить либо изменить значение стороны а
        {
            get //устанавливаем
            { return a; }
            set // меняем
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public bool ExistTriangle // свойство позволяющее установить, существует ли треугольник с задаными сторонами
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b)) //сумма 2 сторон должна быть больше третьей
                    return true;
                else return false;
            }
        }
        public bool EquilateralTriangle // выяснение равносторонний треугольник
        {
            get
            {
                if ((a == b) || (a == c) || (b == c))
                    return true;
                else return false;
            }
        }
        public string TypeOfTriangle()//определение типа треугольника
        {
            if ((a * a == b * b + c * c) || (b * b == c * c + a * a) || (c * c == a * a + b * b))
            {
                answer = "прямоугольный";
            }
            else if ((a * a > b * b + c * c) || (c * c > a * a + b * b) || (b * b > a * a + c * c))
            {
                answer = "тупоугольный";
            }
            else
            {
                answer = "остроугольный";
            }
            return answer;
        }
        public string ImageType()// изменение картинки от TypeOfTriangle
        {
            string image = "";
            if (answer == "Прямоугольный") //проверка условие
            {
                image = @"C:\Users\opilane\source\repos\Triangle_Vorm\kartinki\pramougolni.jpg";
            }
            if (answer == "Остроугольный")// проверка условия
            {
                image = @"C:\Users\opilane\source\repos\Triangle_Vorm\kartinki\ostrougolnik.jpg";
            }
            if (answer == "Тупоугольный")//// проверка условия
            {
                image = @"C:\Users\opilane\source\repos\Triangle_Vorm\kartinki\typougolnik.jpg";
            }
            return image;
        }
        public double bisectrisa()
        {
            double bisectrisa;
            bisectrisa = Math.Round(Math.Sqrt(b * c * ((b + c) * (b + c) - a * a)) / (b + c), 2);
            return bisectrisa;
        }
        public double mediana()
        {
            double m = 0;
            m = Math.Round((Math.Sqrt(2 * b * b + 2 * c * c - a * a) / 2), 2);
            return m;
        }
    }
}