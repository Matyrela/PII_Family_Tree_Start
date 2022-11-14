using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Node : IElement
    {
        public Person Person;

        public List<Node> children = new List<Node>();

        public ReadOnlyCollection<Node> Children
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string name, int age)
        {
            this.Person = new Person(name, age);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
