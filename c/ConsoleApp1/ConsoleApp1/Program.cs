//using System;//第一条语句都是
//namespace HelloWorldApplication
//{
//    class HelloWorld
//    {
//        //static void Main(string[] args)
//        //{
//        /* 我的第一个 C# 程序*/
//        //Console.WriteLine("Hello World");
//        //Console.ReadKey();
//        //}
//        public void Hello()
//        {
//            Console.WriteLine("Hello World");
//            Console.ReadKey();
//        }
//    }
//    class Rectangle
//    {
//        // 成员变量
//        double length;
//        double width;
//        public void Acceptdetails()
//        {
//            length = 4.5;
//            width = 3.5;
//        }
//        public double GetArea()
//        {
//            return length * width;
//        }
//        public void Display()
//        {
//            Console.WriteLine("Length: {0}", length);
//            Console.WriteLine("Width: {0}", width);
//            Console.WriteLine("Area: {0}", GetArea());
//        }
//    }

//    class ExecuteRectangle
//    {
//        static void Main(string[] args)
//       {//Main入口点
//            Rectangle r = new Rectangle();
//            r.Acceptdetails();
//            r.Display();

//            HelloWorld h = new HelloWorld();
//           h.Hello();
//           //Console.ReadLine();
//        }
//    }
//}
////装箱:值类型转换为对象类型时;拆箱：对象类型转换为值类型。
////字符串（String）类型的值可以通过两种形式进行分配：引号和 @引号。
//namespace TypeConversionApplication
//{
//   public class ExplicitConversion
//    {
//        class SampleClass
//        {
//            public int x;
//            public int y;
//            public const int c1 = 5888888;
//            public const int c2 = c1 + 5;

//            public SampleClass(int p1, int p2)
//            {
//                x = p1;
//                y = p2;
//            }
//        }
//        static void Main(string[] args)
//        {
//            double d = 5673.742;
//            int i;
//            i = (int)d;
//            // 强制转换 double 为 int
//            i = (int)d;
//            float f = 53.005f;//f后缀是32 位单精度浮点型，否则默认为double型64 位双精度浮点型
//            double db = 2345.7652;
//            bool b = true;
//            short a;
//            double a2;
//            double a3;
//            //int num;
//            //num = Convert.ToInt32(Console.ReadLine());

//            /* 实际初始化 */
//            a = 10;
//            a2 = 20.33;
//            a3 = a + a2;
//            Console.WriteLine("a = {0}, a3 = {1}", a, a3);
//            Console.WriteLine(SampleClass.c1);

//            //Console.WriteLine(f.ToString());
//            //Console.WriteLine(db.ToString());
//            //Console.WriteLine(b.ToString());
//            //Console.WriteLine("输入用户名和ID");
//            string name = Console.ReadLine();
//            int id = int.Parse(Console.ReadLine());
//            Console.WriteLine("User Name is {0} \nThe id is {1}", name, id);
//            //Console.WriteLine(i);
//            Console.ReadLine();
//            //Console.ReadKey();

//        }
//    }
//}
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace ConsoleTest
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            //Console.WriteLine("输入用户名和ID");
////            string name = Console.ReadLine();
////            int id = int.Parse(Console.ReadLine());
////            Console.WriteLine("User Name is {0} \nThe id is {1}", name, id);
////            Console.ReadKey();
////        }
////    }
////}
//using System;

//namespace RectangleApplication
//{
//    class Rectangle
//    {
//        //成员变量
//        private double length;
//        private double width;

//        public void Acceptdetails()
//        {
//            Console.WriteLine("请输入长度：");
//            length = double.Parse(Console.ReadLine());
//            Console.WriteLine("请输入宽度：");
//            width = Convert.ToDouble(Console.ReadLine());
//        }
//        public double GetArea()
//        {
//            return length * width;
//        }
//        public void Display()
//        {
//            Console.WriteLine("长度： {0}", length);
//            Console.WriteLine("宽度： {0}", width);
//            Console.WriteLine("面积： {0}", GetArea());
//        }
//    }//end class Rectangle    
//    class ExecuteRectangle
//    {
//        static void Main(string[] args)
//        {
//            Rectangle r = new Rectangle();
//            r.Acceptdetails();
//            r.Display();
//            Console.ReadLine();
//        }
//    }
//}
//using System;
//namespace CalculatorApplication
//{
//    class NumberManipulator
//    {
//        public void swap(int x, int y)
//        {
//            int temp;

