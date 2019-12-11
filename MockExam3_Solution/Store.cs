namespace MockExam3_Solution
{
    public class Store
    {
        public double MonthlyRevenue { get; set; }
        public int NumberOfEmployees { get; set; }

        public string StoreName { get; set; }

        public string SuiteNumber { get; set; }

        public Store(double revenue, int employees, string name, string suite)
        {
            MonthlyRevenue = revenue;
            NumberOfEmployees = employees;
            StoreName = name;
            SuiteNumber = suite;
        }

        public override string ToString()
        {
            return $"{StoreName}\nSuite Number: {SuiteNumber}\nNumber of Employees: {NumberOfEmployees}\nMonthly Revenue: {MonthlyRevenue:C}";
        }
    }
}