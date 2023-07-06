
class Program
{
    static void Main()
    {
        int a = 2;
        double b = a;

        double c = 7.5;
        int d = (int)c;

        Parent parent = new Parent();
        Child child = new Child();

        parent.MethodParentB();
        parent.MethodParentA();

        child.MethodParentB();
        child.MethodParentA();
        child.MethodChildA();
        child.MethodChildB();

        Parent parent2 = child;
        parent2.MethodParentB();
        parent2.MethodParentA();
        // Error, karena parent tidak memiliki dan tidak mewarisi method dari child 
        //parent2.MethodChildA();
        //parent2.MethodChildB();

        // Error, tidak bisa cast dari parent ke child
        Child child1 = (Child)parent;
        child1.MethodParentB();
        child1.MethodParentA();
        child1.MethodChildB();
        child1.MethodChildA();
    }
}

public class Parent
{
    public void MethodParentA()
    {
        Console.WriteLine("Ini Method Parent A");
    }
    public void MethodParentB()
    {
        Console.WriteLine("Ini Method Parent B");
    }
}
public class Child : Parent
{
    public void MethodChildA()
    {
        Console.WriteLine("Ini Method Child A");
    }
    public void MethodChildB()
    {
        Console.WriteLine("Ini Method Child B");
    }
}