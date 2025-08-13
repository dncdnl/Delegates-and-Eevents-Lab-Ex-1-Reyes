namespace Account_Registration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stuNo = new System.Windows.Forms.Label();
            this.tbstuNum = new System.Windows.Forms.TextBox();
            this.prog = new System.Windows.Forms.Label();
            this.Ln = new System.Windows.Forms.Label();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.mn = new System.Windows.Forms.Label();
            this.tbMname = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.tbage = new System.Windows.Forms.TextBox();
            this.contNo = new System.Windows.Forms.Label();
            this.tbcontNum = new System.Windows.Forms.TextBox();
            this.CbProgram = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stuNo
            // 
            this.stuNo.AutoSize = true;
            this.stuNo.BackColor = System.Drawing.Color.Transparent;
            this.stuNo.Location = new System.Drawing.Point(13, 22);
            this.stuNo.Name = "stuNo";
            this.stuNo.Size = new System.Drawing.Size(64, 13);
            this.stuNo.TabIndex = 0;
            this.stuNo.Text = "Student No.";
            // 
            // tbstuNum
            // 
            this.tbstuNum.Location = new System.Drawing.Point(16, 39);
            this.tbstuNum.Name = "tbstuNum";
            this.tbstuNum.Size = new System.Drawing.Size(118, 20);
            this.tbstuNum.TabIndex = 1;
            // 
            // prog
            // 
            this.prog.AutoSize = true;
            this.prog.BackColor = System.Drawing.Color.Transparent;
            this.prog.Location = new System.Drawing.Point(140, 22);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(46, 13);
            this.prog.TabIndex = 3;
            this.prog.Text = "Program";
            // 
            // Ln
            // 
            this.Ln.AutoSize = true;
            this.Ln.BackColor = System.Drawing.Color.Transparent;
            this.Ln.Location = new System.Drawing.Point(16, 66);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(58, 13);
            this.Ln.TabIndex = 5;
            this.Ln.Text = "Last Name";
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(16, 82);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(118, 20);
            this.tbLname.TabIndex = 6;
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.BackColor = System.Drawing.Color.Transparent;
            this.fn.Location = new System.Drawing.Point(143, 66);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(57, 13);
            this.fn.TabIndex = 7;
            this.fn.Text = "First Name";
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(140, 81);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(117, 20);
            this.tbFname.TabIndex = 8;
            // 
            // mn
            // 
            this.mn.AutoSize = true;
            this.mn.BackColor = System.Drawing.Color.Transparent;
            this.mn.Location = new System.Drawing.Point(260, 66);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(69, 13);
            this.mn.TabIndex = 9;
            this.mn.Text = "Middle Name";
            // 
            // tbMname
            // 
            this.tbMname.Location = new System.Drawing.Point(263, 81);
            this.tbMname.Name = "tbMname";
            this.tbMname.Size = new System.Drawing.Size(121, 20);
            this.tbMname.TabIndex = 10;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.BackColor = System.Drawing.Color.Transparent;
            this.age.Location = new System.Drawing.Point(16, 109);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(26, 13);
            this.age.TabIndex = 11;
            this.age.Text = "Age";
            // 
            // tbage
            // 
            this.tbage.Location = new System.Drawing.Point(19, 125);
            this.tbage.Name = "tbage";
            this.tbage.Size = new System.Drawing.Size(115, 20);
            this.tbage.TabIndex = 12;
            // 
            // contNo
            // 
            this.contNo.AutoSize = true;
            this.contNo.BackColor = System.Drawing.Color.Transparent;
            this.contNo.Location = new System.Drawing.Point(140, 109);
            this.contNo.Name = "contNo";
            this.contNo.Size = new System.Drawing.Size(64, 13);
            this.contNo.TabIndex = 14;
            this.contNo.Text = "Contact No.";
            // 
            // tbcontNum
            // 
            this.tbcontNum.Location = new System.Drawing.Point(141, 124);
            this.tbcontNum.Name = "tbcontNum";
            this.tbcontNum.Size = new System.Drawing.Size(116, 20);
            this.tbcontNum.TabIndex = 15;
            // 
            // CbProgram
            // 
            this.CbProgram.FormattingEnabled = true;
            this.CbProgram.Items.AddRange(new object[] {
            "BS in Information Technology (BSIT)",
            "BS in Computer Science (BSCS)",
            "BS in Information Systems (BSIS)",
            "BS in Business Administration (BSBA)",
            "BS in BS in Accountancy (BSA)",
            "BS in Accounting Information System (BSAIS)",
            "BS in Management Accounting (BSMA)",
            "BS in Retail Technology and Consumer Science (BSRTCS)",
            "BS in Hospitality Management (BSHM)",
            "BS in Culinary Management (BSCM)",
            "BS in Tourism Management (BSTM)",
            "BS in Computer Engineering (BSCpE)",
            "BA in Communication (BACOMM)",
            "Bachelor of Multimedia Arts (BMMA)",
            "Bachelor of Arts in Psychology",
            "Bachelor of Science in Marine Transportation (BSMT)",
            "Bachelor of Science in Marine Engineering (BSMarE)",
            "Bachelor of Science in Naval Architecture and Marine Engineering (BSNAME)",
            "Bachelor of Science in Criminology"});
            this.CbProgram.Location = new System.Drawing.Point(146, 39);
            this.CbProgram.Name = "CbProgram";
            this.CbProgram.Size = new System.Drawing.Size(183, 21);
            this.CbProgram.TabIndex = 17;
            this.CbProgram.SelectedIndexChanged += new System.EventHandler(this.cbProgram_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.Location = new System.Drawing.Point(16, 159);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(45, 13);
            this.Add.TabIndex = 18;
            this.Add.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAddress.Location = new System.Drawing.Point(16, 176);
            this.tbAddress.MaximumSize = new System.Drawing.Size(400, 400);
            this.tbAddress.MinimumSize = new System.Drawing.Size(20, 100);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(370, 100);
            this.tbAddress.TabIndex = 19;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.SeaShell;
            this.next.Location = new System.Drawing.Point(157, 285);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 20;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(398, 320);
            this.Controls.Add(this.next);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CbProgram);
            this.Controls.Add(this.tbcontNum);
            this.Controls.Add(this.contNo);
            this.Controls.Add(this.tbage);
            this.Controls.Add(this.age);
            this.Controls.Add(this.tbMname);
            this.Controls.Add(this.mn);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.prog);
            this.Controls.Add(this.tbstuNum);
            this.Controls.Add(this.stuNo);
            this.Name = "Form1";
            this.Text = "frmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stuNo;
        private System.Windows.Forms.TextBox tbstuNum;
        private System.Windows.Forms.Label prog;
        private System.Windows.Forms.Label Ln;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.Label fn;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Label mn;
        private System.Windows.Forms.TextBox tbMname;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox tbage;
        private System.Windows.Forms.Label contNo;
        private System.Windows.Forms.TextBox tbcontNum;
        private System.Windows.Forms.ComboBox CbProgram;
        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button next;
    }
}

