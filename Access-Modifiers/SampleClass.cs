using System;

public class SampleClass
{
    public int publicField; // Herkese açık
    private int privateField; // Sadece bu sınıf içinden erişilebilir
    protected int protectedField; // Bu sınıf ve alt sınıflar tarafından erişilebilir
    internal int internalField; // Aynı derleme içindeki sınıflar tarafından erişilebilir
    protected internal int protectedInternalField; // Hem bu sınıf hem de alt sınıflar, aynı derleme içindeki sınıflar tarafından erişilebilir

    public void AccessFields()
    {
        Console.WriteLine(publicField); // Doğrudan erişilebilir
        Console.WriteLine(privateField); // Hata! privateField sadece bu sınıf içinde erişilebilir
        Console.WriteLine(protectedField); // Doğrudan erişilemez
        Console.WriteLine(internalField); // Doğrudan erişilebilir
        Console.WriteLine(protectedInternalField); // Doğrudan erişilebilir
    }
}
