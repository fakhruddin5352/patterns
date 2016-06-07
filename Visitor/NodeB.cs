namespace Visitor
{
    public class NodeB:INode
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}