using System.Collections.Generic;

namespace task5_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Neurosurgeon doctor1 = new Neurosurgeon("Doc Mitchell", "Burdenko", 15, DiagnosisMethod.CT, false);
            Surgeon doctor2 = new Neurosurgeon("Gregory House", "Johns Hopkins University", 3, DiagnosisMethod.MRI, true);
            List<IDoctor> doctors = new List<IDoctor> { doctor1, doctor2 };
            doctors.ForEach(Console.WriteLine);

            foreach (var doctor in doctors)
            {
                string patient = "Random Patient";
                doctor.Examine(patient);
                doctor.Treat(patient);
            }
            doctors.ForEach(Console.WriteLine);
        }
    }
}