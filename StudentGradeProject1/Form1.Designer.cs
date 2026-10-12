namespace StudentGradeProject1
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
            txtName = new TextBox();
            lstGrade = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            grpGradeCalculator = new GroupBox();
            label2 = new Label();
            lblGrade = new Label();
            lblAddGrade = new Label();
            btnClear = new Button();
            btnCalculate = new Button();
            lblName = new Label();
            txtAddGrade = new TextBox();
            grpResult = new GroupBox();
            lblLetterGradeDisplay = new Label();
            lblAverageDisplay = new Label();
            lblNameDisplay = new Label();
            btnSave = new Button();
            lblLetterGrade = new Label();
            lblNameResult = new Label();
            lblAverage = new Label();
            lblResult = new Label();
            lstStudents = new ListBox();
            lblStudentsList = new Label();
            btnStudentListDelete = new Button();
            grpGradeCalculator.SuspendLayout();
            grpResult.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.Font = new Font("Arial Rounded MT Bold", 9F);
            txtName.Location = new Point(178, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 25);
            txtName.TabIndex = 0;
            // 
            // lstGrade
            // 
            lstGrade.BackColor = SystemColors.Window;
            lstGrade.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstGrade.FormattingEnabled = true;
            lstGrade.Location = new Point(6, 293);
            lstGrade.Name = "lstGrade";
            lstGrade.Size = new Size(432, 151);
            lstGrade.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleGoldenrod;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.DarkOliveGreen;
            btnAdd.Location = new Point(328, 194);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 32);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.PaleGoldenrod;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.DarkOliveGreen;
            btnDelete.Location = new Point(6, 463);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(431, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // grpGradeCalculator
            // 
            grpGradeCalculator.Controls.Add(label2);
            grpGradeCalculator.Controls.Add(lblGrade);
            grpGradeCalculator.Controls.Add(lblAddGrade);
            grpGradeCalculator.Controls.Add(btnClear);
            grpGradeCalculator.Controls.Add(btnCalculate);
            grpGradeCalculator.Controls.Add(lblName);
            grpGradeCalculator.Controls.Add(txtAddGrade);
            grpGradeCalculator.Controls.Add(txtName);
            grpGradeCalculator.Controls.Add(lstGrade);
            grpGradeCalculator.Controls.Add(btnAdd);
            grpGradeCalculator.Controls.Add(btnDelete);
            grpGradeCalculator.Location = new Point(12, 12);
            grpGradeCalculator.Name = "grpGradeCalculator";
            grpGradeCalculator.Size = new Size(450, 643);
            grpGradeCalculator.TabIndex = 5;
            grpGradeCalculator.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(17, 14);
            label2.Name = "label2";
            label2.Size = new Size(420, 46);
            label2.TabIndex = 10;
            label2.Text = "Student Grade Calculator";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrade.ForeColor = Color.DarkGoldenrod;
            lblGrade.Location = new Point(0, 239);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(438, 41);
            lblGrade.TabIndex = 9;
            lblGrade.Text = "--------------Grade--------------";
            // 
            // lblAddGrade
            // 
            lblAddGrade.AutoSize = true;
            lblAddGrade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddGrade.ForeColor = Color.DarkOliveGreen;
            lblAddGrade.Location = new Point(17, 144);
            lblAddGrade.Name = "lblAddGrade";
            lblAddGrade.Size = new Size(114, 28);
            lblAddGrade.TabIndex = 8;
            lblAddGrade.Text = "Add Grade:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.PaleGoldenrod;
            btnClear.Font = new Font("Arial Rounded MT Bold", 12F);
            btnClear.ForeColor = Color.DarkOliveGreen;
            btnClear.Location = new Point(6, 577);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(432, 50);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Olive;
            btnCalculate.Font = new Font("Arial Rounded MT Bold", 12F);
            btnCalculate.ForeColor = Color.PaleGoldenrod;
            btnCalculate.Location = new Point(6, 521);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(432, 50);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.DarkOliveGreen;
            lblName.Location = new Point(17, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(148, 28);
            lblName.TabIndex = 5;
            lblName.Text = "Student Name:";
            // 
            // txtAddGrade
            // 
            txtAddGrade.Font = new Font("Arial Rounded MT Bold", 9F);
            txtAddGrade.Location = new Point(178, 148);
            txtAddGrade.Name = "txtAddGrade";
            txtAddGrade.Size = new Size(260, 25);
            txtAddGrade.TabIndex = 4;
            // 
            // grpResult
            // 
            grpResult.BackColor = Color.OldLace;
            grpResult.Controls.Add(lblLetterGradeDisplay);
            grpResult.Controls.Add(lblAverageDisplay);
            grpResult.Controls.Add(lblNameDisplay);
            grpResult.Controls.Add(btnSave);
            grpResult.Controls.Add(lblLetterGrade);
            grpResult.Controls.Add(lblNameResult);
            grpResult.Controls.Add(lblAverage);
            grpResult.Controls.Add(lblResult);
            grpResult.Location = new Point(468, 12);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(320, 366);
            grpResult.TabIndex = 6;
            grpResult.TabStop = false;
            // 
            // lblLetterGradeDisplay
            // 
            lblLetterGradeDisplay.AutoSize = true;
            lblLetterGradeDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLetterGradeDisplay.Location = new Point(142, 212);
            lblLetterGradeDisplay.Name = "lblLetterGradeDisplay";
            lblLetterGradeDisplay.Size = new Size(164, 28);
            lblLetterGradeDisplay.TabIndex = 18;
            lblLetterGradeDisplay.Text = "___________________";
            // 
            // lblAverageDisplay
            // 
            lblAverageDisplay.AutoSize = true;
            lblAverageDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverageDisplay.Location = new Point(102, 147);
            lblAverageDisplay.Name = "lblAverageDisplay";
            lblAverageDisplay.Size = new Size(204, 28);
            lblAverageDisplay.TabIndex = 17;
            lblAverageDisplay.Text = "________________________";
            // 
            // lblNameDisplay
            // 
            lblNameDisplay.AutoSize = true;
            lblNameDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameDisplay.Location = new Point(83, 80);
            lblNameDisplay.Name = "lblNameDisplay";
            lblNameDisplay.Size = new Size(204, 28);
            lblNameDisplay.TabIndex = 16;
            lblNameDisplay.Text = "________________________";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Olive;
            btnSave.Font = new Font("Arial Rounded MT Bold", 15F);
            btnSave.ForeColor = Color.PaleGoldenrod;
            btnSave.Location = new Point(22, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(275, 60);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblLetterGrade
            // 
            lblLetterGrade.AutoSize = true;
            lblLetterGrade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLetterGrade.ForeColor = Color.DarkOliveGreen;
            lblLetterGrade.Location = new Point(6, 212);
            lblLetterGrade.Name = "lblLetterGrade";
            lblLetterGrade.Size = new Size(130, 28);
            lblLetterGrade.TabIndex = 13;
            lblLetterGrade.Text = "Letter Grade:";
            // 
            // lblNameResult
            // 
            lblNameResult.AutoSize = true;
            lblNameResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameResult.ForeColor = Color.DarkOliveGreen;
            lblNameResult.Location = new Point(6, 80);
            lblNameResult.Name = "lblNameResult";
            lblNameResult.Size = new Size(71, 28);
            lblNameResult.TabIndex = 12;
            lblNameResult.Text = "Name:";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverage.ForeColor = Color.DarkOliveGreen;
            lblAverage.Location = new Point(6, 147);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(91, 28);
            lblAverage.TabIndex = 11;
            lblAverage.Text = "Average:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.DarkGoldenrod;
            lblResult.Location = new Point(115, 17);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(105, 41);
            lblResult.TabIndex = 10;
            lblResult.Text = "Result";
            // 
            // lstStudents
            // 
            lstStudents.Font = new Font("Arial Rounded MT Bold", 10.8F);
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(474, 435);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(308, 130);
            lstStudents.TabIndex = 7;
            // 
            // lblStudentsList
            // 
            lblStudentsList.AutoSize = true;
            lblStudentsList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentsList.ForeColor = Color.DarkOliveGreen;
            lblStudentsList.Location = new Point(570, 394);
            lblStudentsList.Name = "lblStudentsList";
            lblStudentsList.Size = new Size(129, 28);
            lblStudentsList.TabIndex = 8;
            lblStudentsList.Text = "Students List";
            // 
            // btnStudentListDelete
            // 
            btnStudentListDelete.BackColor = Color.PaleGoldenrod;
            btnStudentListDelete.Font = new Font("Arial Rounded MT Bold", 12F);
            btnStudentListDelete.ForeColor = Color.DarkOliveGreen;
            btnStudentListDelete.Location = new Point(474, 588);
            btnStudentListDelete.Name = "btnStudentListDelete";
            btnStudentListDelete.Size = new Size(308, 52);
            btnStudentListDelete.TabIndex = 15;
            btnStudentListDelete.Text = "Delete";
            btnStudentListDelete.UseVisualStyleBackColor = false;
            btnStudentListDelete.Click += btnStudentListDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(800, 667);
            Controls.Add(btnStudentListDelete);
            Controls.Add(lblStudentsList);
            Controls.Add(lstStudents);
            Controls.Add(grpResult);
            Controls.Add(grpGradeCalculator);
            Name = "Form1";
            Text = "Student Grade Calculator";
            FormClosing += Form1_FormClosing;
            grpGradeCalculator.ResumeLayout(false);
            grpGradeCalculator.PerformLayout();
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private ListBox lstGrade;
        private Button btnAdd;
        private Button btnDelete;
        private GroupBox grpGradeCalculator;
        private Button btnCalculate;
        private Label lblName;
        private TextBox txtAddGrade;
        private GroupBox grpResult;
        private Button btnClear;
        private Label lblAddGrade;
        private Label lblGrade;
        private Label label2;
        private Label lblResult;
        private Label lblLetterGrade;
        private Label lblNameResult;
        private Label lblAverage;
        private Button btnSave;
        private ListBox lstStudents;
        private Label lblNameDisplay;
        private Label lblStudentsList;
        private Label lblLetterGradeDisplay;
        private Label lblAverageDisplay;
        private Button btnStudentListDelete;
    }
}
