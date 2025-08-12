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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            //Calling Static strings and Long data types
            StudentInfoClass.FirstName = tbFname.Text;
            StudentInfoClass.LastName = tbLname.Text;
            StudentInfoClass.MiddleName = tbMname.Text;
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.Address = tbAddress.Text;
            StudentInfoClass.Age = Convert.ToInt64(tbage.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(tbcontNum.Text);
            StudentInfoClass.StudentNo = Convert.ToInt64(tbstuNum.Text);

            FrmConfirm confirmForm = new FrmConfirm();
            DialogResult result = confirmForm.ShowDialog();
     
        }
    }
}
