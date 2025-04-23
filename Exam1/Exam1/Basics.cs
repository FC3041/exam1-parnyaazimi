namespace Exam1;
using System.Diagnostics;

public class Q1_Add
{
    public static double Add(double enter1,double enter2)
    {
        return enter1+enter2;
    }
}

public class Basics
{
    public static void Q2MultiplyAndReset(ref int enter1 ,ref int enter2)
    {
        enter1=enter1*enter2;
        enter2=1;
    }

    public static void Q5TryCatchFinally(bool Throw,List<string> lists,bool Catch=true)
    {
    }
}

public struct Type1
{
    public int Count{get;set;}
}


public class Type2
{
    public int Count{get;set;}
}


public class Q4Person
{
    public string Name{get;set;}
    public int Age{get;set;}
    public Q4Person(string _name,int _age)
    {
        Name=_name;
        Age=_age;
    }

    public string Introduce()=>$"Hello, my name is {Name} and I am {Age} years old.";
}




public class Q6Temperature
{
    public double celsius;
    public double fahrenheit;

    public double Celsius
    {
        get=>celsius;
        set
        {
            celsius=value;
            fahrenheit=(celsius*9/5)+32;
        }
    }
    public double Fahrenheit
    {
        get=>fahrenheit;
        set
        {
            fahrenheit=value;
            celsius=(fahrenheit-32)*5/9;
        }
    }
}



public interface IShape
{
    public double GetArea();
    public double GetPerimeter();
}
public class Q7Circle:IShape
{
    public double R{get;set;}
    public Q7Circle(double _R)
    {
        R=_R;
    }

    public double GetArea()=>Math.PI*R*R;

    public double GetPerimeter()=>2*Math.PI*R;
}


public class Q7Rectangle:IShape
{
    public double Height{get;set;}
    public double Width{get;set;}
    public Q7Rectangle(double _Height,double _Width)
    {
        Height=_Height;
        Width=_Width;
    }

    public double GetArea()=>Height*Width;

    public double GetPerimeter()=>2*(Height+Width);
}

public class ShapeUtils
{
    public static double result;
    public static double Q7TotalArea(IShape[] shapes)
    {
        foreach (var shape in shapes)
        {
            result+=shape.GetArea();
        }
        return result;
    }
}

