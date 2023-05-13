namespace task5_csharp
{
    internal interface IDoctor
    {
        public string Name { get; protected set; }

        void Examine(String patientName);
        void Treat(String patientName);
    }
}
