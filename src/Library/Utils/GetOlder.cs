using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class GetOlder : IVisitor
    {
        public int Older = -1;
        public void Visit(Node node)
        {
            foreach (Node element in node.children)
            {
                if (element.Person.Age > Older)
                {
                    Older = element.Person.Age;
                }
            }
        }
    }
}