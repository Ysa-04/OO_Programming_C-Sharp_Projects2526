using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace SchoolAdmin2
{
    internal class AdministrativePersonnel : Employee
    {
        private static List<AdministrativePersonnel> allAdministrativePersonnel = new List<AdministrativePersonnel>();
        public static ImmutableList<AdministrativePersonnel> AllAdministrativePersonnel
        {
            get { return allAdministrativePersonnel.ToImmutableList<AdministrativePersonnel>(); }
        }

        public AdministrativePersonnel(string name, DateTime birthDay, Dictionary<string,byte>tasks) : base(name, birthDay, tasks)
        {
            allAdministrativePersonnel.Add(this);
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
    }
}
