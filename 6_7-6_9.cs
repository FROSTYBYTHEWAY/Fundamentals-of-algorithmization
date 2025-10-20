using System;
class Program
{
static void Main()
{
    //6.7 19
    //for(double x=1.1;x<=2.9;x+=0.2)
    //{double y=Math.Pow(x,3)-6*Math.Pow(x,2)+2;
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.7 20
    //for(double x=1;x<=3;x+=0.2){
    //double y=3*Math.Sin(Math.Sqrt(x))+0.25*x-3;
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.7 21
    //for(double x=0;x<=2;x+=0.2)
    //{double y=3*Math.Cos(x)-Math.Abs(x-4)+2;
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.7 22
    //for(double x=1.1;x<=2.9;x+=0.2){
    //double y=0.25*Math.Pow(x,2)-2.8*x-2;
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.7 23
    //for(double x=1;x<=3;x+=0.2)
    //{double y=Math.Log(Math.Pow(x,2))-1.8*Math.Sin(x);
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.7 24
    //for(double x=0.1;x<=3;x+=0.2){
    //double y=Math.Pow(x,2)+4*Math.Sin(Math.PI*x);
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.7 25
    //for(double x=1;x<=2.9;x+=0.2)
    //{double y=0.5*Math.Pow(x,2)-1-Math.Log10(x-3);
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.7 26
    //for(double x=0.1;x<=3;x+=0.2){
    //double y=Math.Sqrt(1+x)-3*Math.Cos(x);
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.7 27
    //for(double x=1;x<=3;x+=0.2)
    //{double y=Math.Log(Math.Pow(x,2))+x-5;
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.7 28
    //for(double x=1;x<=3;x+=0.2){
    //double y=Math.Pow(x,3)-1.75*x+0.75;
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.7 29
    //for(double x=0;x<=2;x+=0.2)
    //{double y=0.5*x-1-2*Math.Cos(x+Math.PI/4);
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.7 30
    //for(double x=1.1;x<=3.1;x+=0.2){
    //double y=3*x-2*Math.Log(x)-5;
    //Console.WriteLine($"x = {x}, y = {y}");}

    //6.8 6
    //Console.Write("Введите x: ");
    //double x=double.Parse(Console.ReadLine());
    //double y;
    //if(x>3.8)
    //y=Math.Log(Math.Abs(1+x));
    //else if(x>=2.8&&x<=3.8)
    //y=Math.Exp(-x);
    //else
    //y=Math.Cos(x);
    //Console.WriteLine($"y = {y:F4}");

    //6.8 7
    //Console.Write("Введите x: ");
    //x=double.Parse(Console.ReadLine());
    //if(x>3.61)
    //y=Math.Exp(-(x+0.8));
    //else if(x>=0&&x<=3.61)
    //y=1;
    //else
    //y=0.5*x;
    //Console.WriteLine($"y = {y:F4}");

    //6.8 8
    //Console.Write("Введите x: ");
    //x=double.Parse(Console.ReadLine());
    //if(x>1.5)
    //y=x;
    //else if(x>=0&&x<=1.5)
    //y=2*Math.Pow(x,2)*Math.Sqrt(Math.Cos(2*x));
    //else
    //y=Math.Exp(-Math.Cos(3*x));
    //Console.WriteLine($"y = {y:F4}");

    //6.8 9
    //Console.Write("Введите x: ");
    //x=double.Parse(Console.ReadLine());
    //if(x>2.5)
    //y=1-Math.Sqrt(Math.Cos(2*x));
    //else if(x>=1&&x<=2.5)
    //y=Math.Pow(x,2)-x;
    //else
    //y=1/(1+Math.Pow(x,2));
    //Console.WriteLine($"y = {y:F4}");

    //6.8 10
    //Console.Write("Введите x: ");
    //x=double.Parse(Console.ReadLine());
    //if(x>4.5)
    //y=2*x;
    //else if(x>=0&&x<=4.5)
    //y=1/(1-Math.Log(Math.Abs(1+Math.Pow(x,2))));
    //else
    //y=Math.Exp(-x);
    //Console.WriteLine($"y = {y:F4}");

    //6.8 11
    //Console.Write("Введите x: ");
    //x=double.Parse(Console.ReadLine());
    //if(x>2)
    //y=Math.Sqrt(Math.Log(Math.Pow(x,2)-1));
    //else if(x>=0&&x<=2)
    //y=-2*Math.Pow(x,3);
    //else
    //y=Math.Exp(Math.Cos(x));
    //Console.WriteLine($"y = {y:F4}");

    //6.8 12
    //Console.Write("Введите x: ");
    //x=double.Parse(Console.ReadLine());
    //if(x>3.5)
    //y=(1-2*Math.Pow(x,3))/Math.Sqrt(Math.Cos(2*x-1));
    //else if(x>=0&&x<=3.5)
    //y=Math.Exp(-Math.Cos(2*x));
    //else
    //y=x;
    //Console.WriteLine($"y = {y:F4}");

    //6.8 13
    //Console.Write("Введите x: ");
    //x=double.Parse(Console.ReadLine());
    //if(x>2.5)
    //y=1/(Math.Pow(x,2)+1);
    //else if(x>=0&&x<=2.5)
    //y=Math.Pow(Math.Sin(x),2);
    //else
    //y=Math.Exp(-Math.Sqrt(Math.Abs(x)));
    //Console.WriteLine($"y = {y:F4}");

    //6.9 8
    //double start=-1;
    //double end=2;
    //double step=0.15;
    //for(double x=start;x<=end;x+=step)
    //{double y=Function(x);
    //Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");}
    //static double Function(double x)
    //{if(x>0)
    //return Math.Log(Math.Abs(Math.Sqrt(x)));
    //else
    //{double sum=0;
    //for(int k=1;k<=5;k++)
    //sum+=k*Math.Pow(x,k);
    //return sum;}}

    //6.9 9
    //start=0;
    //end=5.2;
    //step=0.15;
    //for(double x=start;x<=end;x+=step)
    //{double y=Function(x);
    //Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");}
    //static double Function(double x)
    //{double sum=0;
    //for(int k=1;k<=5;k++)
    //sum+=Math.Pow(-3,k)*Math.Pow(x,k)/Factorial(k);
    //return sum;}
    //static double Factorial(int k)
    //{double result=1;
    //for(int i=1;i<=k;i++)
    //result*=i;
    //return result;}

    //6.9 10
    //start=-2;
    //end=1;
    //step=0.5;
    //for(double x=start;x<=end;x+=step)
    //{double y=Function(x);
    //Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");}
    //static double Function(double x)
    //{if(x>0)
    //{double sum=0;
    //for(int k=3;k<=9;k++)
    //sum+=Math.Pow(x,k);
    //return sum;}
    //else
    //return Math.Pow(2-x,2)-x;}

    //6.9 11
    //start=-1;
    //end=1;
    //step=0.25;
    //for(double x=start;x<=end;x+=step)
    //{double y=Function(x);
    //Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");}
    //static double U(double x)
    //{return Math.Pow(x,2)-Math.Asin(Math.Pow(x,2));}
    //static double Function(double x)
    //{double u=U(x);
    //if(x>Math.PI)
    //return Math.Pow(Math.Abs(u),Math.Log(Math.Abs(u)));
    //else
    //return Math.Pow(u,Math.Log(Math.Abs(u)));}

    //6.9 12
    //start=1;
    //end=3;
    //step=0.2;
    //for(double x=start;x<=end;x+=step)
    //{double y=Function(x);
    //Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");}
    //static double U(double x)
    //{if(x<=2)
    //return(Math.Pow(x,2)+x+1)/(3-x);
    //else
    //return Math.Pow(Math.Sin(x-1),3)+Math.Cos(x+1);}
    //static double Function(double x)
    //{return Math.Exp(U(x));}

    //6.9 13
    //start=-1;
    //end=2;
    //step=0.2;
    //for(double x=start;x<=end;x+=step)
    //{double y=Function(x);
    //Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");}
    //static double Function(double x)
    //{if(x>0)
    //{double sum=0;
    //for(int k=1;k<=7;k++)
    //sum+=Math.Pow(x,k)/Factorial(k);
    //return sum;}
    //else
    //return Math.Asin(Math.Pow(x,Math.PI));}
    //static double Factorial(int k)
    //{double result=1;
    //for(int i=1;i<=k;i++)
    //result*=i;
    //return result;}

    //6.9 14
    //start=1;
    //end=2;
    //step=0.1;
    //for(double x=start;x<=end;x+=step)
    //{double y=Function(x);
    //Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");}
    //static double Function(double x)
    //{double sum=0;
    //for(int k=1;k<=5;k++)
    //sum+=Math.Pow(x,2*k)/Factorial(2*k);
    //return sum;}
    //static double Factorial(int k)
    //{double result=1;
    //for(int i=1;i<=k;i++)
    //result*=i;
    //return result;}

    //6.9 15
    //start=-5;
    //end=5;
    //step=0.5;
    //for(double x=start;x<=end;x+=step)
    //{double y=Function(x);
    //Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");}
    //static double U(double x)
    //{if(x>-3)
    //return Math.Pow(x,2)-x+1;
    //else if(x>=-3&&x<=3)
    //return Math.Asin(x);
    //else
    //return Math.Sin(x-1)+Math.Cos(x+1);}
    //static double Function(double x)
    //{double u=U(x);
    //return 2.51*Math.Pow(x,2)*Math.Log10(Math.Abs(8-Math.Sin(u)));}

    //6.9 16
    //start=-3;
    //end=2;
    //step=0.25;
    //for(double x=start;x<=end;x+=step)
    //{double y=Function(x);
    //Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");}
    //static double Function(double x)
    //{if(x>0)
    //{double sum=0;
    //for(int k=1;k<=5;k++)
    //sum+=Math.Pow(x,k)/Factorial(k);
    //return sum;}
    //else
    //return Math.PI/(3.5*x);}
    //static double Factorial(int k)
    //{double result=1;
    //for(int i=1;i<=k;i++)
    //result*=i;
    //return result;}
}
}