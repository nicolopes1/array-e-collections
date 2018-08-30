using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_5_array_e_collections
{
    class Program
    {
        static void Main(string[] args)
        {
           /* // ----- array ------ //
            string[] a = new string[4];
            // ou   var a = new string[3];

            a[0] = "Nicollas";
            a[1] = "x";
            a[2] = "y";
            a[3] = "t";

            Array.Sort(a);

            foreach(string nome in a) // ou var nome
            {
                Console.WriteLine(nome);
            }

            int size = a.Length;
            
            if(Array.Exists(a1, e=> e.IndexOf("Nico") =! -1 )){
            Console.WriteLine("Existe");
            }

            */

            // ------ collection ------ //

            List<string> a = new List<string>(); 
            // ou var a = new List<String>();

            a.Add("Nicollas");
            a.Add("x");
            a.Add("w");
            a.Add("t");  

            foreach (var nome in a)
            {
                Console.WriteLine(nome);
            }

            if (a.Exists(existe => existe == "Nicollas"))
            {
                Console.WriteLine("Encontrado!");
            }
            //int size_list = a.Count;

            Console.Read();

             
        }
    }
}
