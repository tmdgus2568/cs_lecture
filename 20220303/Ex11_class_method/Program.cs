using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_class_method
{
    public class Member
    {
        private string name;

        // Member 클래스의 객체 생성시 default 생성자를 사용할 수 없다.
        
        public Member()
        {

        }
        public Member(string name)
        {
            this.name = name;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Member member = new Member("홍승현"); // 생성자 함수 호출
            Member member2 = new Member(); // 생성자 함수 호출


        }
    }
}
