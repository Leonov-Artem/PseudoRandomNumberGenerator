namespace NumberGenerator
{
    public class LinearCongruentMethod : IRandom
    {
        private int a;
        private int c;
        private int m;
        private double Xn;
        
        public LinearCongruentMethod(int x0=5, int a=211, int c=1663, int m=7875)
        {
            this.Xn = x0;
            this.a = a;
            this.c = c;
            this.m = m;
        }

        public double GenerateNumber()
        {
            Xn = (a * Xn + c) % m;
            return Xn / m;
        }
    }
}
