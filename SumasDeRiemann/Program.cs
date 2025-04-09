double base_rectangulo, altura_rectangulo;
double partes, area = 0;
double lim_inferior, lim_superior;

// f(x) = -x^3 + 10x^2 + 8x + 10
double f(double x){
    return -(x * x * x) + (10 * x * x) + (8 * x) + 10;
}

// Titulo
Console.WriteLine(new string('-', 50));
Console.WriteLine(new string('*', 17) + "Sumas de Riemann" + new string('*', 17));
Console.WriteLine(new string('-', 50));

// Límite inferior
Console.WriteLine("Ingrese el límite inferior: ");
Console.Write(">>"); lim_inferior = Double.Parse(Console.ReadLine()!);

// Límite superior
Console.WriteLine("Ingrese el límite superior: ");
Console.Write(">>"); lim_superior = Double.Parse(Console.ReadLine()!);

// Cantidad de rectángulos
Console.WriteLine("Ingrese la cantidad de rectangulos: ");
Console.Write(">>"); partes = Double.Parse(Console.ReadLine()!);

// Base de los rectángulos
base_rectangulo = (lim_superior - lim_inferior) / partes;

// Realizar la suma de las áreas de los rectángulos
for (double x = lim_inferior; x < lim_superior; x += base_rectangulo){
    altura_rectangulo = f(x);
    Console.WriteLine("Intervalo: [" + x + ", " + (x + base_rectangulo) + "] | Altura: " + altura_rectangulo);
    area += base_rectangulo * altura_rectangulo;
}

// Mostrar el resultado final
Console.WriteLine("| Area calculada: " + area + " u^2 |");
