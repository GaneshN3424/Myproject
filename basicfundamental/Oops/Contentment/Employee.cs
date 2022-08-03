using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Contentment
{

    class Department
    {
        int dept_id;
        string dept_name;

        public Department(int dept_id,string dept_name)
        {
            this.dept_id = dept_id;
            this.dept_name = dept_name;
        }
        public void ShowDept()
        {
            Console.WriteLine(dept_id + "  " + dept_name);
        }
    }
    class Employee
    {
        int emp_id;
        int sal;
        string name;
        Department dp;

        Employee(int emp_id,int sal,string name,Department dp)
        {
            this.emp_id = emp_id;
            this.sal = sal;
            this.name = name;
            this.dp = dp;
        }
        void Display()
        {
            Console.WriteLine(emp_id + "  " + name + "  " + sal);
            dp.ShowDept();

        }
        static void Main(string[]args)
        {
            Department d = new Department(21, "Dot net Dept");
            Employee e = new Employee(401, 40000, "Ganesh", d);
            e.Display();
        }
    }
}
