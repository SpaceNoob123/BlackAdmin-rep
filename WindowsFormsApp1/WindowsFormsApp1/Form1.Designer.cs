namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.listViewBlacklist = new System.Windows.Forms.ListView();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.timerMonitoring = new System.Windows.Forms.Timer(this.components);
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonStartMonitoring = new System.Windows.Forms.Button();
            this.buttonStopMonitoring = new System.Windows.Forms.Button();
            this.buttonBrowseApp = new System.Windows.Forms.Button();
            this.numericUpDownTimeLimit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.Location = new System.Drawing.Point(12, 41);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(163, 20);
            this.textBoxProcessName.TabIndex = 1;
            // 
            // listViewBlacklist
            // 
            this.listViewBlacklist.GridLines = true;
            this.listViewBlacklist.HideSelection = false;
            this.listViewBlacklist.Location = new System.Drawing.Point(204, 41);
            this.listViewBlacklist.Name = "listViewBlacklist";
            this.listViewBlacklist.Size = new System.Drawing.Size(584, 125);
            this.listViewBlacklist.TabIndex = 2;
            this.listViewBlacklist.UseCompatibleStateImageBehavior = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(204, 12);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // timerMonitoring
            // 
            this.timerMonitoring.Tick += new System.EventHandler(this.timerMonitoring_Tick);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(204, 172);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(584, 266);
            this.textBoxLog.TabIndex = 4;
            // 
            // buttonStartMonitoring
            // 
            this.buttonStartMonitoring.Location = new System.Drawing.Point(39, 297);
            this.buttonStartMonitoring.Name = "buttonStartMonitoring";
            this.buttonStartMonitoring.Size = new System.Drawing.Size(85, 24);
            this.buttonStartMonitoring.TabIndex = 5;
            this.buttonStartMonitoring.Text = "Start Monitor";
            this.buttonStartMonitoring.UseVisualStyleBackColor = true;
            this.buttonStartMonitoring.Click += new System.EventHandler(this.buttonStartMonitoring_Click);
            // 
            // buttonStopMonitoring
            // 
            this.buttonStopMonitoring.Location = new System.Drawing.Point(39, 327);
            this.buttonStopMonitoring.Name = "buttonStopMonitoring";
            this.buttonStopMonitoring.Size = new System.Drawing.Size(85, 20);
            this.buttonStopMonitoring.TabIndex = 6;
            this.buttonStopMonitoring.Text = "StopMonitor";
            this.buttonStopMonitoring.UseVisualStyleBackColor = true;
            this.buttonStopMonitoring.Click += new System.EventHandler(this.buttonStopMonitoring_Click);
            // 
            // buttonBrowseApp
            // 
            this.buttonBrowseApp.Location = new System.Drawing.Point(100, 12);
            this.buttonBrowseApp.Name = "buttonBrowseApp";
            this.buttonBrowseApp.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseApp.TabIndex = 7;
            this.buttonBrowseApp.Text = "Select";
            this.buttonBrowseApp.UseVisualStyleBackColor = true;
            this.buttonBrowseApp.Click += new System.EventHandler(this.buttonBrowseApp_Click);
            // 
            // numericUpDownTimeLimit
            // 
            this.numericUpDownTimeLimit.Location = new System.Drawing.Point(12, 89);
            this.numericUpDownTimeLimit.Name = "numericUpDownTimeLimit";
            this.numericUpDownTimeLimit.Size = new System.Drawing.Size(162, 20);
            this.numericUpDownTimeLimit.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "time of life process(min)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownTimeLimit);
            this.Controls.Add(this.buttonBrowseApp);
            this.Controls.Add(this.buttonStopMonitoring);
            this.Controls.Add(this.buttonStartMonitoring);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listViewBlacklist);
            this.Controls.Add(this.textBoxProcessName);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.ListView listViewBlacklist;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Timer timerMonitoring;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonStartMonitoring;
        private System.Windows.Forms.Button buttonStopMonitoring;
        private System.Windows.Forms.Button buttonBrowseApp;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeLimit;
        private System.Windows.Forms.Label label1;
    }
}