//            temp = x; /* 保存 x 的值 */
//            x = y;    /* 把 y 赋值给 x */
//            y = temp; /* 把 temp 赋值给 y */
//            Console.WriteLine("xy {0}{1}", x,y);
//        }

//        static void Main(string[] args)
//        {
//            NumberManipulator n = new NumberManipulator();
//            /* 局部变量定义 */
//            int a = 100;
//            int b = 200;
//            int i;
//            Console.WriteLine("在交换之前，a 的值： {0}", a);
//            Console.WriteLine("在交换之前，b 的值： {0}", b);

//            /* 调用函数来交换值 */
//            n.swap(a, b);

//            Console.WriteLine("在交换之后，a 的值： {0}", a);
//            Console.WriteLine("在交换之后，b 的值： {0}", b);
//            int[] marks = new int[5] { 5, 6, 7, 8, 9 };
//            for(i=0;i<5;i++){
//                 Console.WriteLine(marks[i]);
//            }//遍历数组
//            foreach (int j in marks)
//            {
//                Console.WriteLine(j);
//            }
//            Console.ReadLine();
//        }
//    }
//}
//using System;

//namespace StringApplication
//{
//    class StringProg
//    {
//        static void Main(string[] args)
//        {
//            string str1 = "This is test";
//            string str2 = "This is text";

//            if (String.Compare(str1, str2) == 0)
//            {
//                Console.WriteLine(str1 + " and " + str2 + " are equal.");
//            }
//            else
//            {
//                Console.WriteLine(str1 + " and " + str2 + " are not equal."+String.Compare(str1, str2));
//            }
//            Console.ReadKey();
//        }
//    }
//}
//using System;

//public class EnumTest
//{
//    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

//    static void Main()
//    {
//        int x = (int)Day.Sun;
//        int y = (int)Day.Fri;
//        Console.WriteLine("Sun = {0}", x);
//        Console.WriteLine("Fri = {0}", y);
//    }
//}
//using System;
//namespace StaticVarApplication
//{
//    class StaticVar
//    {
//       public static int num;
//        public void count()
//        {
//            num++;
//        }
//        public int getNum()
//        {
//            return num;
//        }
//    }
//    class StaticTester
//    {
//        static void Main(string[] args)
//        {
//            StaticVar s1 = new StaticVar();
//            StaticVar s2 = new StaticVar();
//            s1.count();
//            s1.count();
//            s1.count();
//            s2.count();
//            s2.count();
//            s2.count();         
//            Console.WriteLine("s1 的变量 num： {0}", s1.getNum());
//            Console.WriteLine("s2 的变量 num： {0}", s2.getNum());
//            Console.ReadKey();
//        }
//    }
//}
//派生类继承了基类的成员变量和成员方法
//静态多态性（函数重载、运算符重载），函数的响应是在编译时发生；动态多态性（抽象类和虚方法），函数的响应是在运行时发生
//using System;
//namespace PolymorphismApplication
//{
//    class Shape
//    {
//        protected int width, height;
//        public Shape(int a = 0, int b = 0)
//        {
//            width = a;
//            height = b;
//        }
//        public virtual int area()
//        {
//            Console.WriteLine("父类的面积：");
//            return 0;
//        }
//    }
//    class Rectangle : Shape
//    {
//        public Rectangle(int a = 0, int b = 0) : base(a, b)
//        {

//        }
//        public override int area()
//        {
//            Console.WriteLine("Rectangle 类的面积：");
//            return (width * height);
//        }
//    }
//    class Triangle : Shape
//    {
//        public Triangle(int a = 0, int b = 0) : base(a, b)
//        {

