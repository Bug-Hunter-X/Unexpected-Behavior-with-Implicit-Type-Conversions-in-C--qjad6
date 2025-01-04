public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static explicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = (MyClass)5; // Explicit conversion from int to MyClass
        int value = (int)obj1;  // Explicit conversion from MyClass to int
        Console.WriteLine(value); // Output: 5

        MyClass obj2 = new MyClass(10);
        int value2 = (int)obj2 + 5; // Explicit conversion from MyClass to int, then addition
        Console.WriteLine(value2); // Output: 15

        MyClass obj3 = (MyClass)((int)obj2 + 5); // Explicit conversion from int to MyClass after addition
        Console.WriteLine(obj3.MyProperty); // Output: 15
    }
}
//This solution uses explicit conversions to make the code more readable and less prone to errors. 