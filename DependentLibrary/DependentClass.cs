using BaseLibrary;

namespace DependentLibrary
{
    public class DependentClass
    {
        public void Method()
        {
            var baseClass = new BaseClass();
            baseClass.Method();
        }
    }
}