//        }
//        public override int area()
//        {
//            Console.WriteLine("Triangle 类的面积：");
//            return (width * height / 2);
//        }
//    }
//    class Caller
//    {
//        public void CallArea(Shape sh)
//        {
//            int a;
//            a = sh.area();
//            Console.WriteLine("面积： {0}", a);
//        }
//    }
//    class Tester
//    {

//        static void Main(string[] args)
//        {
//            Caller c = new Caller();
//            Rectangle r = new Rectangle(10, 7);
//            Triangle t = new Triangle(10, 5);
//            c.CallArea(r);
//            c.CallArea(t);
//            Console.ReadKey();
//        }
//    }
//}
//可重载与不可重载运算符
//using System;

//namespace OperatorOvlApplication
//{
//    class Box
//    {
//        private double length;      // 长度
//        private double breadth;     // 宽度
//        private double height;      // 高度

//        public double getVolume()
//        {
//            return length * breadth * height;
//        }
//        public void setLength(double len)
//        {
//            length = len;
//        }

//        public void setBreadth(double bre)
//        {
//            breadth = bre;
//        }

//        public void setHeight(double hei)
//        {
//            height = hei;
//        }
//        // 重载 + 运算符来把两个 Box 对象相加
//        public static Box operator +(Box b, Box c)
//        {
//            Box box = new Box();
//            box.length = b.length + c.length;
//            box.breadth = b.breadth + c.breadth;
//            box.height = b.height + c.height;
//            return box;
//        }

//        public static bool operator ==(Box lhs, Box rhs)
//        {
//            bool status = false;
//            if (lhs.length == rhs.length && lhs.height == rhs.height
//               && lhs.breadth == rhs.breadth)
//            {
//                status = true;
//            }
//            return status;
//        }
//        public static bool operator !=(Box lhs, Box rhs)
//        {
//            bool status = false;
//            if (lhs.length != rhs.length || lhs.height != rhs.height
//                || lhs.breadth != rhs.breadth)
//            {
//                status = true;
//            }
//            return status;
//        }
//        public static bool operator <(Box lhs, Box rhs)
//        {
//            bool status = false;
//            if (lhs.length < rhs.length && lhs.height
//                < rhs.height && lhs.breadth < rhs.breadth)
//            {
//                status = true;
//            }
//            return status;
//        }

//        public static bool operator >(Box lhs, Box rhs)
//        {
//            bool status = false;
//            if (lhs.length > rhs.length && lhs.height
//                > rhs.height && lhs.breadth > rhs.breadth)
//            {
//                status = true;
//            }
//            return status;
//        }

//        public static bool operator <=(Box lhs, Box rhs)
//        {
//            bool status = false;
//            if (lhs.length <= rhs.length && lhs.height
//                <= rhs.height && lhs.breadth <= rhs.breadth)
//            {
//                status = true;
//            }
//            return status;
//        }

//        public static bool operator >=(Box lhs, Box rhs)
//        {
//            bool status = false;
//            if (lhs.length >= rhs.length && lhs.height
//               >= rhs.height && lhs.breadth >= rhs.breadth)
//            {
//                status = true;
//            }
//            return status;
//        }
//        public override string ToString()
//        {
//            return String.Format("({0}, {1}, {2})", length, breadth, height);
//        }

//    }

//    class Tester
//    {
//        static void Main(string[] args)
//        {
//            Box Box1 = new Box();          // 声明 Box1，类型为 Box
//            Box Box2 = new Box();          // 声明 Box2，类型为 Box
//            Box Box3 = new Box();          // 声明 Box3，类型为 Box
//            Box Box4 = new Box();
//            double volume = 0.0;   // 体积

//            // Box1 详述
//            Box1.setLength(6.0);
//            Box1.setBreadth(7.0);
//            Box1.setHeight(5.0);

//            // Box2 详述
//            Box2.setLength(12.0);
//            Box2.setBreadth(13.0);
//            Box2.setHeight(10.0);

//            // 使用重载的 ToString() 显示两个盒子
//            Console.WriteLine("Box1： {0}", Box1.ToString());
//            Console.WriteLine("Box2： {0}", Box2.ToString());

