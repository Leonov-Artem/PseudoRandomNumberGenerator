using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGenerator
{
    public class MultiplicativeCongruentMethod : IRandom
    {
        private int a;
        private int m;
        private double Xn;

        public MultiplicativeCongruentMethod(int x0=5, int t=43, int m=6075)
        {
            this.Xn = x0;
            this.a = 8 * t + 3;
            this.m = m;
        }

        public double GenerateNumber()
        {
            Xn = (a * Xn) % m;
            return Xn / m;
        }
    }
}
