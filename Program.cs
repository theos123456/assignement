using System;

namespace employee {
   class salary {
       static void employees(float salary,float hours)
       {
         double hour;
         float salarry;

       }
      public double salary1;   
      public string emptype;  
      public double hour;  
      public double gross;  
   }
   class salarry {
      static void Main(string[] args) {
         salary emp1 = new salary();   
           
         double gross ; 
         double Netsalary ; 
         double Total;

         Console.WriteLine("enter employee type");
         emp1.emptype = Console.ReadLine();
          if(emp1.emptype=="monthly")
          {
              Console.WriteLine("enter salary");
                    emp1.salary1=Convert.ToDouble(Console.ReadLine());
                    gross=emp1.salary1-((emp1.salary1*18)/100);
                    Netsalary=gross-((gross*3)/100);
                    Console.WriteLine("your net salary is {0}",Netsalary);
          }
          else if(emp1.emptype=="temporary")
          {
            Console.WriteLine("enter salary per hour");
                    emp1.salary1=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter hours worked");
                    emp1.hour=Convert.ToDouble(Console.ReadLine());
                    Total=emp1.salary1*emp1.hour;
                    gross=Total-((Total*18)/100);
                    Console.WriteLine("your net salary is {0}",gross);   
          }
          else if (emp1.emptype=="evening")
          {
         Console.WriteLine("enter salary per hour");
                    emp1.salary1=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter hours worked");
                    emp1.hour=Convert.ToDouble(Console.ReadLine());
                    Total=emp1.salary1*emp1.hour;
                    Netsalary=Total+((Total*0.15)/100);
                    gross=Netsalary-((Netsalary*18)/100);
                    Console.WriteLine("your net salary is {0}",gross);     
          }
          else{
              Console.WriteLine("invalid employee type");
          }
         

         Console.ReadKey();
      }
   }
}