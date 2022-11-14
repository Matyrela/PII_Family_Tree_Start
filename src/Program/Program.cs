using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcSum calc = new CalcSum();
            GetOlder getOlder = new GetOlder();
            GetLongestName getLongestName = new GetLongestName();


            Node n1 = new Node("Gonza", 19);
            Node n2 = new Node("El bigote", 33);
            Node n3 = new Node("Palvo", 77);
            Node n4 = new Node("El Pepe", 21);
            Node n5 = new Node("palvo2", 90);
            Node n6 = new Node("OtroNombre", 31);
            Node n7 = new Node("-_-", 87);

            List<Node> NodeList = new List<Node> { n1, n2, n3, n4, n5, n6, n7 };


            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí

            foreach (Node Node in NodeList)
            {
                Node.Accept(calc);
                Node.Accept(getOlder);
                Node.Accept(getLongestName);
            }

            Console.WriteLine(calc.EdadTotal);
            Console.WriteLine(getOlder.Older);
            Console.WriteLine(getLongestName.Name);
        }
    }
}
