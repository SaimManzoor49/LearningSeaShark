// See https://aka.ms/new-console-template for more information

using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

// namespace Learning{
//  class Methords
// {
//    public static void Main(String[] args)
//   {


/*    int x = 3;
    int y = 4;
    int c;

    Console.WriteLine('Multiplication Here');
    c =x*y;
    Console.WriteLine(c);

    Console.WriteLine('Subtraction Here');
    c = x - y;
    Console.WriteLine(c);

    Console.WriteLine('Addition Here');
    c = x + y;
    Console.WriteLine(c);

    Console.WriteLine('Division Here');
    c = x / y;
    Console.WriteLine(c);
*/

//double a = -3.423;
// double b = Math.Pow(a, 2);
//double b = Math.Sqrt(a);
//double b = Math.Abs(a);
//double b = Math.Round(a);
// Ceiling, Floor, Max(x,y), Min(x,y) 
//double b = Math.Round(a);
//Random r = new Random();
//int randNum = r.Next(1, 7);

//int d = r.Next(1, 7) + 100;
//Console.WriteLine(d);

//Console.WriteLine("Hello World");



////////////////////////// Find Hypotenous//////////////////////////

//Console.WriteLine("Enter Side A");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter Side B");
//double b = Convert.ToDouble(Console.ReadLine());


//double c = (Math.Pow(a, 2)) + (Math.Pow(b, 2));
//c = Math.Sqrt(c);

//Console.WriteLine("Ans:" + c);



//////////////////////Loops/////////////////////


/*for (int i=0; i < 5; i++)
{
    Console.WriteLine("Saim\nUsman\nAli");
} */



//int i = 0;
//while(i<6)
//{
//   Console.WriteLine(i);
//    i++;
//}

//int i = 0;
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 6);

//string[] i = { "0" , "1" , "2" , "3" , "4" , "5" };

//foreach (string c in i)
//{
//    Console.WriteLine(c);
//}








//////////////////////////Conditional Statments///////////////////

/* Random ran = new Random();
int i = ran.Next(1,10);

if (i > 5)
{ 
    Console.WriteLine("i>5 : i="+i);
}else if (i < 5)
{
    Console.WriteLine("i<5 : i=" + i);
} */


/*            switch (i)
            { 
                case 0:
                  Console.WriteLine("0");
                    break;
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("i>5");
                    break;

            }
                    */














// Console.ReadKey(); 
//   }
//}





//}





//////////////////// Little Bit OOP////////////////




namespace OOP
{
    public class Concat
    {

        string s1;
        string s2;
        string s3 = "";

        public Concat(string s1, string s2)
        {
            this.s1 = s1;
            this.s2 = s2;
        }

        public void mergeStrings()
        {
            this.s3 = string.Concat(s1, s2);
        }

        public void showString()
        {
            Console.WriteLine(this.s3);
        }


    }

    class MAIN
    {
        public static void Main(string[] args)
        {
            Concat s = new Concat("Saim ", "Manzoor");

            s.mergeStrings();
            s.showString();


            Console.ReadKey();

        }
    }


}
