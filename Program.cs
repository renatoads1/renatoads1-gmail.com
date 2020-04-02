using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;
using System.Diagnostics;
using System.Threading;



namespace robo2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //AutoItX.WinActive("Sem título - Bloco de notas", "the window text to search for.");
            Console.WriteLine("Escreva uma Frase qualquer");
            string txt = Console.ReadLine();
            Console.WriteLine("Escreva a quantidade de vezes");
            int x = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
            
            Process.Start(@"C:\windows\system32\notepad.exe");
            

            AutoItX.MouseClick("LEFT",800,450);
            
            for (int i = 0; i < x; i++) { AutoItX.Send(i.ToString() + txt + "\n"); }
        }
    }
}

