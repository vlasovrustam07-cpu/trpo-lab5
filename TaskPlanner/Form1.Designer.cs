namespace TaskPlanner
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
            label1 = new Label();
            txtTask = new TextBox();
            cmbPriority = new ComboBox();
            btnAdd = new Button();
            lstTasks = new ListBox();
            btnDone = new Button();
            btnDelete = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Задача:";
            // 
            // txtTask
            // 
            txtTask.Location = new Point(66, 12);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(258, 23);
            txtTask.TabIndex = 1;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            cmbPriority.Location = new Point(330, 12);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(100, 23);
            cmbPriority.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(436, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 25);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(12, 45);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(503, 244);
            lstTasks.TabIndex = 4;
            // 
            // btnDone
            // 
            btnDone.Location = new Point(12, 300);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(90, 25);
            btnDone.TabIndex = 5;
            btnDone.Text = "Выполнено";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(108, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 25);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(210, 305);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(120, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Задач: 0, выполнено: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 337);
            Controls.Add(lblStatus);
            Controls.Add(btnDelete);
            Controls.Add(btnDone);
            Controls.Add(lstTasks);
            Controls.Add(btnAdd);
            Controls.Add(cmbPriority);
            Controls.Add(txtTask);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Планировщик задач";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTask;
        private ComboBox cmbPriority;
        private Button btnAdd;
        private ListBox lstTasks;
        private Button btnDone;
        private Button btnDelete;
        private Label lblStatus;
    }
}
