using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProjectNew
{
    class Employee
    {

        private int sal;
        private int dept;

        public Employee(int salary, int deaprtment)
        {
            this.sal = salary;
            this.dept = deaprtment;
        }

        static void Main(string[] args)
        {
            List<Employee> obj = new List<Employee>();
            obj.Add(new Employee(2001, 1));
            obj.Add(new Employee(5000, 2));
            obj.Add(new Employee(12000, 3));
            obj.Add(new Employee(32000, 4));
            obj.Add(new Employee(8000, 1));
            obj.Add(new Employee(10000, 2));
            obj.Add(new Employee(33000, 3));
            obj.Add(new Employee(9800, 4));
            obj.Add(new Employee(72000, 1));
            obj.Add(new Employee(5500, 2));
            obj.Add(new Employee(1000, 3));
            obj.Add(new Employee(2000, 4));
            obj.Add(new Employee(2003, 1));
            obj.Add(new Employee(2004, 2));
            obj.Add(new Employee(2005, 3));
            obj.Add(new Employee(2006, 4));

            var value = from emp in obj
                         where emp.sal >= 20000
                         group emp by emp.sal into result
                         select result.Count();

            

            foreach (var item in value)
            {
                Console.WriteLine(Convert.ToInt32(item));
            }
            Console.ReadLine();

        }
    }

}


