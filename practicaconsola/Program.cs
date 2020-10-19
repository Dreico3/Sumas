using System;

namespace practicaconsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string b="";
            string aux="";
            string a = "20+60+50";
            string operador = "";
            int numero = 0;
            int cont=0;
           
            Console.WriteLine("-------------------");
            foreach (var num in a)
            {
                aux = Convert.ToString(num);

                if (aux.Equals("+"))
                {
                    
                    numero += int.Parse(b);
                   
                    b = "";
                    cont++;
                    operador = "+";

                }
                else if (aux.Equals("-"))
                {
                    
                    numero -= int.Parse(b);
                    
                    b = "";
                    cont++;
                    operador = "-";
                }
                else if (aux.Equals("*")) { }

                else
                {
                    b = b + aux;
                }
            }
            if (!b.Equals(""))
            {
                if (operador.Equals("+"))
                {
                    numero += int.Parse(b);
                    b = "";
                    Console.WriteLine("b es distiento de 0");

                }else if (operador.Equals("-"))
                {
                    numero -= int.Parse(b);
                    b = "";
                    Console.WriteLine("b es distiento de 0");

                }
            }
            Console.WriteLine(b + "Resulatado--->>" + numero + " cont-->" + cont);
        }
    }
}
