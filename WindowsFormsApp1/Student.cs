using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student
    {
        public static int Current_ID_Value = 1;
        int m_ID;

        public Student(string stStudentName, string stFatherName, string stAddress, string stPhoneNumber)
        {
            m_ID = Current_ID_Value++;
            StudentName = stStudentName;
            FatherName = stFatherName;
            Address = stAddress;
            PhoneNumber = stPhoneNumber;
        }

        public string ID
        {
            get { return "2020-SE-" + m_ID; }
        }

        public string StudentName { get; set; }

        public string FatherName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
    }
}