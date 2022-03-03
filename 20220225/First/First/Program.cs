using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpLib;

namespace First
{
    internal class Program
    {
        static void Main(string[] args) // Main 함수는 약속된 표현 (프로그램 진입점)
        {
            Emp emp = new Emp();
            emp.Salary = 100;

            Console.WriteLine(emp.Salary);
        }
    }
}
