using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 충돌을 막아준다
// 같은  class여도 namespace가 다르면 다름 
namespace EmpLib
{
    public class Emp // 다른 클래스를 도와주는 역할
    {
        // 정보를 저장 (속성)
        // 상태속성 , 고유속성, 부품속성(다른 클래스 참조)

        // public : 공용자원, 직접 할당 가능
        // private : 간접 할당 가능
        private int empno;
        private string ename;
        private int salary;
        public string job;

        // java적인 함수
        // 간접할당을 함수로 가능하게 한다.
        // public int getEmpno() { return empno; } // 읽기 전용함수
        // public void setEmpno(int empno) { this.empno = empno; }; // 쓰기 전용함수

        public int Empno
        {
            get { return empno; }
            set { empno = value; }
        }

        public String Ename
        {
            get { return ename; }
            set { ename = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

    }
}

