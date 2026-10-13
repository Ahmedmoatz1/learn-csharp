using System;
namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        int x = 5;
        int y = 6;
        string f = "ahmed";
        string fristname = "Ahmed";
        string lastname = "Moatz";
        string fullName = fristname + lastname;
        double number1 = 9.88;
        int number2 = (int)number1;

         // من هنا كل حاجة هتطلع أحمر

        Console.WriteLine(number2);
        Console.WriteLine(number1);
        Console.WriteLine("ajed");
        Console.WriteLine(x + y + f);
        Console.Write("'ahmed'");
        Console.WriteLine(fullName);
        Console.WriteLine("Enter Age");
        int age = int.Parse(Console.ReadLine());
        if(age > 10)
      {
         Console.WriteLine("age is "+age);
      }
      else
      {
         Console.WriteLine("age is not "+age);
        
      }
      Console.WriteLine("enter name");
      string name = Console.ReadLine();
      for(int i =0 ; i <  name.Length ; i++)
      {
        Console.WriteLine(name[i]);
      }
    }
  }
}