//            // Box1 的体积
//            volume = Box1.getVolume();
//            Console.WriteLine("Box1 的体积： {0}", volume);

//            // Box2 的体积
//            volume = Box2.getVolume();
//            Console.WriteLine("Box2 的体积： {0}", volume);

//            // 把两个对象相加
//            Box3 = Box1 + Box2;
//            Console.WriteLine("Box3： {0}", Box3.ToString());
//            // Box3 的体积
//            volume = Box3.getVolume();
//            Console.WriteLine("Box3 的体积： {0}", volume);

//            //comparing the boxes
//            if (Box1 > Box2)
//                Console.WriteLine("Box1 大于 Box2");
//            else
//                Console.WriteLine("Box1 不大于 Box2");
//            if (Box1 < Box2)
//                Console.WriteLine("Box1 小于 Box2");
//            else
//                Console.WriteLine("Box1 不小于 Box2");
//            if (Box1 >= Box2)
//                Console.WriteLine("Box1 大于等于 Box2");
//            else
//                Console.WriteLine("Box1 不大于等于 Box2");
//            if (Box1 <= Box2)
//                Console.WriteLine("Box1 小于等于 Box2");
//            else
//                Console.WriteLine("Box1 不小于等于 Box2");
//            if (Box1 != Box2)
//                Console.WriteLine("Box1 不等于 Box2");
//            else
//                Console.WriteLine("Box1 等于 Box2");
//            Box4 = Box3;
//            if (Box3 == Box4)
//                Console.WriteLine("Box3 等于 Box4");
//            else
//                Console.WriteLine("Box3 不等于 Box4");

//            Console.ReadKey();
//        }
//    }
//}
//接口interface
/*
 (1)通过接口可以实现多重继承，C# 接口的成员不能有 public、protected、internal、private 等修饰符。原因很简单，接口里面的方法都需要由外面接口实现去实现方法体，那么其修饰符必然是 public。C# 接口中的成员默认是 public 的，java 中是可以加 public 的。
 (2)接口成员不能有 new、static、abstract、override、virtual 修饰符。有一点要注意，当一个接口实现一个接口，这2个接口中有相同的方法时，可用 new 关键字隐藏父接口中的方法。
 (3)接口中只包含成员的签名，接口没有构造函数，所有不能直接使用 new 对接口进行实例化。接口中只能包含方法、属性、事件和索引的组合。接口一旦被实现，实现类必须实现接口中的所有成员，除非实现类本身是抽象类。
 (4)C# 是单继承，接口是解决 C# 里面类可以同时继承多个基类的问题。抽象类是类所以只能被单继承，接口可以一次实现多个
 */
//using System;
//interface IParentInterface
//{
//    void ParentInterfaceMethod();
//}
//interface IMyInterface:IParentInterface
//{
//    void MethodToImplement();
//}
//class InterfaceImplementer : IMyInterface
//{
//    static void Main()
//    {
//        InterfaceImplementer iImp = new InterfaceImplementer();
//        iImp.MethodToImplement();
//        iImp.ParentInterfaceMethod();
//    }
//    public void MethodToImplement()
//    {
//        Console.WriteLine("methodtoimplement() called.");
//    }
//    public void ParentInterfaceMethod()
//    {
//        Console.WriteLine("parentInterfaceMethod() called.");
//        //Console.ReadKey();
//    }
//}
//public interface IWorker { void work(string s); }
//class James1 : IWorker
//{
//    public void work(string s)
//    {
//        Console.WriteLine("james1----" + s);
//    }
//}
//class James2:IWorker
//{
//    public void work(string s)
//    {
//        Console.WriteLine("james2---" + s);
//        Console.ReadKey();
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        IWorker james1 = new James1();
//        IWorker james2 = new James2();
//        james1.work("高碑店");
//        james2.work("房屋");
//    }
//}
//正则表达式？？？
//分组构造!!!捕获匹配的子表达式并将其分配到一个从零开始的序号中。 (\w)\1 "deep" 中的 "ee"------------？？？
//反向引用构造？？？ (\w)\1	"seek" 中的 "ee"
//using System;
//using System.Text.RegularExpressions;

