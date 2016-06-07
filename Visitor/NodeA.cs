using System.Collections.Generic;
using System.Linq;

namespace Visitor
{
    public class NodeA :INode
    {
        private readonly List<INode> nodes;

        public NodeA(params INode[] nodes){
            this.nodes = nodes.ToList();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            nodes.ForEach(x=>x.Accept(visitor));
        }
    }
}