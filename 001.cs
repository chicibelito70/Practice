//Realizar un programa que lea por teclado dos números, 
//si el primero es mayor al segundo informar su suma y diferencia, 
//en caso contrario informar el producto y la división del primero respecto al segundo.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros{
    class programa{
        static void Main(string[] args)
        {
            int n, m;
            string linea;
            Console.Write("Ingrese un valor: ");
            linea=Console.ReadLine();
            n= int.Parseint(linea);
            Console.Write("Ingrese otro valor: ");
            linea=Console.ReadLine();
            m=int.Parseint(linea);
            if(n>m){
                int sum, dif;
                sum=n+m;
                dif= n-m;
                Console.WriteLine("La suma de los dos valores es: ",sum);
                Console.WriteLine("La diferencia de los valores es: ",dif);
            }
        }
    }
}
