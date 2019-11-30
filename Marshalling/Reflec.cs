using System;
using System.Reflection;

namespace Task3
{
    class MyClass
    {
        public virtual int AddNum(int a, int b)
        {
            return a + b;
        }
    }

    class MyMainClass
    {
        public static int Main()
        {
            Console.WriteLine("\nReflection.MethodInfo");
            MyClass myClassObj = new MyClass();
            Type myTypeObj = myClassObj.GetType();
            MethodInfo myMethodInfo = myTypeObj.GetMethod("AddNum");
            object[] mParam = new object[] { 5, 10 };

            Console.WriteLine("\nFirst method - " + myTypeObj.FullName + " returns " +  
                         myMethodInfo.Invoke(myClassObj, mParam) + "\n");
            return 0;
        }
    }
}
