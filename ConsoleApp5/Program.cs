using System;
namespace ConsoleApp5
{
    class myapp
    {
        public int a = Convert.ToInt32(Console.ReadLine());
        public int b;
        public int c;
        public int d;
        public int e;

        public myapp()
        {
            c = a * a;

        }
        public void add()
        {
            Console.WriteLine("Addition=" + c);
        }
        public myapp(int x, int y)
        {
            Console.WriteLine("Enter the value of b and d");
            b = x;
            d = y;
            e = d + b;

        }
        public void multiple()
        {
            Console.WriteLine("mul=" + this.e);
        }
    
          


        
    }
    class program
    {
        static void Main(string[] arg)
        {
            myapp obj = new myapp();
            obj.add();
            obj.multiple();
           


            {

            }
        }
    }
}