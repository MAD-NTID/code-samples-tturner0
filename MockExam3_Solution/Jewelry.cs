namespace MockExam3_Solution
{
    public class Jewelry : Store
    {
        public bool DoesRepairs { get; set; }

        public bool ReplaceBatteries { get; set; }

        public Jewelry(double revenue, int employees, string name, string suite, bool repairs, bool batteries) :
        base (revenue, employees, name, suite)
        {
            DoesRepairs = repairs;
            ReplaceBatteries = batteries;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nHave these type of services?: \n\tRepairs: {(DoesRepairs ? "Yes" : "No")}\n\tBatteries Replacement: {(ReplaceBatteries ? "Yes" : "No")}";
        }
    }
}