namespace CongApp.Models
{
    public static class MeetingFactory
    {
        const string kayamanan = "KAYAMANAN MULA SA SALITA NG DIYOS";
        const string mahusay = "MAGING MAHUSAY SA MINISTERYO";
        const string pamumuhay = "PAMUMUHAY BILANG KRISTYANO";
        public static Meeting CreateMidWeek(DateTime date, string week)
        {
            return new Meeting
            {
                Date = date,
                Week = week,
                Type = "Midweek",
                Assignments = new List<Assignment>
                {
                   new Assignment
                   {
                       Task = "Main Topic",
                       Section = kayamanan
                   },
                   new Assignment
                   {
                       Task = "Espiritwal na hiyas",
                       Section = kayamanan
                   },
                   new Assignment
                   {
                       Task = "Pagbabasa ng Bibliya",
                       Section = kayamanan
                   },
                   new Assignment
                   {
                       Task = "Unang paguusap",
                       Section = mahusay
                   },
                   new Assignment
                   {
                       Task = "Pagdalaw muli",
                       Section = mahusay
                   },
                   new Assignment
                   {
                       Task = "Pahayag",
                       Section = mahusay
                   },

                   new Assignment
                   {
                       Task = "Lokal na pangangailangan",
                       Section = pamumuhay
                   },
                   new Assignment
                   {
                       Task = "Pagaaral ng kongregasyon sa Bibliya",
                       Section = pamumuhay
                   },
                   new Assignment
                   {
                       Task = "Pangwakas na komento",
                       Section = pamumuhay
                   }
                }
            };
        }
    }
}
