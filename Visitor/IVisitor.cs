namespace Visitor
{
    public interface IVisitor
    {
        void Visit(NodeA n);
        void Visit(NodeB n);
    }
}