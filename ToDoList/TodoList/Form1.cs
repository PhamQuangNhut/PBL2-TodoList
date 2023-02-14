using Microsoft.Win32;
using System.Drawing.Text;
using System.Xml.Serialization;
using static TodoList.TodoItem;

namespace TodoList
{
    public partial class Form1 : Form
    {
        #region Peoperties
        //NotifyIcon notify;
        private PriorityQueue<TodoItem, int> ongoingTasks;
        private List<TodoItem> todayTasks;
        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        public PlanData Tasks { get => tasks; set => tasks = value; }
        //public NotifyIcon Notify { get => notify; set => notify = value; }
        public int AppTime { get => appTime; set => appTime = value; }
        public List<TodoItem> TodayTasks { get => todayTasks; set => todayTasks = value; }

        private int appTime;

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private PlanData tasks;
        private string filePath = "data.xml";
        #endregion
        public Form1()
        {
            InitializeComponent();
            todayTasks = new List<TodoItem>();
            MainTimer.Start();
            AutoTimer.Start();
            appTime = 0;
            LoadMatrix();
            try
            {
                Tasks = DesemiralizeFromXML(filePath) as PlanData;
            }
            catch {
                setDefaultTask();
            }
        }

        void setDefaultTask()
        {
            tasks = new PlanData();
            tasks.TaskList = new List<TodoItem>();
            tasks.TaskList.Add(new TodoItem() { Date = DateTime.Now, FromTime = new Point(7, 0), ToTime = new Point(9, 0), Task = "...", Status = TodoItem.ListStatus[(int)EPlanItem.COMING] });

        }
        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.DayButtonWidth, Height = Cons.DayButtonHeight };
                    btn.Click += btn_Click;
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    PanelMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0 - Cons.margin, oldBtn.Location.Y + Cons.DayButtonHeight) };
            }
            //AddNumberIntoMatrixByDate(DateTimePickerMain.Value);
            SetDefaultDate();
        }

        void btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
            {
                return;
            }
            DailyPlan daily = new DailyPlan(new DateTime(DateTimePickerMain.Value.Year, DateTimePickerMain.Value.Month, Convert.ToInt32((sender as Button).Text)), tasks);
            daily.ShowDialog();

        }


        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime usedDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(usedDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (isTheSameDate(usedDate, date))
                {
                    btn.BackColor = Color.Yellow;
                }
                if (isTheSameDate(usedDate, DateTime.Now))
                {
                    btn.BackColor = Color.Blue;
                }

                if (column >= 6)
                {
                    line++;
                }
                usedDate = usedDate.AddDays(1);
            }
        }

        bool isTheSameDate(DateTime a, DateTime b)
        {
            return (a.Day == b.Day && a.Month == b.Month && a.Year == b.Year);
        }



        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; ++i)
            {
                for (int j = 0; j < Matrix[i].Count; ++j)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }

        void SetDefaultDate()
        {
            DateTimePickerMain.Value = DateTime.Now;
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else return 28;
                default:
                    return 30;
            }
        }

        public void SemiralizeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
            sr.Serialize(fs, data);
            fs.Close();
        }
        private object DesemiralizeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch {
                fs.Close();
                throw new NotImplementedException();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }


        private void PreBtn_Click(object sender, EventArgs e)
        {
            DateTimePickerMain.Value = DateTimePickerMain.Value.AddMonths(-1);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DateTimePickerMain.Value = DateTimePickerMain.Value.AddMonths(1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownNotify.Enabled = NotifyCheckBox.Checked;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SemiralizeToXML(tasks, filePath);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!NotifyCheckBox.Checked) return;
            AppTime++;
            if (AppTime < Cons.notifyTime) return;
            NotifyIcon.ShowBalloonTip(Cons.defaultTimeOut, "Calendar", string.Format("You have {0} tasks today", todayTasks.Count), ToolTipIcon.Info);

            AppTime = 0;
        }
        private void AutoTimer_Tick(object sender, EventArgs e)
        {
            if (tasks == null || tasks.TaskList == null || tasks.TaskList.Count == 0) return;
            DateTime currentDate = DateTime.Now;

            todayTasks = tasks.TaskList.Where(p => p.Date.Year == currentDate.Year && p.Date.Month == currentDate.Month && p.Date.Day == currentDate.Day && p.Status != "DONE" && p.Task != null).ToList();
            for (int i = 0; i < todayTasks.Count; i++)
            {
                if (todayTasks[i].FromTime.X * 60 + todayTasks[i].FromTime.Y == DateTime.Now.Hour * 60 + DateTime.Now.Minute + DateTime.Now.Second) 
                {
                    NotifyIcon.ShowBalloonTip(Cons.defaultTimeOut, "Calendar", "Notice: "+ todayTasks[i].Task + "at " + todayTasks[i].FromTime.X + ":" + (todayTasks[i].FromTime.Y > 10 ? "":"0") +todayTasks[i].FromTime.Y , ToolTipIcon.Info);
                }
                if (todayTasks[i].FromTime.X * 60 + todayTasks[i].FromTime.Y <= DateTime.Now.Hour * 60 + DateTime.Now.Minute)
                {
                    todayTasks[i].Status = "DOING";
                }
                if (todayTasks[i].ToTime.X * 60 + todayTasks[i].ToTime.Y <= DateTime.Now.Hour * 60 + DateTime.Now.Minute)
                {
                    todayTasks[i].Status = "MISSED";
                }
            }
        }

        private void numericUpDownNotify_ValueChanged(object sender, EventArgs e)
        {
            Cons.notifyTime = (int)numericUpDownNotify.Value;
        }



        
    }
}