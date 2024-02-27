using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Triangulo
{
    
    private double baseT; 
    private double altura; 
    private double ladoA; 
    private double ladoB; 
    private double ladoC; 

    public Triangulo(double baseT, double altura, double ladoA, double ladoB, double ladoC)
    {
        this.baseT = baseT;
        this.altura = altura;
        this.ladoA = ladoA;
        this.ladoB = ladoB;
        this.ladoC = ladoC;
    }
    
    ~Triangulo() { }
    
    public double AreaBaseAltura()
    {
        return (baseT * altura) / 2;
    }

    public double AreaHeron()
    {
        double s = (ladoA + ladoB + ladoC) / 2;
        return Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));
    }

    public double AreaSeno(double angulo, bool radianes) 
    {
        if (!radianes)
        {
            angulo = angulo * Math.PI / 180;
        }
        return (ladoA * ladoB * Math.Sin(angulo)) / 2;
    }

    public double AreaCircunscrito()
    {
        double s = (ladoA + ladoB + ladoC) / 2;
        double r = (ladoA * ladoB * ladoC) / (4 * Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC)));
        return (Math.PI * r * r) / 4;
    }
}
