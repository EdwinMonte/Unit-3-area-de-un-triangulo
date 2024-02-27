class Program
{
    
    static void Main(string[] args)
    {
       
        Triangulo t = new Triangulo(10, 8, 6, 6, 8);

        Console.WriteLine("El área del triángulo usando la fórmula base por altura es: " + t.AreaBaseAltura());
        Console.WriteLine("El área del triángulo usando la fórmula de Herón es: " + t.AreaHeron());
        Console.WriteLine("El área del triángulo usando la fórmula del seno de un ángulo en radianes es: " + t.AreaSeno(Math.PI / 3, true));
        Console.WriteLine("El área del triángulo usando la fórmula del seno de un ángulo en grados es: " + t.AreaSeno(60, false));
        Console.WriteLine("El área del triángulo usando la fórmula del radio del círculo circunscrito es: " + t.AreaCircunscrito());
    }
}