//namespace RegExApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = "fwsj   tjb   ";
//            string pattern = "\\s+";//至少一个空格，\\s处理成new Regex()中\s
//            string replacement = " ";
//            Regex rgx = new Regex(pattern);
//            string result = rgx.Replace(input, replacement);

//            Console.WriteLine("Original String: {0}", input);
//            Console.WriteLine("Replacement String: {0}", result);
//            Console.ReadKey();
//        }
//    }
//}
//异常处理
//using System;
//namespace ErrorHandlingApplication
//{
//    class DivNumbers
//    {
//        int result;
//        DivNumbers()
//        {
//            result = 0;
//        }
//        public void division(int num1, int num2)
//        {
//            try
//            {
//                result = num1 / num2;
//            }
//            catch (DivideByZeroException e)
//            {
//                Console.WriteLine("Exception caught: {0}", e);
//            }
//            finally
//            {
//                Console.WriteLine("Result: {0}", result);
//            }

//        }
//        static void Main(string[] args)
//        {
//            DivNumbers d = new DivNumbers();
//            d.division(25, 0);
//            Console.ReadKey();
//        }
//    }
//}
//文件的输入与输出
//using System;
//using System.IO;

//namespace FileIOApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            FileStream F = new FileStream("test.dat",
//            FileMode.OpenOrCreate, FileAccess.ReadWrite);

//            for (int i = 1; i <= 20; i++)
//            {
//                F.WriteByte((byte)i);
//            }

//            F.Position = 0;

//            for (int i = 0; i <= 20; i++)
//            {
//                Console.Write(F.ReadByte() + " ");
//            }
//            F.Close();
//            Console.ReadKey();
//        }
//    }
//}
//特性
//#define DEBUG
//using System;
//using System.Diagnostics;
//public class Myclass
//{
//    [Conditional("DEBUG")]
//    public static void Message(string msg)
//    {
//        Console.WriteLine(msg);
//    }
//}
//class Test
//{
//    static void function1()
//    {
//        Myclass.Message("In Function 1.");
//        function2();
//    }
//    static void function2()
//    {
//        Myclass.Message("In Function 2.");
//    }
//    public static void Main()
//    {
//        Myclass.Message("In Main function.");
//        function1();
//        Console.ReadKey();
//    }
//}
//using System;
//public class MyClass
//{
//    [Obsolete("Don't use OldMethod, use NewMethod instead", true)]//true错误，false警告
//    static void OldMethod()
//    {
//        Console.WriteLine("It is the old method");
//    }
//    static void NewMethod()
//    {
//        Console.WriteLine("It is the new method");
//    }
//    public static void Main()
//    {
//        OldMethod();
//    }
//}
// 一个自定义特性 BugFix 被赋给类及其成员
//[AttributeUsage(AttributeTargets.Class |
//AttributeTargets.Constructor |
//AttributeTargets.Field |
//AttributeTargets.Method |
//AttributeTargets.Property,
//AllowMultiple = true)]

//public class DeBugInfo : System.Attribute
//{
//    private int bugNo;
//    private string developer;
//    private string lastReview;
//    public string message;

//    public DeBugInfo(int bg, string dev, string d)
//    {
//        this.bugNo = bg;
//        this.developer = dev;
//        this.lastReview = d;
//    }

//    public int BugNo
//    {
//        get
//        {
//            return bugNo;
//        }
//    }
//    public string Developer
//    {
//        get
//        {
//            return developer;
//        }
//    }
//    public string LastReview
//    {
//        get
//        {
//            return lastReview;
//        }
//    }
//    public string Message
//    {
//        get
//        {
//            return message;
//        }
//        set
//        {
//            message = value;
//        }
//    }
//}

