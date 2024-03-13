using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Box
    {
       public  int Length, Breadth;
        public Box(int Length,int Breadth)
        {
            this.Length = Length;
            this.Breadth = Breadth;
        }
    }
    class Test
    {
        int Length, Breadth;
        public static  Test addBoxes(Box a,Box b)
        {
            Test b3=new Test();
            b3.Length = a.Length + b.Length;
            b3.Breadth = a.Breadth + b.Breadth;
            return b3;
        }
        public static void Main()
        {

            Console.WriteLine("Enter the Box 1 Length");
            int l1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Box 1 Breadth");
            int b1 = int.Parse(Console.ReadLine());
            Box B1 = new Box(l1, b1);
            Console.WriteLine("Enter the Box 2 Length");
            int l2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Box 2 Breadth");
            int b2 = int.Parse(Console.ReadLine());
            Box B2 = new Box(l2, b2);
            Test t=addBoxes(B1, B2);
            Console.WriteLine("New Box Length is : "+t.Length);
            Console.WriteLine("New Box Length is : " + t.Breadth);
            Console.ReadKey();
        }
    }
}
