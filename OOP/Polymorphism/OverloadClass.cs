namespace Polymorphism;

public class OverloadClass
{
    public int Add(int a, int b) => a + b;
    public int Add(int a, int b, int c) => a + b +c;
    public float Add(float a, float b) => a + b;
    public decimal Add(decimal a, decimal b) => a + b;
    
}