//[DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
//[DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
//class Rectangle
//{
//    // 成员变量
//    protected double length;
//    protected double width;
//    public Rectangle(double l, double w)
//    {
//        length = l;
//        width = w;
//    }
//    [DeBugInfo(55, "Zara Ali", "19/10/2012",
//    Message = "Return type mismatch")]
//    public double GetArea()
//    {
//        return length * width;
//    }
//    [DeBugInfo(56, "Zara Ali", "19/10/2012")]
//    public void Display()
//    {
//        Console.WriteLine("Length: {0}", length);
//        Console.WriteLine("Width: {0}", width);
//        Console.WriteLine("Area: {0}", GetArea());
//    }
//}

//1、创建一个自定义特性：

// 描述如何使用一个自定义特性 SomethingAttribute
//[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]

////********自定义特性SomethingAttribute**************//
//public class SomethingAttribute : Attribute
//{
//    private string name; // 名字
//    private string data; // 日期
//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//    public string Data
//    {
//        get { return data; }
//        set { data = value; }
//    }
//    public SomethingAttribute(string name)
//    {
//        this.name = name;
//        this.name = name;
//    }
//}
////2、实例化自定义

//[Something("Amy", Data = "2018-06-18")]
//[Something("Jack", Data = "2018-06-18")]
//class Test { }
////3、获取自定义特性的中的变量

//Type t = typeof(Test);
//var something = t.GetCustomAttributes(typeof(SomethingAttribute), true);
//foreach(SomethingAttribute each in something)
//{
//    Console.WriteLine("Name:{0}", each.Name);
//    Console.WriteLine("Data:{0}",each.Data);
//}

//反射
//using System;
//[AttributeUsage(AttributeTargets.All)]
//public class HelpAttribute : System.Attribute
//{
//    public readonly string Url;

//    public string Topic  // Topic 是一个命名（named）参数
//    {
//        get
//        {
//            return topic;
//        }
//        set
//        {

//            topic = value;
//        }
//    }

//    public HelpAttribute(string url)  // url 是一个定位（positional）参数
//    {
//        this.Url = url;
//    }

//    private string topic;
//}
//[HelpAttribute("Information on the class MyClass")]
//class MyClass
//{
//}

//namespace AttributeAppl
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Reflection.MemberInfo info = typeof(MyClass);//使用反射查看特性信息
//            object[] attributes = info.GetCustomAttributes(true);
//            for (int i = 0; i < attributes.Length; i++)
//            {
//                System.Console.WriteLine(attributes[i]);
//            }
//            Console.ReadKey();

//        }
//    }
//}
//属性
//using System;
//namespace ConsoleApp5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WordtoBit w = new WordtoBit();
//            w.X[5] = true;
//            foreach (bool b in w.X)
//            {
//                Console.WriteLine(b);
//            }
//            Console.ReadKey();
//        }
//    }
//    class WordtoBit
//    {
//        private bool[] x = new bool[16];
//        public bool[] X
//        {
//            get { return x; }//属性如果是一个数组的话，set 中的其它代码不会执行。
//            set
//            {
//                x = value;
//                Console.WriteLine("这句不能执行！");
//            }
//        }
//    }
//}
//索引器
//using System;
//namespace IndexerApplication
//{
//    class IndexedNames
//    {
//        private string[] namelist = new string[size];
//        static public int size = 10;
//        public IndexedNames()
//        {
//            for (int i = 0; i < size; i++)
//                namelist[i] = "N. A.";
//        }
//        public string this[int index]//索引器定义的时候不带有名称，但带有 this 关键字，它指向对象实例
//        {
//            get
//            {
//                string tmp;

//                if (index >= 0 && index <= size - 1)
//                {
//                    tmp = namelist[index];
//                }
//                else
//                {
//                    tmp = "";
//                }

//                return (tmp);
//            }
//            set
//            {
//                if (index >= 0 && index <= size - 1)
//                {
//                    namelist[index] = value;
//                }
//            }
//        }

