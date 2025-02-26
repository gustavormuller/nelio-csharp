using System;
using System.Globalization;

namespace ExercicioAbstratos.Entities
{
    abstract class Pessoa
    {
        public string? Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcularImposto();

        public override string ToString()
        {
            return Nome + ": $ " + CalcularImposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}