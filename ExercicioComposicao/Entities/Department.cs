using System;

namespace ExercicioComposicao.Entities
{
    class Department
    {
        public string? Name { get; set; }

        public Department()
        {

        }

        public Department(string name)
        {
            Name = name;
        }
    }
}