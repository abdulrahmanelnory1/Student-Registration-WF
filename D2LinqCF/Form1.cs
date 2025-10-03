using D2LinqCF.Models;
using System.Diagnostics;
using System.Windows.Forms;

namespace D2LinqCF
{
    public partial class Form1 : Form
    {
        CollegeDBContext dBContext;
        public Form1()
        {
            dBContext = new CollegeDBContext();

            InitializeComponent();
            LoadDepartments();

            Reset();
        }
        // Load departments into combobox
        private void LoadDepartments()
        {
            var departments = dBContext.Departments
                 .Select(d => new { d.Id, d.Name })
                 .ToList();
            // Create a list with empty item first
            var departmentsWithEmpty = new List<object>
                { new { Id = 0, Name = "-- Select Department --" } // or string.Empty for completely empty
                }.Concat(departments).ToList();

            cmbBox_depts.DataSource = departmentsWithEmpty;
            cmbBox_depts.DisplayMember = "Name";  // What to display
            cmbBox_depts.ValueMember = "Id";
        }
        private void Reset()
        {
            txt_address.Text = "";
            txt_age.Text = "";
            txt_fullName.Text = "";
            cmbBox_depts.SelectedIndex = 0;
            txt_message.Text = "";
            ClearCourses();
        }
        private void ClearCourses()
        {            
            checkedListBox1_crs.DataSource = null;
            checkedListBox1_crs.Items.Clear();
            checkedListBox1_crs.Items.Add("Please select a department first");
            checkedListBox1_crs.Enabled = false;
        }
        // When there is a choosen department, load its courses
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmbBox_depts.SelectedValue != 0)
            {
                int departmentId = (int)cmbBox_depts.SelectedValue;
                LoadCourses(departmentId);
            }
        }
        // Load courses for the selected department
        private void LoadCourses(int departmentId)
        {
            var courses = dBContext.Courses
           .Where(c => c.DepartmentId == departmentId)
           .ToList();

            ClearCourses();

            checkedListBox1_crs.Enabled = true;

            checkedListBox1_crs.DataSource = courses;
            checkedListBox1_crs.DisplayMember = "Name";
            checkedListBox1_crs.ValueMember = "Id";
        }
       
        // Actions for finish button
        // if any field is empty show message to complete all fields
        // else create student object and fill it with data from fields
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_fullName.Text == "" || txt_age.Text == "" || txt_address.Text == "" || cmbBox_depts.SelectedIndex == 0 || checkedListBox1_crs.CheckedIndices.Count == 0)
            {
                txt_message.ForeColor = Color.Red;
                txt_message.Text = "Complete all fields..!";
                return;
            }

            Student std = new Student();
            std.Name = txt_fullName.Text;
            std.Age = int.Parse(txt_age.Text);
            std.Address = txt_address.Text;
            std.DepartmentId = (int)cmbBox_depts.SelectedValue; // sign up for department

            dBContext.Students.Add(std);
            // sign up choosen courses
            foreach (var selectedItem in checkedListBox1_crs.CheckedItems)
            {
                Course course = dBContext.Courses.Find(((Course)selectedItem).Id);
                std.Courses.Add(course);
                course.Students.Add(std);
            }
            dBContext.SaveChanges();

            txt_message.ForeColor = Color.Green;
            txt_message.Text = "Completed successfully !";
        }
        // Search by name
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DG_stds.DataSource = dBContext.Students.Where(n => n.Name.StartsWith(textBox4.Text)).Select(n => new { Full_Name = n.Name, Address = n.Address, Age = n.Age, Department_Name = n.Department.Name }).ToList();
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void txt_message_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void form1_Load(object sender, EventArgs e)
        {
        }
        private void txt_fullName_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}