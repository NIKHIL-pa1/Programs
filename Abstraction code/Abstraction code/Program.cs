using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_code
{
    internal class Program
    {
        class addition
        {
            int num1,num2,add;
            string name;
            public addition(int no1,int no2,string nm)
            {
                this.num1 = no1;
                this.num2 = no2;  
                this.name = nm;
            }

            void addnum()
            {
                add = num1 + num2;
                Console.WriteLine(add);
            }
            public void callmethod()
            {
                Console.WriteLine(this.name);
                this.addnum();
            }
        }
        static void Main(string[] args)
        {
            addition obj = new addition(3, 5,"Nikhil");
            obj.callmethod();
        }
    }
}
