using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DynamicVisitor;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodeB2 = new NodeB();
            var nodeA2 = new NodeA(nodeB2);
            var nodeA1 = new NodeA(nodeB2,nodeA2,new NodeC());
            nodeA1.Accept(new PrintVisitor());
        }
    }
}
