using System;

namespace cassfirst_example
{
    public class MyClass
    {
        public string myField = string.Empty;

        public MyClass()
        {
            Console.WriteLine("Constructor");
        }

        public void MyMethod(int parameter1, string parameter2)
        {
            Console.WriteLine("First Parameter {0}, second parameter {1}",
                                                        parameter1, parameter2);
        }

        public int MyAutoImplementedProperty { get; set; }

        private int myPropertyVar;

        public int MyProperty
        {
            get { return myPropertyVar; }
            set { myPropertyVar = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.MyMethod(3, "s");
            Console.WriteLine("enter integer ");
            m.MyAutoImplementedProperty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter integer");
            m.MyProperty = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("MyAutoImplementedProperty="+m.MyAutoImplementedProperty);
            Console.WriteLine("MyProperty="+m.MyProperty);



        }
    }
}






