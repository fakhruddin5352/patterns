namespace Visitor
{
    public interface INode{
        void Accept(IVisitor visitor);
    }
}