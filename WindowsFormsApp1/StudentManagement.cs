using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentManagement : Form
    {
        List<Student> m_lstStudents = null;
        public StudentManagement()
        {
            InitializeComponent();
            m_lstStudents = new List<Student>();
            LblIDValue.Text = Student.Current_ID_Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string studentName = txtstName.Text;
            string fatherName = txtftName.Text;
            string address = txtAddress.Text;
            string phoneNumber = txtPhone.Text;

            string errMsg = string.Empty;
            if (ValidateNewStudent(studentName, fatherName, address, phoneNumber, out errMsg) != 0)
            {
                if (!string.IsNullOrWhiteSpace(errMsg))
                    MessageBox.Show(errMsg);

                return;
            }

            //Student student = m_lstStudents.FirstOrDefault(x => x.PhoneNumber == phoneNumber);
            //if (student != null)
            //{
            //    MessageBox.Show("Student Already Present");
            //    return;
            //}

            //m_lstStudents.Add(new Student(studentName, fatherName, address, phoneNumber));

            Student student = new Student(studentName, fatherName, address, phoneNumber);
            if (!m_lstStudents.Contains(student))
                m_lstStudents.Add(student);

            LblIDValue.Text = Student.Current_ID_Value.ToString();
        }

        public int ValidateNewStudent(string stStudentName, string stFatherName, string stAddress, string stPhoneNumber, out string errMsg)
        {
            errMsg = string.Empty;

            if (string.IsNullOrWhiteSpace(stStudentName))
            {
                if (string.IsNullOrWhiteSpace(errMsg))
                    errMsg = "Please Enter";

                errMsg += " Student Name";
            }

            if (string.IsNullOrWhiteSpace(stFatherName))
            {
                if (string.IsNullOrWhiteSpace(errMsg))
                    errMsg = "Please Enter";
                else
                    errMsg += ",";

                errMsg += " Father Name";
            }

            if (string.IsNullOrWhiteSpace(stAddress))
            {
                if (string.IsNullOrWhiteSpace(errMsg))
                    errMsg = "Please Enter";
                else
                    errMsg += ",";

                errMsg += " Address";
            }

            if (string.IsNullOrWhiteSpace(stPhoneNumber))
            {
                if (string.IsNullOrWhiteSpace(errMsg))
                    errMsg = "Please Enter";
                else
                    errMsg += ",";

                errMsg += " Phone Number";
            }

            if (string.IsNullOrWhiteSpace(errMsg))
                return 0;

            return -1;
        }
    }
}
