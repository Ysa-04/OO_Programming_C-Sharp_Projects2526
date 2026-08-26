using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace SchoolAdmin2
{
    internal class AdministrativePersonnel : Employee
    {
        public static ImmutableList<AdministrativePersonnel> AllAdministrativePersonnel
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<AdministrativePersonnel>();
                foreach (Person pers in Person.AllPersons)
                {
                    if (pers is AdministrativePersonnel)
                    {
                        builder.Add((AdministrativePersonnel)pers);
                    }
                }

                return builder.ToImmutable();
            }
        }
        public AdministrativePersonnel(string name, DateTime birthDate, Dictionary<string, byte> tasks) : base(name, birthDate, tasks)
        {
        }

        public override double DetermineWorkload()
        {
            double total = 0;
            foreach (var task in Tasks)
            {
                total += task.Value;
            }
            return total;
        }

        public override uint CalculateSalary()
        {
            double basic = 2000 + (Seniority / 3 * 75); //per 3 jaar in dienst
            double breuk = DetermineWorkload() / 40;
            return (uint)(basic * breuk);
        }

        public override string GenerateNameCard()
        {
            return $"{this.Name} (ADMINISTRATIE)";
        }
        public override string ToString()
        {
            return base.ToString() + "\nAdministratief Personeel";
        }
    }
}
