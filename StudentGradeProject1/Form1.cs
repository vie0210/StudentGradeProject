using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace StudentGradeProject1
{
    public partial class Form1 : Form
    {
        // Create list
        List<double> students_grades = new List<double>();
        List<string> students_name = new List<string>();
        List<string> students_letter = new List<string>();

        public Form1()
        {
            InitializeComponent();

        }

        //
        // ADD GRADE TO GRADE LIST BOX
        //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double grade;
            if (double.TryParse(txtAddGrade.Text, out grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    students_grades.Add(grade);
                    lstGrade.Items.Add(grade.ToString("F2"));
                    txtAddGrade.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter score from 0 to 100.", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        // DELETE GRADE
        //
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selected_grade = lstGrade.SelectedIndex;
            if (selected_grade != -1)
            {
                lstGrade.Items.RemoveAt(selected_grade);
                students_grades.RemoveAt(selected_grade);
            }
            else
            {
                MessageBox.Show("Please select a grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        // CALCULATE AVERAGE AND DECIDE LETTER GRADE
        //
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total = 0;
            double average;
            string letter;
            // Handle invalid cases
            string name_input = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name_input) || students_grades.Count == 0)
            {
                MessageBox.Show("Make sure that you enter all information to calculate the student's grade",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Display
                letter = lblLetterGradeDisplay.Text.Trim();
                string no_average = lblAverageDisplay.Text;
                name_input = lblNameDisplay.Text.Trim();
            }
            else
            {
                // Calculate average
                for (int i = 0; i < students_grades.Count; i++)
                {
                    total += students_grades[i];
                }
                average = total / students_grades.Count;

                // Decide letter grade
                if (average >= 90)
                {
                    letter = "A";
                }
                else if (average >= 80)
                {
                    letter = "B";
                }
                else if (average >= 70)
                {
                    letter = "C";
                }
                else if (average >= 60)
                {
                    letter = "D";
                }
                else
                {
                    letter = "F";
                }

                // Display result
                lblAverageDisplay.Text = average.ToString("F2");
                lblNameDisplay.Text = name_input;
                lblLetterGradeDisplay.Text = letter;

            }
        }
        //
        // DISPLAY STUDENT NAME AND GRADE IN LIST BOX
        //
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool repeated_name = false;

            string name = txtName.Text.Trim();
            string letter = lblLetterGradeDisplay.Text;
            foreach (string names in students_name)
            {
                if (names == name)
                {
                    repeated_name = true;
                }
            }

            if (!string.IsNullOrEmpty(name) && repeated_name == false)
            {
                students_name.Add(name);
                students_letter.Add(letter);
                // Display in listbox
                lstStudents.Items.Add(name + " :  " + letter);
            }
            else if (name == "" || letter == "")
            {
                MessageBox.Show("Have nothing to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Repeated name. Please delete the previous grade to update new grade." +
                    "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //
        // DELETE STUDENT FROM LIST
        //
        private void btnStudentListDelete_Click(object sender, EventArgs e)
        {
            int selected_student = lstStudents.SelectedIndex;
            if (selected_student != -1)
            {
                lstStudents.Items.RemoveAt(selected_student);
                students_name.RemoveAt(selected_student);

            }
            else
            {
                MessageBox.Show("Please select something.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        // CLOSE AND SAVE 
        //
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("StudentGrade.txt");
            foreach (string name in lstStudents.Items)
            {
                outputFile.WriteLine(name);
            }
            outputFile.Close();
        }
        //
        // CLEAR BUTTON
        //
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstGrade.Items.Clear();
            txtName.Clear();
            lblAverageDisplay.Text = "________________________";
            lblNameDisplay.Text = "________________________";
            lblLetterGradeDisplay.Text = "___________________";

        }
    }
}
