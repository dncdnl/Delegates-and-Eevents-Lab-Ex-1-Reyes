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
            DelFullName,
            DelAge,
            DelAddress;

     

        private StudentInfoClass.DelegateNumber 
            DelStudentNumber,
            DelContactNumber;
        public FrmConfirm()
        {
            InitializeComponent();
            //Initializing delegates
            DelProgram = StudentInfoClass.GetProgram;
            DelFullName = StudentInfoClass.GetFullName;
            DelAddress = StudentInfoClass.GetAddress;
            DelAge = StudentInfoClass.GetAge;
            DelStudentNumber = StudentInfoClass.GetStudentNo;
            DelContactNumber = StudentInfoClass.GetContactNo;
        }
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            //Displaying Registration Details
            lblProgramVal.Text = DelProgram(StudentInfoClass.Program);
            lblNameVal.Text = DelFullName(StudentInfoClass.FullName);
            lblGenderVal.Text = DelAddress(StudentInfoClass.Address);
            lblAgeVal.Text = DelAge(StudentInfoClass.Age).ToString();
            lblBirthdayVal.Text = DelContactNumber(StudentInfoClass.ContactNo).ToString();
            lblStudentVal.Text = DelStudentNumber(StudentInfoClass.StudentNo).ToString();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            // Adding the given code in Step 10 for the Submit button
            StudentInfoClass.SetFullName = FullName(tbLname.Text, tbFname.Text, tbMname.Text);

            // Event click
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
   
    }
}
