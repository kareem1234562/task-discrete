using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discrete_yask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre first number ");
            int x = int.Parse(Console.ReadLine());        
            Console.WriteLine("entre last number ");
            int y = int.Parse(Console.ReadLine());


            Boolean f = true;
            for (int j = x; j <= y; j++)
            {

                for (int o = 2; o < j; o++)
                {


                    if (j % o == 0)
                    {

                        f = false;
                        break;

                    }
                    else 
                    {
                        f = true;
                        continue;
                    }
                
                
                
                
                
                
                
                
                }
            
            
            
            if(f==true)
                    Console.WriteLine(j);
            
            
            
            
            
            }













        }
    }
}
