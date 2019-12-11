namespace MockExam3_Solution
{
    public class Restaurant : Store
    {
        public string Type { get; set; }

        public bool FullService { get; set; }

        public Restaurant(double revenue, int employees, string name, string suite, string type, bool service) :
        base (revenue, employees, name, suite)
        {
            Type = type;
            FullService = service;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nType of Restraurant: {Type}\nFull Services?: {(FullService ? "Yes" : "No")}";
        }
    }
}