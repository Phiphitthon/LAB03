using System.ComponentModel;

namespace LAB3
{
    public partial class Form1 : Form
    {
        //array <-> List
        List<Student> _students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //get value from textbox
            String name = this.textBoxName.Text;
            String ID = this.textBoxID.Text;
            string year = this.textBoxbrithyear.Text;
            string hight = this.textBoxhight.Text;
            string grade = this.textBoxgrade.Text;
            string branch = this.textBoxbranch.Text;

            //convert string to in
            int iYear = Int32.Parse(year);
            int iHight = Int32.Parse(hight);
            double iGrade = Double.Parse(grade);

            //create obj from Student
            Student newStudent = new Student(name, ID, iYear, iHight, iGrade, branch);
            //Add new student to list
            this._students.Add(newStudent);

            //cal max min
            if (iGrade > Maxgrade)
            {
                MaxIgrade = iGrade;
            }
            if (iGrade < MinGrade)
            {
                MinIgrade = iGrade;
            }

            //cal num Student
            numStudent = numStudent +1;

            //show num Stdent
            this.sumstudent.Text = this.sumstudent.Text + numStudent;

            //show max min grade
            this.MaxIgrade.Text = this.MaxIgrade.Text + MaxIgrade;
            this.MinIgrade.Text = this.MinIgrade.Text + MinIgrade;

           

            // add data to DataGridView
            BindingSource source = new BindingSource();
            source.DataSource = this._students;            
            this.dataGridView1.DataSource = source;
                
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clear textbox
            this.textBoxName.Text = "";
            this.textBoxID.Text = "";
            this.textBoxbrithyear.Text = "";
            this.textBoxhight.Text = "";
            this.textBoxgrade.Text = "";
            this.textBoxbranch.Text = "";
        }
    }
}