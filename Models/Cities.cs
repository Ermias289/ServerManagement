namespace ServerManagement.Models
{
    public class Cities
    {
        private static List<string> _cities = new List<string>
        {
            "New York",
            "Los Angeles",
            "Seattle",
            "Addis Ababa"
        };

        public static List<string> GetAllCities() { return _cities; }
    }
}
