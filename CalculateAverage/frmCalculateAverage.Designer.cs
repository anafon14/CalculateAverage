namespace CalculateAverage
{
    partial class frmCalculateAverage
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblFirstMark = new System.Windows.Forms.Label();
            this.lblSecondMark = new System.Windows.Forms.Label();
            this.lblThirdMark = new System.Windows.Forms.Label();
            this.lblFourthMark = new System.Windows.Forms.Label();
            this.lblFifthMark = new System.Windows.Forms.Label();
            this.txtFirstMark = new System.Windows.Forms.TextBox();
            this.txtSecondMark = new System.Windows.Forms.TextBox();
            this.txtThirdMark = new System.Windows.Forms.TextBox();
            this.txtFourthMark = new System.Windows.Forms.TextBox();
            this.txtFifthMark = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(216, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Please write your marks on the boxes below:";
            // 
            // lblFirstMark
            // 
            this.lblFirstMark.AutoSize = true;
            this.lblFirstMark.Location = new System.Drawing.Point(19, 37);
            this.lblFirstMark.Name = "lblFirstMark";
            this.lblFirstMark.Size = new System.Drawing.Size(56, 13);
            this.lblFirstMark.TabIndex = 1;
            this.lblFirstMark.Text = "First Mark:";
            // 
            // lblSecondMark
            // 
            this.lblSecondMark.AutoSize = true;
            this.lblSecondMark.Location = new System.Drawing.Point(19, 65);
            this.lblSecondMark.Name = "lblSecondMark";
            this.lblSecondMark.Size = new System.Drawing.Size(74, 13);
            this.lblSecondMark.TabIndex = 2;
            this.lblSecondMark.Text = "Second Mark:";
            // 
            // lblThirdMark
            // 
            this.lblThirdMark.AutoSize = true;
            this.lblThirdMark.Location = new System.Drawing.Point(19, 93);
            this.lblThirdMark.Name = "lblThirdMark";
            this.lblThirdMark.Size = new System.Drawing.Size(61, 13);
            this.lblThirdMark.TabIndex = 3;
            this.lblThirdMark.Text = "Third Mark:";
            // 
            // lblFourthMark
            // 
            this.lblFourthMark.AutoSize = true;
            this.lblFourthMark.Location = new System.Drawing.Point(19, 118);
            this.lblFourthMark.Name = "lblFourthMark";
            this.lblFourthMark.Size = new System.Drawing.Size(67, 13);
            this.lblFourthMark.TabIndex = 4;
            this.lblFourthMark.Text = "Fourth Mark:";
            // 
            // lblFifthMark
            // 
            this.lblFifthMark.AutoSize = true;
            this.lblFifthMark.Location = new System.Drawing.Point(19, 146);
            this.lblFifthMark.Name = "lblFifthMark";
            this.lblFifthMark.Size = new System.Drawing.Size(57, 13);
            this.lblFifthMark.TabIndex = 5;
            this.lblFifthMark.Text = "Fifth Mark:";
            // 
            // txtFirstMark
            // 
            this.txtFirstMark.Location = new System.Drawing.Point(112, 34);
            this.txtFirstMark.Name = "txtFirstMark";
            this.txtFirstMark.Size = new System.Drawing.Size(100, 20);
            this.txtFirstMark.TabIndex = 6;
            this.txtFirstMark.TextChanged += new System.EventHandler(this.txtFirstMark_TextChanged);
            // 
            // txtSecondMark
            // 
            this.txtSecondMark.Location = new System.Drawing.Point(112, 62);
            this.txtSecondMark.Name = "txtSecondMark";
            this.txtSecondMark.Size = new System.Drawing.Size(100, 20);
            this.txtSecondMark.TabIndex = 7;
            this.txtSecondMark.TextChanged += new System.EventHandler(this.txtSecondMark_TextChanged);
            // 
            // txtThirdMark
            // 
            this.txtThirdMark.Location = new System.Drawing.Point(112, 90);
            this.txtThirdMark.Name = "txtThirdMark";
            this.txtThirdMark.Size = new System.Drawing.Size(100, 20);
            this.txtThirdMark.TabIndex = 8;
            this.txtThirdMark.TextChanged += new System.EventHandler(this.txtThirdMark_TextChanged);
            // 
            // txtFourthMark
            // 
            this.txtFourthMark.Location = new System.Drawing.Point(112, 115);
            this.txtFourthMark.Name = "txtFourthMark";
            this.txtFourthMark.Size = new System.Drawing.Size(100, 20);
            this.txtFourthMark.TabIndex = 9;
            this.txtFourthMark.TextChanged += new System.EventHandler(this.txtFourthMark_TextChanged);
            // 
            // txtFifthMark
            // 
            this.txtFifthMark.Location = new System.Drawing.Point(112, 143);
            this.txtFifthMark.Name = "txtFifthMark";
            this.txtFifthMark.Size = new System.Drawing.Size(100, 20);
            this.txtFifthMark.TabIndex = 10;
            this.txtFifthMark.TextChanged += new System.EventHandler(this.txtFifthMark_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(90, 178);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 37);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Lucida Console", 8.5F);
            this.lblResult.Location = new System.Drawing.Point(12, 227);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(249, 142);
            this.lblResult.TabIndex = 12;
            // 
            // frmCalculateAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 378);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFifthMark);
            this.Controls.Add(this.txtFourthMark);
            this.Controls.Add(this.txtThirdMark);
            this.Controls.Add(this.txtSecondMark);
            this.Controls.Add(this.txtFirstMark);
            this.Controls.Add(this.lblFifthMark);
            this.Controls.Add(this.lblFourthMark);
            this.Controls.Add(this.lblThirdMark);
            this.Controls.Add(this.lblSecondMark);
            this.Controls.Add(this.lblFirstMark);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmCalculateAverage";
            this.Text = "Calculate Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblFirstMark;
        private System.Windows.Forms.Label lblSecondMark;
        private System.Windows.Forms.Label lblThirdMark;
        private System.Windows.Forms.Label lblFourthMark;
        private System.Windows.Forms.Label lblFifthMark;
        private System.Windows.Forms.TextBox txtFirstMark;
        private System.Windows.Forms.TextBox txtSecondMark;
        private System.Windows.Forms.TextBox txtThirdMark;
        private System.Windows.Forms.TextBox txtFourthMark;
        private System.Windows.Forms.TextBox txtFifthMark;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}