//        static void Main(string[] args)
//        {
//            IndexedNames names = new IndexedNames();
//            names[0] = "Zara";
//            names[1] = "Riz";
//            names[2] = "Nuha";
//            names[3] = "Asif";
//            names[4] = "Davinder";
//            names[5] = "Sunil";
//            names[6] = "Rubic";
//            for (int i = 0; i < IndexedNames.size; i++)
//            {
//                Console.WriteLine(names[i]);
//            }
//            Console.ReadKey();
//        }
//    }
//}
//委托
//using System;
////委托的声明、实例化、使用
//delegate int NumberChanger(int n);
//namespace DelegateAppl
//{
//    class TestDelegate
//    {
//        static int num = 10;
//        public static int AddNum(int p)
//        {
//            num += p;
//            return num;
//        }

//        public static int MultNum(int q)
//        {
//            num *= q;
//            return num;
//        }
//        public static int getNum()
//        {
//            return num;
//        }

//        static void Main(string[] args)
//        {
//            // 创建委托实例
//            NumberChanger nc1 = new NumberChanger(AddNum);
//            NumberChanger nc2 = new NumberChanger(MultNum);
//            // 使用委托对象调用方法
//            nc1(25);//10+25
//            Console.WriteLine("Value of Num: {0}", getNum());
//            nc2(5);//35*5
//            Console.WriteLine("Value of Num: {0}", getNum());
//            Console.ReadKey();
//        }
//    }
//}
//委托的多播
//using System;
//delegate int NumberChanger(int n);
//namespace DelegateAppl
//{
//    class TestDelegate
//    {
//        static int num = 10;
//        public static int AddNum(int p)
//        {
//            num += p;
//            return num;
//        }
//        public static int MultNum(int q)
//        {
//            num *= q;
//            return num;
//        }
//        public static int getNum()
//        {
//            return num;
//        }
//        static void Main(string[] args)
//        {
//            // 创建委托实例
//            NumberChanger nc;
//            NumberChanger nc1 = new NumberChanger(AddNum);
//            NumberChanger nc2 = new NumberChanger(MultNum);
//            nc = nc1;//num12
//            nc += nc2;//nc=12*2(不加结果的相加，是运算过程的相连)         
//            // 调用多播
//            nc(2);
//            Console.WriteLine("Value of Num: {0}", getNum());
//            Console.ReadKey();
//        }
//    }
//}
//事件
//using System;
//namespace SimpleEvent
//{
//    using System;
//    /***********发布器类***********/
//    public class EventTest
//    {
//        private int value;

//        public delegate void NumManipulationHandler();


//        public event NumManipulationHandler ChangeNum;
//        protected virtual void OnNumChanged()
//        {
//            if (ChangeNum != null)
//            {
//                ChangeNum(); /* 事件被触发 */
//            }
//            else
//            {
//                Console.WriteLine("event not fire");
//                Console.ReadKey(); /* 回车继续 */
//            }
//        }


//        public EventTest()
//        {
//            int n = 5;
//            SetValue(n);
//        }


//        public void SetValue(int n)
//        {
//            if (value != n)
//            {
//                value = n;
//                OnNumChanged();
//            }
//        }
//    }


//    /***********订阅器类***********/

//    public class subscribEvent
//    {
//        public void printf()
//        {
//            Console.WriteLine("event fire");
//            Console.ReadKey(); /* 回车继续 */
//        }
//    }

//    /***********触发***********/
//    public class MainClass
//    {
//        public static void Main()
//        {
//            EventTest e = new EventTest(); /* 实例化对象,第一次没有触发事件 */
//            subscribEvent v = new subscribEvent(); /* 实例化对象 */
//            e.ChangeNum += new EventTest.NumManipulationHandler(v.printf); /* 注册 */
//            e.SetValue(7);
//            e.SetValue(11);
//        }
//    }
//}
//泛型 泛型允许您编写一个可以与任何数据类型一起工作的类或方法。
using System;
using System.Collections.Generic;

namespace GenericApplication
{
    public class MyGenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }

    class Tester
    {
        static void Main(string[] args)
        {
            // 声明一个整型数组
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            // 设置值
            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }
            // 获取值
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }
            Console.WriteLine();
            // 声明一个字符数组
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            // 设置值
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));//char97,98,99,100,101 abcde
            }
            // 获取值
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
