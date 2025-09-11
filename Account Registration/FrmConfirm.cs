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
            DelAddress,
            DelGender,
            DelBirthday;

     

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
            DelBirthday = StudentInfoClass.GetBirthday;
            DelGender = StudentInfoClass.GetGender;
            DelStudentNumber = StudentInfoClass.GetStudentNo;
            DelContactNumber = StudentInfoClass.GetContactNo;
        }
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            //Displaying Registration Details

            lblProgramVal.Text = DelProgram(StudentInfoClass.SetProgram);
            lblNameVal.Text = DelFullName(StudentInfoClass.SetFullName);
            lblAddressVal.Text = DelAddress(StudentInfoClass.SetAddress);
            lblAgeVal.Text = DelAge(StudentInfoClass.SetAge).ToString();
            lblBirthdayVal.Text = DelBirthday(StudentInfoClass.SetBirthday);
            lblGenderVal.Text = DelGender(StudentInfoClass.SetGender);
            lblContactNoVal.Text = DelContactNumber(StudentInfoClass.SetContactNo).ToString();
            lblStudentVal.Text = DelStudentNumber(StudentInfoClass.SetStudentNo).ToString();
        }
        private void submit_Click(object sender, EventArgs e)
        {
           
            // Event click
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
   
    }
}
