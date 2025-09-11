using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Account_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Adding new Access Modifier
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        /////return methods 
        public long StudentNumber(string studNum)
        {
            // Assignning the Argument Exception and Format Exception
            try
            {
                if (string.IsNullOrEmpty(studNum))
                {
                    throw new ArgumentException("Student Number cannot be empty.");
                }
                _StudentNo = long.Parse(studNum);
                return _StudentNo;
            }
            catch (FormatException)
            {
                throw new FormatException("Student Number must be numeric.");
            }
            catch (ArgumentNullException enx)
            {
                throw enx;
            }
        }

        public long ContactNo(string Contact)
        {
            // Using try catch block for overflow exception
            try
            {

                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    throw new FormatException("Contact Number must be 10 to 11 digits.");
                }
                else
                {
                    _ContactNo = long.Parse(Contact);
                }
                return _ContactNo;
            }
            catch (OverflowException)
            {
                throw new OverflowException("The Contact Number you entered is more that 10 to 11 digits");
            }
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }

        // Added the items in combobox for the program
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
            //Calling Static strings and int data types

            StudentInfoClass.SetFullName = FullName(tbLname.Text, tbFname.Text, tbMname.Text);
            StudentInfoClass.SetProgram = CbProgram.Text;
            StudentInfoClass.SetAddress = tbAddress.Text;
            StudentInfoClass.SetGender = cbGender.Text;
            StudentInfoClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            StudentInfoClass.SetAge = tbage.Text;
            StudentInfoClass.SetContactNo = (int)ContactNo(tbcontNum.Text); ;
            StudentInfoClass.SetStudentNo = (int)StudentNumber(tbstuNum.Text);

            //show dialog method
            FrmConfirm confirmForm = new FrmConfirm();
            DialogResult result = confirmForm.ShowDialog();
            //Verifying show dialog and reseting all textbox and combo box
            if ((result == DialogResult.OK))
            {
                MessageBox.Show("Successful Registration!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Registration is Cancelled...");
            }
        }
    }
}
