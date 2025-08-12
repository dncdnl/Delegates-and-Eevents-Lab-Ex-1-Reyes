namespace Account_Registration
{
    partial class FrmConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirm));
            this.SN = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.Label();
            this.LastN = new System.Windows.Forms.Label();
            this.FirstN = new System.Windows.Forms.Label();
            this.MiddleN = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.CN = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SN
            // 
            this.SN.AutoSize = true;
            this.SN.BackColor = System.Drawing.Color.Azure;
            this.SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SN.Location = new System.Drawing.Point(13, 13);
            this.SN.Name = "SN";
            this.SN.Size = new System.Drawing.Size(74, 15);
            this.SN.TabIndex = 0;
            this.SN.Text = "Student No.:";
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.BackColor = System.Drawing.Color.Azure;
            this.P.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.Location = new System.Drawing.Point(13, 39);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(54, 15);
            this.P.TabIndex = 1;
            this.P.Text = "Pogram:";
            // 
            // LastN
            // 
            this.LastN.AutoSize = true;
            this.LastN.BackColor = System.Drawing.Color.Azure;
            this.LastN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastN.Location = new System.Drawing.Point(13, 63);
            this.LastN.Name = "LastN";
            this.LastN.Size = new System.Drawing.Size(70, 15);
            this.LastN.TabIndex = 2;
            this.LastN.Text = "Last Name:";
            // 
            // FirstN
            // 
            this.FirstN.AutoSize = true;
            this.FirstN.BackColor = System.Drawing.Color.Azure;
            this.FirstN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstN.Location = new System.Drawing.Point(13, 86);
            this.FirstN.Name = "FirstN";
            this.FirstN.Size = new System.Drawing.Size(70, 15);
            this.FirstN.TabIndex = 3;
            this.FirstN.Text = "First Name:";
            // 
            // MiddleN
            // 
            this.MiddleN.AutoSize = true;
            this.MiddleN.BackColor = System.Drawing.Color.Azure;
            this.MiddleN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleN.Location = new System.Drawing.Point(13, 109);
            this.MiddleN.Name = "MiddleN";
            this.MiddleN.Size = new System.Drawing.Size(85, 15);
            this.MiddleN.TabIndex = 4;
            this.MiddleN.Text = "Middle Name:";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.BackColor = System.Drawing.Color.Azure;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(13, 132);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(31, 15);
            this.A.TabIndex = 5;
            this.A.Text = "Age:";
            // 
            // CN
            // 
            this.CN.AutoSize = true;
            this.CN.BackColor = System.Drawing.Color.Azure;
            this.CN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CN.Location = new System.Drawing.Point(13, 155);
            this.CN.Name = "CN";
            this.CN.Size = new System.Drawing.Size(73, 15);
            this.CN.TabIndex = 6;
            this.CN.Text = "Contact No.:";
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.BackColor = System.Drawing.Color.Azure;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(13, 179);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(54, 15);
            this.add.TabIndex = 7;
            this.add.Text = "Address:";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.submit.Location = new System.Drawing.Point(96, 221);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // FrmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(283, 256);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.CN);
            this.Controls.Add(this.A);
            this.Controls.Add(this.MiddleN);
            this.Controls.Add(this.FirstN);
            this.Controls.Add(this.LastN);
            this.Controls.Add(this.P);
            this.Controls.Add(this.SN);
            this.Name = "FrmConfirm";
            this.Text = "FrmConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SN;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label LastN;
        private System.Windows.Forms.Label FirstN;
        private System.Windows.Forms.Label MiddleN;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label CN;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Button submit;
    }
}