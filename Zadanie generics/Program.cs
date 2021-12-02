using System;

namespace Zadanie_generics
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("Введите имя владельца счета 1");
            string name1 = Console.ReadLine();
            Console.WriteLine("Введите баланс счета 1");
            double balans1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите номер счета 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Schet<int> schet1 = new Schet<int>(num1, balans1, name1);
            Console.WriteLine("Введите имя владельца счета 2");
            string name2 = Console.ReadLine();
            Console.WriteLine("Введите баланс счета 2");
            double balans2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите номер счета 2");
            string num2 = Console.ReadLine();
            Schet<string> schet2 = new Schet<string>(num2, balans2, name2);
            schet1.OutBalans();
            schet1.OutName();
            schet1.OutName();
            schet2.OutBalans();
            schet2.OutName();
            schet2.OutName();
          
        }



    }
    class Schet<T>
    {
        private T Num { get; set; }
        private double Balans { get; set; }
        private string Name { get; set; }
        public Schet (T num, double balans, string name)
        {
            Num = num;
            Balans = balans;
            Name = name;
        }
        public void InNum()
        {
            Console.WriteLine("Введите номер счета");
            string str = Console.ReadLine();
            Num = (T)Convert.ChangeType(str, typeof(T));

        }
        public void InBalans()
        {
         Console.WriteLine("Введите баланс счета");
         Balans = Convert.ToDouble(Console.ReadLine());
        }
        public void InName()
        {
         Console.WriteLine("Введите имя владельца счета");
         Name = Console.ReadLine();
        }
        public void OutNum()
        {
            Console.WriteLine("Номер счета {0}", Num);
            Console.ReadKey();

        }
        public void OutBalans()
        {
            Console.WriteLine("Баланс счета равен {0}", Balans);
            Console.ReadKey();
        }
        public void OutName()
        {
            Console.WriteLine("Имя владельца счета {0}", Name);
            Console.ReadKey();
        }

    }   
}






                    
           
