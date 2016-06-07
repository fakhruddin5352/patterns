using System;
using System.Text;

namespace DynamicVisitor
{
    public class PrintVisitor : IVisitor
    {
        public void Visit(BaseNode node)
        {
            VisitI(node as dynamic);
        }
        private void VisitI(BaseNode n)
        {
            System.Console.WriteLine("CatchAll");
        }

        private void VisitI(NodeA n)
        {
            System.Console.WriteLine("Node A");
        }

        private void VisitI(NodeB n)
        {
            System.Console.WriteLine("Node B");
        }
    }
}
