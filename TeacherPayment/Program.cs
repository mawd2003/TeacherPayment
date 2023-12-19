using TeacherPayment;

namespace ConsoleApp1
{
    class test
    {
        public static void Main()
        {
            Teacher th = new Teacher("123", "Ali", "Ahmadi", 40, 40000);
            double pay = th.Payment();
            Console.WriteLine("Teacher payment is : {0}", pay);
            Console.ReadKey();
        }
    }
}

