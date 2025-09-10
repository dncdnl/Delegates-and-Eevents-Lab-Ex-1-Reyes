using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm: Form
    {
        //Delegates for each Variables
        private StudentInfoClass.DelegateText DelProgram,
            DelFirstName,
            DelLastName,
            DelMiddleName,
            DelAddress;
        private StudentInfoClass.DelegateNumber DelAge,
            DelStudentNumber,
            DelContactNumber;
        public FrmConfirm()
        {
            InitializeComponent();
            //Initializing delegates
            DelProgram = StudentInfoClass.GetProgram;
            DelFirstName = StudentInfoClass.GetFirstName;
            DelLastName = StudentInfoClass.GetLastName;
            DelMiddleName = StudentInfoClass.GetMiddleName;
            DelAddress = StudentInfoClass.GetAddress;
            DelAge = StudentInfoClass.GetAge;
            DelStudentNumber = StudentInfoClass.GetStudentNo;
            DelContactNumber = StudentInfoClass.GetContactNo;
        }
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            //Displaying Registration Details
            lblProgramVal.Text = DelProgram(StudentInfoClass.Program);
            lblFirstnVal.Text = DelFirstName(StudentInfoClass.FirstName);
            lblLastnVal.Text = DelLastName(StudentInfoClass.LastName);
            lblMiddlenVal.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblGenderVal.Text = DelAddress(StudentInfoClass.Address);
            lblAgeVal.Text = DelAge(StudentInfoClass.Age).ToString();
            lblBirthdayVal.Text = DelContactNumber(StudentInfoClass.ContactNo).ToString();
            lblStudentVal.Text = DelStudentNumber(StudentInfoClass.StudentNo).ToString();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            // Event click
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
   
    }
}
