namespace Library
{
    public class CalcSum : IVisitor
    {
        public int EdadTotal { get; set; }

        public CalcSum()
        {
            this.EdadTotal = 0;
        }
        public void Visit(Node node)
        {
            EdadTotal = EdadTotal + node.Person.Age;
        }
    }
}