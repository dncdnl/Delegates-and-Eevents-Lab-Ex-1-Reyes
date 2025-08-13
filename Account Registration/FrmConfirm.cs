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
            //Displaying Registration Detailes
            progLB.Text = DelProgram(StudentInfoClass.Program);
            FirstNLB.Text = DelFirstName(StudentInfoClass.FirstName);
            LastNLB.Text = DelLastName(StudentInfoClass.LastName);
            MiddleNLB.Text = DelMiddleName(StudentInfoClass.MiddleName);
            addLB.Text = DelAddress(StudentInfoClass.Address);
            ageLB.Text = DelAge(StudentInfoClass.Age).ToString();
            CNLB.Text = DelContactNumber(StudentInfoClass.ContactNo).ToString();
            SNLB.Text = DelStudentNumber(StudentInfoClass.StudentNo).ToString();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            // Event click
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        // form closing
        private void frmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
