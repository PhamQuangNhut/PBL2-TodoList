namespace TodoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numericUpDownNotify = new System.Windows.Forms.NumericUpDown();
            this.NotifyCheckBox = new System.Windows.Forms.CheckBox();
            this.TodayButton = new System.Windows.Forms.Button();
            this.DateTimePickerMain = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonNextMonth = new System.Windows.Forms.Button();
            this.ButtonPrevMonth = new System.Windows.Forms.Button();
            this.SunBtn = new System.Windows.Forms.Button();
            this.SatBtn = new System.Windows.Forms.Button();
            this.FriBtn = new System.Windows.Forms.Button();
            this.ThuBtn = new System.Windows.Forms.Button();
            this.WedBtn = new System.Windows.Forms.Button();
            this.TueBtn = new System.Windows.Forms.Button();
            this.MonBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelMatrix = new System.Windows.Forms.Panel();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.AutoTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 445);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.TodayButton);
            this.panel3.Controls.Add(this.DateTimePickerMain);
            this.panel3.Location = new System.Drawing.Point(2, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 29);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.numericUpDownNotify);
            this.panel6.Controls.Add(this.NotifyCheckBox);
            this.panel6.Location = new System.Drawing.Point(-2, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 23);
            this.panel6.TabIndex = 2;
            // 
            // numericUpDownNotify
            // 
            this.numericUpDownNotify.Enabled = false;
            this.numericUpDownNotify.Location = new System.Drawing.Point(65, 0);
            this.numericUpDownNotify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNotify.Name = "numericUpDownNotify";
            this.numericUpDownNotify.Size = new System.Drawing.Size(74, 23);
            this.numericUpDownNotify.TabIndex = 0;
            this.numericUpDownNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNotify.ValueChanged += new System.EventHandler(this.numericUpDownNotify_ValueChanged);
            // 
            // NotifyCheckBox
            // 
            this.NotifyCheckBox.AutoSize = true;
            this.NotifyCheckBox.Location = new System.Drawing.Point(5, 3);
            this.NotifyCheckBox.Name = "NotifyCheckBox";
            this.NotifyCheckBox.Size = new System.Drawing.Size(59, 19);
            this.NotifyCheckBox.TabIndex = 0;
            this.NotifyCheckBox.Text = "Notify";
            this.NotifyCheckBox.UseVisualStyleBackColor = true;
            this.NotifyCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TodayButton
            // 
            this.TodayButton.Location = new System.Drawing.Point(678, -1);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(89, 30);
            this.TodayButton.TabIndex = 1;
            this.TodayButton.Text = "Today";
            this.TodayButton.UseVisualStyleBackColor = true;
            this.TodayButton.Click += new System.EventHandler(this.TodayButton_Click);
            // 
            // DateTimePickerMain
            // 
            this.DateTimePickerMain.Location = new System.Drawing.Point(309, 2);
            this.DateTimePickerMain.Name = "DateTimePickerMain";
            this.DateTimePickerMain.Size = new System.Drawing.Size(200, 23);
            this.DateTimePickerMain.TabIndex = 0;
            this.DateTimePickerMain.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ButtonNextMonth);
            this.panel4.Controls.Add(this.ButtonPrevMonth);
            this.panel4.Controls.Add(this.SunBtn);
            this.panel4.Controls.Add(this.SatBtn);
            this.panel4.Controls.Add(this.FriBtn);
            this.panel4.Controls.Add(this.ThuBtn);
            this.panel4.Controls.Add(this.WedBtn);
            this.panel4.Controls.Add(this.TueBtn);
            this.panel4.Controls.Add(this.MonBtn);
            this.panel4.Location = new System.Drawing.Point(3, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 65);
            this.panel4.TabIndex = 0;
            // 
            // ButtonNextMonth
            // 
            this.ButtonNextMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonNextMonth.Location = new System.Drawing.Point(725, 4);
            this.ButtonNextMonth.Name = "ButtonNextMonth";
            this.ButtonNextMonth.Size = new System.Drawing.Size(43, 53);
            this.ButtonNextMonth.TabIndex = 14;
            this.ButtonNextMonth.Text = "Next";
            this.ButtonNextMonth.UseVisualStyleBackColor = true;
            this.ButtonNextMonth.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonPrevMonth
            // 
            this.ButtonPrevMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPrevMonth.Location = new System.Drawing.Point(0, 4);
            this.ButtonPrevMonth.Name = "ButtonPrevMonth";
            this.ButtonPrevMonth.Size = new System.Drawing.Size(43, 54);
            this.ButtonPrevMonth.TabIndex = 12;
            this.ButtonPrevMonth.Text = "Prev";
            this.ButtonPrevMonth.UseVisualStyleBackColor = true;
            this.ButtonPrevMonth.Click += new System.EventHandler(this.PreBtn_Click);
            // 
            // SunBtn
            // 
            this.SunBtn.Location = new System.Drawing.Point(627, 12);
            this.SunBtn.Name = "SunBtn";
            this.SunBtn.Size = new System.Drawing.Size(93, 37);
            this.SunBtn.TabIndex = 10;
            this.SunBtn.Text = "Sunday";
            this.SunBtn.UseVisualStyleBackColor = true;
            // 
            // SatBtn
            // 
            this.SatBtn.Location = new System.Drawing.Point(530, 12);
            this.SatBtn.Name = "SatBtn";
            this.SatBtn.Size = new System.Drawing.Size(91, 37);
            this.SatBtn.TabIndex = 9;
            this.SatBtn.Text = "Saturday";
            this.SatBtn.UseVisualStyleBackColor = true;
            // 
            // FriBtn
            // 
            this.FriBtn.Location = new System.Drawing.Point(433, 12);
            this.FriBtn.Name = "FriBtn";
            this.FriBtn.Size = new System.Drawing.Size(91, 37);
            this.FriBtn.TabIndex = 8;
            this.FriBtn.Text = "Friday";
            this.FriBtn.UseVisualStyleBackColor = true;
            // 
            // ThuBtn
            // 
            this.ThuBtn.Location = new System.Drawing.Point(336, 12);
            this.ThuBtn.Name = "ThuBtn";
            this.ThuBtn.Size = new System.Drawing.Size(91, 37);
            this.ThuBtn.TabIndex = 7;
            this.ThuBtn.Text = "Thursday";
            this.ThuBtn.UseVisualStyleBackColor = true;
            // 
            // WedBtn
            // 
            this.WedBtn.Location = new System.Drawing.Point(239, 12);
            this.WedBtn.Name = "WedBtn";
            this.WedBtn.Size = new System.Drawing.Size(91, 37);
            this.WedBtn.TabIndex = 6;
            this.WedBtn.Text = "Wednesday";
            this.WedBtn.UseVisualStyleBackColor = true;
            // 
            // TueBtn
            // 
            this.TueBtn.Location = new System.Drawing.Point(142, 12);
            this.TueBtn.Name = "TueBtn";
            this.TueBtn.Size = new System.Drawing.Size(91, 37);
            this.TueBtn.TabIndex = 5;
            this.TueBtn.Text = "Tuesday";
            this.TueBtn.UseVisualStyleBackColor = true;
            // 
            // MonBtn
            // 
            this.MonBtn.Location = new System.Drawing.Point(45, 12);
            this.MonBtn.Name = "MonBtn";
            this.MonBtn.Size = new System.Drawing.Size(91, 37);
            this.MonBtn.TabIndex = 4;
            this.MonBtn.Text = "Monday";
            this.MonBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PanelMatrix);
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 355);
            this.panel2.TabIndex = 0;
            // 
            // PanelMatrix
            // 
            this.PanelMatrix.Location = new System.Drawing.Point(46, 53);
            this.PanelMatrix.Name = "PanelMatrix";
            this.PanelMatrix.Size = new System.Drawing.Size(675, 298);
            this.PanelMatrix.TabIndex = 1;
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 60000;
            this.MainTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developed by Dang and Nhut as PBL2...";
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Notify";
            this.NotifyIcon.Visible = true;
            // 
            // AutoTimer
            // 
            this.AutoTimer.Enabled = true;
            this.AutoTimer.Tick += new System.EventHandler(this.AutoTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBL2 Calendar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel PanelMatrix;
        private Panel panel4;
        private DateTimePicker DateTimePickerMain;
        private Button TodayButton;
        private Button SatBtn;
        private Button FriBtn;
        private Button ThuBtn;
        private Button WedBtn;
        private Button TueBtn;
        private Button MonBtn;
        private Button SunBtn;
        private Button ButtonPrevMonth;
        private Button ButtonNextMonth;
        private System.Windows.Forms.Timer MainTimer;
        private NotifyIcon Notify;
        private Label label1;
        private NotifyIcon NotifyIcon;
        private System.Windows.Forms.Timer AutoTimer;
        private Panel panel6;
        private NumericUpDown numericUpDownNotify;
        private CheckBox NotifyCheckBox;
    }
}