using System;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class PrintVisitor:IVisitor
    {

        public void Visit(NodeA n)
        {
            System.Console.WriteLine("Node A");
        }

        public void Visit(NodeB n)
        {
            System.Console.WriteLine("Node B");
        }
    }
}
