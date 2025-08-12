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
        }
    }
}
