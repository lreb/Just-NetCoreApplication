using System;

namespace justtest.some
{
    public class Algo
    {
        public int x { get; set; } = 3;
        public bool y { get; set; } = false;
        public string z { get; set; } = string.Empty;
        

        internal void OutValues(out int v1) => v1 = 2;

        internal void TupleExample()
        {
            var tuple = ("a","b");
            Console.WriteLine($"tuple1 {tuple.Item1}");
            (string NameOne, string NameTwo) NamesTuple = ("Juan","Mária");
            Console.WriteLine($"tuple1 {NamesTuple.NameTwo}");
        }
    }    

    class ConstructorDestructor
    {
        public ConstructorDestructor(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double X { get; }
        public double Y { get; }

        public void Desconstructor(out double x, out double y)
        {
            x = this.X;
            y = this.Y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var algo = new Algo();
            algo.OutValues(out int value);
            Console.WriteLine($"the value is {value}");
        }
    }
}