using System.Collections.Generic;
using System.Linq;

namespace DynamicVisitor
{
    public class NodeA:BaseNode
    {
        private readonly List<BaseNode> nodes;

        public NodeA(params BaseNode[] nodes)
        {
            this.nodes = nodes.ToList();
        }

        public override void Accept(dynamic visitor)
        {
            visitor.Visit(this);
            nodes.ForEach(x => x.Accept(visitor));
        }


    }
}