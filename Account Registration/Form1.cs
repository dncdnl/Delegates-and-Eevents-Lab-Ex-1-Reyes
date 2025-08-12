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
        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProgram.Items.Add("\t BS in Information Technology (BSIT)");
            cbProgram.Items.Add("\t BS in Computer Science (BSCS)");
            cbProgram.Items.Add("\t BS in Information Systems (BSIS)");
            cbProgram.Items.Add("\t BS in Business Administration (BSBA)");
            cbProgram.Items.Add("\t BS in BS in Accountancy (BSA)");
            cbProgram.Items.Add("\t BS in Accounting Information System (BSAIS)");
            cbProgram.Items.Add("\t BS in Management Accounting (BSMA)");
            cbProgram.Items.Add("\t BS in Retail Technology and Consumer Science (BSRTCS)");
            cbProgram.Items.Add("\t BS in Hospitality Management (BSHM)");
            cbProgram.Items.Add("\t BS in Culinary Management (BSCM)");
            cbProgram.Items.Add("\t BS in Tourism Management (BSTM)");
            cbProgram.Items.Add("\t BS in Computer Engineering (BSCpE)");
            cbProgram.Items.Add("\t BA in Communication (BACOMM)");
            cbProgram.Items.Add("\t Bachelor of Multimedia Arts (BMMA)");
            cbProgram.Items.Add("\t Bachelor of Arts in Psychology");
            cbProgram.Items.Add("\t Bachelor of Science in Marine Transportation (BSMT)");
            cbProgram.Items.Add("\t Bachelor of Science in Marine Engineering (BSMarE)");
            cbProgram.Items.Add("\t Bachelor of Science in Naval Architecture and Marine Engineering (BSNAME)");
            cbProgram.Items.Add("\t Bachelor of Science in Criminology");
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

            //show dialog method
            FrmConfirm confirmForm = new FrmConfirm();
            DialogResult result = confirmForm.ShowDialog();
            //Verifying show dialog and reseting all textbox and combo box
            if ((result == DialogResult.OK))
            {
                MessageBox.Show("Successful Registration!");
                foreach ( Control ctrl in this.Controls)
                {
                    if(ctrl is TextBox ) 
                        ((TextBox)ctrl).Clear();
                    if(ctrl is ComboBox)
                        ((ComboBox)ctrl).SelectedIndex= -1;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration is Cancelled...");
            }
        }

    }
}
