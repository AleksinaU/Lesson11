using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    struct Lineynoe
    {
        double k;
        double b;
        public Lineynoe(double k, double b)
        {
        this.k = k;
        this.b = b;
        }
        public string Root()
        {
            double x = -b / k;
            if (b == 0 & k == 0)
                return "Решений бесконечное множество";
            if (b != 0 & k == 0)
                return "У уровнения не может быть корней";
            else
                return $"Корень уравнения равен {x}";
        }
    }
}
