using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    public class Person
    {
        private string name;
        private int balance;

        public Person()
        {
            this.name = "홍길동";
            this.balance = 0;
        }

        public Person(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }
        // 입금 
        public void deposit(int b)
        {
            this.balance += b;
            Console.WriteLine("잔액: {0}", this.balance);
            
        }
        // 출금
        public void withdraw(int b)
        {
            if(this.balance - b < 0)
            {
                Console.WriteLine("잔액이 부족하여 출금이 불가합니다.");
                Console.WriteLine("잔액: {0}", this.balance);
                return;
            }
            this.balance -= b;
            Console.WriteLine("잔액: {0}", this.balance);
        }
    }
}
