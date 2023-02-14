namespace TodoList
{
    partial class DailyPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonPrevDay = new System.Windows.Forms.Button();
            this.ButtonNextDay = new System.Windows.Forms.Button();
            this.DateTimePickerDaily = new System.Windows.Forms.DateTimePicker();
            this.PanelTask = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuStripItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripItemToday = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.PanelTask);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 451);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developed by Dang and Nhut as PBL2...";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ButtonPrevDay);
            this.panel3.Controls.Add(this.ButtonNextDay);
            this.panel3.Controls.Add(this.DateTimePickerDaily);
            this.panel3.Location = new System.Drawing.Point(9, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 37);
            this.panel3.TabIndex = 2;
            // 
            // ButtonPrevDay
            // 
            this.ButtonPrevDay.Location = new System.Drawing.Point(0, 4);
            this.ButtonPrevDay.Name = "ButtonPrevDay";
            this.ButtonPrevDay.Size = new System.Drawing.Size(93, 25);
            this.ButtonPrevDay.TabIndex = 2;
            this.ButtonPrevDay.Text = "Prev";
            this.ButtonPrevDay.UseVisualStyleBackColor = true;
            this.ButtonPrevDay.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonNextDay
            // 
            this.ButtonNextDay.Location = new System.Drawing.Point(851, 4);
            this.ButtonNextDay.Name = "ButtonNextDay";
            this.ButtonNextDay.Size = new System.Drawing.Size(93, 25);
            this.ButtonNextDay.TabIndex = 0;
            this.ButtonNextDay.Text = "Next";
            this.ButtonNextDay.UseVisualStyleBackColor = true;
            this.ButtonNextDay.Click += new System.EventHandler(this.ButtonNextDay_Click);
            // 
            // DateTimePickerDaily
            // 
            this.DateTimePickerDaily.Location = new System.Drawing.Point(349, 6);
            this.DateTimePickerDaily.Name = "DateTimePickerDaily";
            this.DateTimePickerDaily.Size = new System.Drawing.Size(248, 23);
            this.DateTimePickerDaily.TabIndex = 1;
            this.DateTimePickerDaily.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // PanelTask
            // 
            this.PanelTask.Location = new System.Drawing.Point(6, 38);
            this.PanelTask.Name = "PanelTask";
            this.PanelTask.Size = new System.Drawing.Size(950, 340);
            this.PanelTask.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripItemAdd,
            this.MenuStripItemToday});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(964, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuStripItemAdd
            // 
            this.MenuStripItemAdd.Name = "MenuStripItemAdd";
            this.MenuStripItemAdd.Size = new System.Drawing.Size(44, 20);
            this.MenuStripItemAdd.Text = "Add ";
            this.MenuStripItemAdd.Click += new System.EventHandler(this.MenuStripItemAdd_Click);
            // 
            // MenuStripItemToday
            // 
            this.MenuStripItemToday.Name = "MenuStripItemToday";
            this.MenuStripItemToday.Size = new System.Drawing.Size(50, 20);
            this.MenuStripItemToday.Text = "Today";
            this.MenuStripItemToday.Click += new System.EventHandler(this.MenuStripItemToday_Click);
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuStrip);
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "DailyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DailyPlan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button ButtonPrevDay;
        private Button ButtonNextDay;
        private DateTimePicker DateTimePickerDaily;
        private Panel PanelTask;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem MenuStripItemAdd;
        private ToolStripMenuItem MenuStripItemToday;
        private Label label1;
    }
}