# Calculadora de sumas de Riemann
Este proyecto forma parte de mis actividades para la clase de Métodos Numéricos. Oficialmente, es mi propuesta de solución para la Actividad 13 de esa misma materia.
Autor: Angel H. Lizardo

## ¿Qué son las sumas de Riemann?
Las integrales rectangulares, mejor conocidas como sumas o integrales de Riemann, son un método exhaustivo para encontrar un valor aproximado del área debajo de una curva.

## Formula
$$ \sum^{n}_{i=1} {f(x_i) \cdot \Delta x} $$
Donde:
* $ b $ es el límite superior de la integral
* $ a $ es el límite inferior de la integral
* $ n $ es el número de divisiones, o rectángulos

## Aplicación
El código en C# que realiza el cálculo de las sumas de Riemann es el siguiente:
```csharp
    for (double x = lim_inferior; x < lim_superior; x += base_rectangulo){
        altura_rectangulo = f(x);
        area += base_rectangulo * altura_rectangulo;
    }
```
Donde:
* $ x $ se iguala al límite inferior, y esta irá incrementando constantemente usando la base del rectángulo.
* Por cada paso, se calcula el valor $y$ correspondiente del valor $x$, lo que se toma como la altura del rectángulo que se está calculando actualmente
* A la variable del área, se le suman constantemente los valores de la altura y la base del rectángulo, puesto que al final la aproximación es la suma de las áreas de los rectángulos.