using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class GetLongestName : IVisitor
    {
        public int Longest = -1;
        public string Name;

        public void Visit(Node node)
        {
            foreach (Node element in node.children)
            {
                if (element.Person.Name.Length > Longest)
                {
                    Longest = element.Person.Name.Length;
                    Name = element.Person.Name;
                }
            }
        }
    }
}