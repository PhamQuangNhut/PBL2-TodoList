using System.Data;

namespace TodoList
{
    public partial class DailyPlan : Form
    {
        private DateTime date;
        private PlanData tasks;

        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public DailyPlan(DateTime date, PlanData tasks)
        {
            InitializeComponent();
            this.Date = date;
            this.Tasks = tasks;
            fPanel.Width = PanelTask.Width;
            fPanel.Height = PanelTask.Height;
            PanelTask.Controls.Add(fPanel);
            fPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            fPanel.WrapContents = false;
            fPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            fPanel.AutoScroll = true;
            DateTimePickerDaily.Value = date;
        }

        public DateTime Date { get => date; set => date = value; }
        public PlanData Tasks { get => tasks; set => tasks = value; }
        public FlowLayoutPanel FPanel { get => fPanel; set => fPanel = value; }

        void ShowTasksByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (tasks != null && tasks.TaskList != null)
            {
                List<TodoItem> todayTasks = getTaskByDate(date);
                for (int i = 0; i < todayTasks.Count; ++i)
                {
                    addJob(todayTasks[i]);
                }
            }
        }
        void aTask_Save(object sender, EventArgs e)
        {
        }
        void addJob(TodoItem task)
        {
            ATask aTask = new ATask(task);
            aTask.Save += aTask_Save;
            aTask.Delete += aTask_Delete;

            fPanel.Controls.Add(aTask);
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
        void aTask_Delete(object sender, EventArgs e)
        {
            ATask uc = sender as ATask;
            TodoItem job = uc.Task;
            fPanel.Controls.Remove(uc);
            tasks.TaskList.Remove(job);
        }
        List<TodoItem> getTaskByDate(DateTime date)
        {
            return Tasks.TaskList.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }
        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ShowTasksByDate((sender as DateTimePicker).Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTimePickerDaily.Value = DateTimePickerDaily.Value.AddDays(-1);
        }

        private void ButtonNextDay_Click(object sender, EventArgs e)
        {
            DateTimePickerDaily.Value = DateTimePickerDaily.Value.AddDays(1);

        }

        private void MenuStripItemToday_Click(object sender, EventArgs e)
        {
            DateTimePickerDaily.Value = DateTime.Now;
        }

        private void MenuStripItemAdd_Click(object sender, EventArgs e)
        {
            TodoItem item = new TodoItem() { Date = DateTimePickerDaily.Value, Status = "COMING" };
            Tasks.TaskList.Add(item);
            addJob(item);
        }
    }
}
