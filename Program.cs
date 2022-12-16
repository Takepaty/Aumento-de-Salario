
using System;

class Salario
{
  static void Main()
  {
    double salario = 0.00;
    double reajuste = 0.00;
    double novoSalario = 0.00;

    salario = double.Parse(Console.ReadLine());

    double percentual = reajusteSalario(salario);

    reajuste = salario * percentual;
    novoSalario = salario + reajuste;

    Console.WriteLine($"Novo salario: {novoSalario:F2}");
    Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
    Console.WriteLine($"Em percentual: {percentual * 100.00} %");
  }

  static double reajusteSalario(double salario)
  {
    double percentual;
    if (salario <= 400.00) { percentual = 0.15; }
    else if (salario <= 800.00) { percentual = 0.12; }
    else if (salario <= 1200.00) { percentual = 0.10; }
    else if (salario <= 2000.00) { percentual = 0.07; }
    else { percentual = 0.04; }
    return percentual;
  }
}