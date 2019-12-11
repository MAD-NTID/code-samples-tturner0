namespace MockExam3_Solution
{
    public class Clothing : Store
    {
        public string ClothingStyle { get; set; }

        public Clothing(double revenue, int employees, string name, string suite, string style) :
            base (revenue, employees, name, suite)
        {
            ClothingStyle = style;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nClothing Style: {ClothingStyle}";
        }
    }
}