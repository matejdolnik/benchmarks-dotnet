namespace SealedClass;

public class ClassTypes
{
    public class BaseClass
    {
        public virtual int IntMethod => 55;
        public virtual string StringMethod => "string";
        public virtual void VoidMethod() { }
    }

    public class OpenClass: BaseClass
    {
        public override int IntMethod => 155;
        public override string StringMethod => "alsostring";
        public override void VoidMethod() { }
    }

    public sealed class SealedClass : BaseClass
    {
        public override int IntMethod => 155;
        public override string StringMethod => "alsostring";
        public override void VoidMethod() { }
    }
}