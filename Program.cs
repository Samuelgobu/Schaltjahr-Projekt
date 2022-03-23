using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Der Benutzer soll nach einer jahreszahle gefragt werden und es
//soll ausgegeben werden ob es sich um ein Shaltjahr handelt

namespace Schaltjahr_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long h;
            string wiederholung = "ja";
            do
            {
                Console.WriteLine("Bitte schreiben Sie ein jahr und das Programm wird zeigen, ob es ein Schaltjahr ist oder nein");
                Console.WriteLine("Jahr=");
                h = Convert.ToInt32(Console.ReadLine());

                if (h % 4 == 0)
                {
                    if (h % 100 == 0)
                    {
                        if (h % 400 == 0)
                        {
                            Console.WriteLine("Das ist ein Schaltjahr");
                        }
                        else
                        {
                            Console.WriteLine("Das ist kein Schaltjahr");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Das ist ein Schaltjahr");

                    }

                }
                else
                {
                    Console.WriteLine("Das ist kein Schaltjahr");
                }

                Console.Write("Nochmal? (ja/nein):");
                wiederholung = Console.ReadLine();

            } while (wiederholung == "ja");

           
           
            
            

            
            


            
        }
    }
}
