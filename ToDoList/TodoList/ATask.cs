using static TodoList.TodoItem;

namespace TodoList
{
    public partial class ATask : UserControl
    {
        private TodoItem task;

        public TodoItem Task { get => task; set => task = value; }

        public ATask(TodoItem task)
        {
            InitializeComponent();
            comboBox1.DataSource = TodoItem.ListStatus;
            this.Task = task;
            showInfo();
        }
        private event EventHandler save;
        public event EventHandler Save
        {
            add
            {
                save += value;
            }
            remove { save -= value; }
        }
        private event EventHandler delete;
        public event EventHandler Delete
        {
            add
            {
                delete += value;
            }
            remove { delete -= value; }
        }
        void showInfo()
        {
            ATaskTextBox.Text = task.Task;
            numericUpDown1.Value = task.FromTime.X;
            numericUpDown2.Value = task.FromTime.Y;
            numericUpDown3.Value = task.ToTime.X;
            numericUpDown4.Value = task.ToTime.Y;
            comboBox1.SelectedIndex = TodoItem.ListStatus.IndexOf(Task.Status);
            ATaskCheckBox.Checked = TodoItem.ListStatus.IndexOf(Task.Status) == (int)EPlanItem.DONE ? true : false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = ATaskCheckBox.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            task.Task = ATaskTextBox.Text;
            task.FromTime = new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            task.ToTime = new Point((int)numericUpDown3.Value, (int)numericUpDown4.Value);
            task.Status = TodoItem.ListStatus[comboBox1.SelectedIndex];


            if (save != null)
            {
                save(this, new EventArgs());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (delete != null)
            {
                delete(this, new EventArgs());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.Green;
                    break;
                case 1:
                    this.BackColor = Color.Yellow;
                    break;

                case 2:
                    this.BackColor = Color.Gray;
                    break;

                case 3:
                    this.BackColor = Color.Red;
                    break;
                default:
                    this.BackColor = DefaultBackColor;
                    break;

            }
            comboBox1.Enabled = false;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ATask_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
