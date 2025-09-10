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
            CbProgram.Items.Add("\t BS in Information Technology (BSIT)");
            CbProgram.Items.Add("\t BS in Computer Science (BSCS)");
            CbProgram.Items.Add("\t BS in Information Systems (BSIS)");
            CbProgram.Items.Add("\t BS in Business Administration (BSBA)");
            CbProgram.Items.Add("\t BS in BS in Accountancy (BSA)");
            CbProgram.Items.Add("\t BS in Accounting Information System (BSAIS)");
            CbProgram.Items.Add("\t BS in Management Accounting (BSMA)");
            CbProgram.Items.Add("\t BS in Retail Technology and Consumer Science (BSRTCS)");
            CbProgram.Items.Add("\t BS in Hospitality Management (BSHM)");
            CbProgram.Items.Add("\t BS in Culinary Management (BSCM)");
            CbProgram.Items.Add("\t BS in Tourism Management (BSTM)");
            CbProgram.Items.Add("\t BS in Computer Engineering (BSCpE)");
            CbProgram.Items.Add("\t BA in Communication (BACOMM)");
            CbProgram.Items.Add("\t Bachelor of Multimedia Arts (BMMA)");
            CbProgram.Items.Add("\t Bachelor of Arts in Psychology");
            CbProgram.Items.Add("\t Bachelor of Science in Marine Transportation (BSMT)");
            CbProgram.Items.Add("\t Bachelor of Science in Marine Engineering (BSMarE)");
            CbProgram.Items.Add("\t Bachelor of Science in Naval Architecture and Marine Engineering (BSNAME)");
            CbProgram.Items.Add("\t Bachelor of Science in Criminology");
        }
        // Adding items in combobox for the gender

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGender.Items.Add("\t Female");
            cbGender.Items.Add("\t Male");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Calling Static strings and Long data types
            StudentInfoClass.FirstName = tbFname.Text;
            StudentInfoClass.LastName = tbLname.Text;
            StudentInfoClass.MiddleName = tbMname.Text;
            StudentInfoClass.Program = CbProgram.Text;
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
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                        ((TextBox)ctrl).Clear();
                    if (ctrl is ComboBox)
                        ((ComboBox)ctrl).SelectedIndex = -1;
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
