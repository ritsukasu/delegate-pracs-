/*
using System;

public class DelegateExample
{
    // Delegate declaration
    public delegate void MyDelegate(string message);

    // Method matching the delegate signature
    public static void DisplayMessage(string msg)
    {
        Console.WriteLine("Message: " + msg);
    }

    public static void Main()
    {
        // Instantiating delegate
        MyDelegate del = DisplayMessage;

        // Invoking delegate
        del("Hello from delegate!");
    }
}
*/

//Multicast delegate example
/*
using System;

public class MulticastDelegateDemo
{
    public delegate void Notify();

    public static void MethodA() => Console.WriteLine("Method A executed");
    public static void MethodB() => Console.WriteLine("Method B executed");
    public static void MethodC() => Console.WriteLine("Method C executed");

    public static void Main()
    {
        Notify notify = MethodA;
        notify += MethodB;

        notify(); // Invokes both MethodA and MethodB
    }
}
*/

//Delegates with parameters and return values
/*
using System;

public class ReturnDelegateDemo
{
    public delegate int Operation(int x, int y);

    public static int Add(int a, int b) => a + b;
    public static int Multiply(int a, int b) => a * b;

    public static void Main()
    {
        Operation op = Add;
        Console.WriteLine("Addition: " + op(5, 3));

        op = Multiply;
        Console.WriteLine("Multiplication: " + op(5, 3));
    }
}
*/