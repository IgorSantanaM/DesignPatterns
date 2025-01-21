using FacadePattern.SubSystem;

namespace FacadePattern
{
    public class Facade
    {
        public void Operation1()
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            Class3 class3 = new Class3(class2);

            class3.Operation4(class1);
            class1.Operation2();
            class2.Operation3();
        }
    }
}
