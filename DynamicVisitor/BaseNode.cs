namespace DynamicVisitor
{
    public class BaseNode
    {
        public virtual void Accept(dynamic visitor)
        {
            visitor.Visit(this);
        }
    }
}