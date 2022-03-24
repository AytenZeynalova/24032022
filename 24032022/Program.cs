using System;

namespace _24032022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Worker Classimiz olur. Ishcinin saat bashi qazandigi pul ve bu ay nece saat ishlediyini bildiren
            //fieldler olur.Maashi hesablayan methodu olur.Methodda isçinin bu ay qazanacagi
            //meblegi geri qaytarir.Ishcinin maashini daxil etmeden classdan instance almak olmasın.


            //Worker isci = new Worker(Convert.ToDouble (Console.ReadLine()));
            ////isci.salaryForHour = Convert.ToDouble(Console.ReadLine());
            //isci.hour = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(salary(isci.,isci.hour));
            double salary = 1;
            Worker worker1 = new Worker(salary);
            worker1.salaryForHour = Convert.ToDouble(Console.ReadLine());
            worker1.hour=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Salary(worker1.salaryForHour, worker1.hour)); 
           
        }

        static double Salary(double salaryForHour, int hour )
        {
            double salary = hour * salaryForHour;
            return salary;
        }
    }
}
