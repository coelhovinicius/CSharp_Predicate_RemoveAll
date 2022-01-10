/* PREDICATE (System) - Representa um metodo que recebe um objeto do tipo T e retorna um valor Booleano 
 * 
 *  public delegate bool Predicate<in T>(T obj);
 */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Collections.Generic;
using Aula223_Predicate_RemoveAll.Entities;

namespace Aula223_Predicate_RemoveAll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // RemoveAll utilizado para remover os produtos com preco maior ou igual a 100.00
            //list.RemoveAll(p => p.Price >= 100.0); // Funcao Lambda
            list.RemoveAll(ProductTest); /* Predicate - Referencia para a funcao ProductTest, recebendo um objeto e
                                          * retornando um booleano */
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        // Funcao auxiliar que recebe um produto e devolve um booleano
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
