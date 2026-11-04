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
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            tlpInput = new TableLayoutPanel();
            txtTask = new TextBox();
            cmbPriority = new ComboBox();
            btnAdd = new Button();
            pnlList = new Panel();
            lvTasks = new ListView();
            colTitle = new ColumnHeader();
            colPriority = new ColumnHeader();
            colCreated = new ColumnHeader();
            imgRowHeight = new ImageList(components);
            tlpFooter = new TableLayoutPanel();
            lblStatus = new Label();
            btnClearDone = new Button();
            btnDelete = new Button();
            pnlHeader.SuspendLayout();
            tlpInput.SuspendLayout();
            pnlList.SuspendLayout();
            tlpFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(35, 47, 89);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(720, 76);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(190, 200, 228);
            lblSubtitle.Location = new Point(22, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(110, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Задачи на сегодня";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(229, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Планировщик задач";
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 3;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tlpInput.Controls.Add(txtTask, 0, 0);
            tlpInput.Controls.Add(cmbPriority, 1, 0);
            tlpInput.Controls.Add(btnAdd, 2, 0);
            tlpInput.Dock = DockStyle.Top;
            tlpInput.Location = new Point(0, 76);
            tlpInput.Name = "tlpInput";
            tlpInput.Padding = new Padding(14, 14, 14, 10);
            tlpInput.RowCount = 1;
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInput.Size = new Size(720, 64);
            tlpInput.TabIndex = 1;
            // 
            // txtTask
            // 
            txtTask.BorderStyle = BorderStyle.FixedSingle;
            txtTask.Dock = DockStyle.Fill;
            txtTask.Font = new Font("Segoe UI", 11.5F);
            txtTask.Location = new Point(18, 18);
            txtTask.Margin = new Padding(4, 4, 8, 4);
            txtTask.Name = "txtTask";
            txtTask.PlaceholderText = "Что нужно сделать?";
            txtTask.Size = new Size(392, 28);
            txtTask.TabIndex = 0;
            // 
            // cmbPriority
            // 
            cmbPriority.Dock = DockStyle.Fill;
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FlatStyle = FlatStyle.Flat;
            cmbPriority.Font = new Font("Segoe UI", 11.5F);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            cmbPriority.Location = new Point(418, 18);
            cmbPriority.Margin = new Padding(0, 4, 8, 4);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(142, 29);
            cmbPriority.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(61, 90, 254);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 109, 254);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(568, 17);
            btnAdd.Margin = new Padding(0, 3, 0, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+ Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlList
            // 
            pnlList.Controls.Add(lvTasks);
            pnlList.Dock = DockStyle.Fill;
            pnlList.Location = new Point(0, 140);
            pnlList.Name = "pnlList";
            pnlList.Padding = new Padding(18, 4, 18, 0);
            pnlList.Size = new Size(720, 300);
            pnlList.TabIndex = 2;
            // 
            // lvTasks
            // 
            lvTasks.BorderStyle = BorderStyle.None;
            lvTasks.CheckBoxes = true;
            lvTasks.Columns.AddRange(new ColumnHeader[] { colTitle, colPriority, colCreated });
            lvTasks.Dock = DockStyle.Fill;
            lvTasks.Font = new Font("Segoe UI", 10.5F);
            lvTasks.FullRowSelect = true;
            lvTasks.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvTasks.Location = new Point(18, 4);
            lvTasks.Name = "lvTasks";
            lvTasks.Size = new Size(684, 296);
            lvTasks.SmallImageList = imgRowHeight;
            lvTasks.TabIndex = 0;
            lvTasks.UseCompatibleStateImageBehavior = false;
            lvTasks.View = View.Details;
            lvTasks.ItemChecked += lvTasks_ItemChecked;
            lvTasks.Resize += lvTasks_Resize;
            // 
            // colTitle
            // 
            colTitle.Text = "Задача";
            colTitle.Width = 420;
            // 
            // colPriority
            // 
            colPriority.Text = "Приоритет";
            colPriority.Width = 120;
            // 
            // colCreated
            // 
            colCreated.Text = "Добавлена";
            colCreated.Width = 120;
            // 
            // imgRowHeight
            // 
            imgRowHeight.ColorDepth = ColorDepth.Depth32Bit;
            imgRowHeight.ImageSize = new Size(1, 30);
            imgRowHeight.TransparentColor = Color.Transparent;
            // 
            // tlpFooter
            // 
            tlpFooter.ColumnCount = 3;
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpFooter.Controls.Add(lblStatus, 0, 0);
            tlpFooter.Controls.Add(btnClearDone, 1, 0);
            tlpFooter.Controls.Add(btnDelete, 2, 0);
            tlpFooter.Dock = DockStyle.Bottom;
            tlpFooter.Location = new Point(0, 440);
            tlpFooter.Name = "tlpFooter";
            tlpFooter.Padding = new Padding(14, 10, 14, 12);
            tlpFooter.RowCount = 1;
            tlpFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFooter.Size = new Size(720, 60);
            tlpFooter.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.ForeColor = Color.FromArgb(90, 100, 120);
            lblStatus.Location = new Point(18, 10);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(364, 38);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Список задач пуст";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClearDone
            // 
            btnClearDone.BackColor = Color.White;
            btnClearDone.Cursor = Cursors.Hand;
            btnClearDone.Dock = DockStyle.Fill;
            btnClearDone.FlatAppearance.BorderColor = Color.FromArgb(214, 219, 230);
            btnClearDone.FlatStyle = FlatStyle.Flat;
            btnClearDone.ForeColor = Color.FromArgb(35, 47, 89);
            btnClearDone.Location = new Point(386, 12);
            btnClearDone.Margin = new Padding(0, 2, 8, 2);
            btnClearDone.Name = "btnClearDone";
            btnClearDone.Size = new Size(192, 34);
            btnClearDone.TabIndex = 1;
            btnClearDone.Text = "Удалить выполненные";
            btnClearDone.UseVisualStyleBackColor = false;
            btnClearDone.Click += btnClearDone_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(214, 219, 230);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(198, 40, 40);
            btnDelete.Location = new Point(586, 12);
            btnDelete.Margin = new Padding(0, 2, 0, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(720, 500);
            Controls.Add(pnlList);
            Controls.Add(tlpFooter);
            Controls.Add(tlpInput);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(620, 420);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Планировщик задач";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpInput.ResumeLayout(false);
            tlpInput.PerformLayout();
            pnlList.ResumeLayout(false);
            tlpFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private TableLayoutPanel tlpInput;
        private TextBox txtTask;
        private ComboBox cmbPriority;
        private Button btnAdd;
        private Panel pnlList;
        private ListView lvTasks;
        private ColumnHeader colTitle;
        private ColumnHeader colPriority;
        private ColumnHeader colCreated;
        private ImageList imgRowHeight;
        private TableLayoutPanel tlpFooter;
        private Label lblStatus;
        private Button btnClearDone;
        private Button btnDelete;
    }
}
