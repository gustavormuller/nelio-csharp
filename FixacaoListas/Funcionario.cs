using System;
using System.Globalization;

namespace FixacaoListas
{
    class Funcionario
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void IncreaseSalary(double percentage)
        {
            Salario += Salario * percentage / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}