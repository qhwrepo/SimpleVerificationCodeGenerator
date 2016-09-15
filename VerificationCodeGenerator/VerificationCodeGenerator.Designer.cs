namespace VerificationCodeGenerator
{
    partial class VerificationCodeGenerator
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
            this.lbl_Change = new System.Windows.Forms.Label();
            this.btn_Verify = new System.Windows.Forms.Button();
            this.txtBox_Code = new System.Windows.Forms.TextBox();
            this.picBox_Image = new System.Windows.Forms.PictureBox();
            this.lab_Change = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Change
            // 
            this.lbl_Change.AutoSize = true;
            this.lbl_Change.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Change.Location = new System.Drawing.Point(209, 64);
            this.lbl_Change.Name = "lbl_Change";
            this.lbl_Change.Size = new System.Drawing.Size(41, 12);
            this.lbl_Change.TabIndex = 0;
            this.lbl_Change.Text = "Change";
            this.lbl_Change.Click += new System.EventHandler(this.lbl_Change_Click);
            // 
            // btn_Verify
            // 
            this.btn_Verify.Location = new System.Drawing.Point(211, 119);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(52, 23);
            this.btn_Verify.TabIndex = 1;
            this.btn_Verify.Text = "Verify";
            this.btn_Verify.UseVisualStyleBackColor = true;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // txtBox_Code
            // 
            this.txtBox_Code.Location = new System.Drawing.Point(49, 121);
            this.txtBox_Code.Name = "txtBox_Code";
            this.txtBox_Code.Size = new System.Drawing.Size(110, 21);
            this.txtBox_Code.TabIndex = 2;
            // 
            // picBox_Image
            // 
            this.picBox_Image.Location = new System.Drawing.Point(49, 42);
            this.picBox_Image.Name = "picBox_Image";
            this.picBox_Image.Size = new System.Drawing.Size(110, 34);
            this.picBox_Image.TabIndex = 3;
            this.picBox_Image.TabStop = false;
            // 
            // lab_Change
            // 
            this.lab_Change.AutoSize = true;
            this.lab_Change.Location = new System.Drawing.Point(211, 28);
            this.lab_Change.Name = "lab_Change";
            this.lab_Change.Size = new System.Drawing.Size(41, 12);
            this.lab_Change.TabIndex = 4;
            this.lab_Change.TabStop = true;
            this.lab_Change.Text = "Change";
            this.lab_Change.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lab_Change_LinkClicked);
            // 
            // VerificationCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 183);
            this.Controls.Add(this.lab_Change);
            this.Controls.Add(this.picBox_Image);
            this.Controls.Add(this.txtBox_Code);
            this.Controls.Add(this.btn_Verify);
            this.Controls.Add(this.lbl_Change);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VerificationCodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerificationCodeGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Change;
        private System.Windows.Forms.Button btn_Verify;
        private System.Windows.Forms.TextBox txtBox_Code;
        private System.Windows.Forms.PictureBox picBox_Image;
        private System.Windows.Forms.LinkLabel lab_Change;
    }
}

