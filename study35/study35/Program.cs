using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello; //using 키워드로 namespace 편하게 쓸 수 있음

namespace Hello
{
    public class Say
    {
        public void SayHello()
        {
            Console.WriteLine("안녕하세요");
        }
    }
}

namespace study35
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello.Say sa = new Say();
            sa.SayHello();



        }
    }
}
