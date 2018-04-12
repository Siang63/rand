using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand
{
    class Program
    {
        static void Main(string[] args)
        {
            // 將所有號碼都放入List中
            List<int> numbers = new List<int>();
            for (int i=1;i<=42;i++)
            {
                numbers.Add(i);
                
            }

            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {

                //隨機挑選其中一個印出                   

                int r = rand.Next(1, numbers.Count);
                Console.Write(numbers[r]+" ");

                //並從List中刪除                                       
                numbers.RemoveAt(r);
            }


            Console.ReadLine();
        }
    }
}
