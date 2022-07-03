using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Salary //parent
    {
        int ID;
        string Name;
        int salary;
        string Emp_category;
        public int gros_salary;
        public void Setdata(int id, string nam, int sal, string cat) 
        {
            ID = id;
            Name = nam;
            salary = sal;
            Emp_category = cat;
        
        }
        public void GrossSalary(int med_allow, int fuel_allow)
        {
            gros_salary = salary + med_allow + fuel_allow;

        }
        public void Getdata()
        {
            Console.WriteLine("Employee ID: {0}",ID);
            Console.WriteLine("Employee Name: {0}",Name);
            Console.WriteLine("Employee Salary: {0}",salary);
        Console.WriteLine("Employee Category: {0}",Emp_category);
            Console.WriteLine("Gross Salary is: {0}", gros_salary);
        }
       
    
    }
    internal class Program { 
        static void Main(string[] args)
        {
            Salary s = new Salary();
            s.Setdata(1,"Hamza",310000,"Enigneer");
            s.GrossSalary(21000,105000);
            s.Getdata();
            Console.WriteLine();
            s.Setdata(2, "Usama", 310000, "Manager");
            s.GrossSalary(52500, 210000);
            s.Getdata();
            Console.WriteLine();
            s.Setdata(3, "Ibrahim", 310000, "Analysts");
            s.GrossSalary(31500, 168000);
            s.Getdata();
        }
    }
}
