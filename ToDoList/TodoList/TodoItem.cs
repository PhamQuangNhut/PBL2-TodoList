namespace TodoList
{
    public class TodoItem
    {
        private DateTime date;
        private string task;

        public string Task { get => task; set => task = value; }
        private Point fromTime;
        public Point FromTime { get => fromTime; set => fromTime = value; }
        private Point toTime;
        public Point ToTime { get => toTime; set => toTime = value; }
        private string status;
        public string Status { get => status; set => status = value; }
        public DateTime Date { get => date; set => date = value; }

        public static List<string> ListStatus = new List<string>() { "DONE", "DOING", "COMING", "MISSED" };
        public enum EPlanItem
        {
            DONE,
            DOING,
            COMING,
            MISSED8
        };

    }
}
