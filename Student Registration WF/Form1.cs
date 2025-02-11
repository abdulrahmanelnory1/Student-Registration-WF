using D2LinqCF.Models;

namespace D2LinqCF
{
    public partial class Form1 : Form
    {
        CollegeDBContext dBContext;
        public Form1()
        {


            dBContext = new CollegeDBContext();

            InitializeComponent();
            Reset();

            //Student std = new Student();
            //std.Name = "ali";
            //std.Age = 22;
            //std.Address = "cairo";

            //Department dept = new Department();
            //dept.Name = "Python";

            //std.deptId=dept.Id;

            //dBContext.Students.Add(std);
            //dBContext.Departments.Add(dept);

        }

        private void Reset()
        {
            txt_address.Text = "";
            txt_age.Text = "";
            txt_fullName.Text = "";
            cmbBox_depts.SelectedIndex = -1;
            txt_message.Text = "";

            //comboBox1.SelectedItem = null;
        }
        //comboBox1.SelectedIndex = -1; 
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_fullName.Text == "" || txt_age.Text == "" || txt_address.Text == "" || cmbBox_depts.SelectedIndex == -1)
            {
                txt_message.ForeColor = Color.Red;
                txt_message.Text = "Complete all fields..!";
            }

            else
            {
                txt_message.ForeColor = Color.Green;
                txt_message.Text = "Completed successfully !";


                Student std = new Student();
                std.Name = txt_fullName.Text;
                std.Age = int.Parse(txt_age.Text);
                std.Address = txt_address.Text;


                Department dept = new Department();
                dept.Name = cmbBox_depts.Text;
                dept.students.Add(std);


                //dBContext.Students.Add(std);
                dBContext.Departments.Add(dept);
                dBContext.SaveChanges();




                //DG_stds.DataSource = dBContext.Students.ToList();

            }



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DG_stds.DataSource = dBContext.Students.Where(n => n.Name.StartsWith(textBox4.Text)).Select(n => new { Full_Name = n.Name, Address = n.Address, Age = n.Age, Department_Name = n.dept.Name }).ToList();
        }//.Select(n => new {Full_Name = n.Name , Address = n.Address , Age  = n.Age }).ToList();

        private void txt_message_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}