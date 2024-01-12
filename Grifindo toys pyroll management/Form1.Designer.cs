namespace Grifindo_toys_pyroll_management
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Grifindo_Toys_payroll_system = new System.Windows.Forms.Label();
            this.label_PASWORD = new System.Windows.Forms.Label();
            this.label_USER = new System.Windows.Forms.Label();
            this.txtusr = new System.Windows.Forms.TextBox();
            this.txtpaw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(296, 499);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Grifindo_Toys_payroll_system
            // 
            this.Grifindo_Toys_payroll_system.AutoSize = true;
            this.Grifindo_Toys_payroll_system.BackColor = System.Drawing.Color.White;
            this.Grifindo_Toys_payroll_system.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grifindo_Toys_payroll_system.Location = new System.Drawing.Point(125, 26);
            this.Grifindo_Toys_payroll_system.Name = "Grifindo_Toys_payroll_system";
            this.Grifindo_Toys_payroll_system.Size = new System.Drawing.Size(445, 39);
            this.Grifindo_Toys_payroll_system.TabIndex = 17;
            this.Grifindo_Toys_payroll_system.Text = "Grifindo Toys payroll system";
            // 
            // label_PASWORD
            // 
            this.label_PASWORD.AutoSize = true;
            this.label_PASWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PASWORD.ForeColor = System.Drawing.Color.Black;
            this.label_PASWORD.Location = new System.Drawing.Point(161, 316);
            this.label_PASWORD.Name = "label_PASWORD";
            this.label_PASWORD.Size = new System.Drawing.Size(98, 25);
            this.label_PASWORD.TabIndex = 22;
            this.label_PASWORD.Text = "Password";
            // 
            // label_USER
            // 
            this.label_USER.AutoSize = true;
            this.label_USER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_USER.ForeColor = System.Drawing.Color.Black;
            this.label_USER.Location = new System.Drawing.Point(161, 258);
            this.label_USER.Name = "label_USER";
            this.label_USER.Size = new System.Drawing.Size(110, 25);
            this.label_USER.TabIndex = 21;
            this.label_USER.Text = "User Name";
            // 
            // txtusr
            // 
            this.txtusr.Location = new System.Drawing.Point(296, 258);
            this.txtusr.Name = "txtusr";
            this.txtusr.Size = new System.Drawing.Size(242, 22);
            this.txtusr.TabIndex = 19;
            this.txtusr.Text = "Admin";
            // 
            // txtpaw
            // 
            this.txtpaw.Location = new System.Drawing.Point(296, 316);
            this.txtpaw.Name = "txtpaw";
            this.txtpaw.PasswordChar = '*';
            this.txtpaw.Size = new System.Drawing.Size(242, 22);
            this.txtpaw.TabIndex = 20;
            this.txtpaw.Text = "123";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(166, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(694, 613);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Grifindo_Toys_payroll_system);
            this.Controls.Add(this.label_PASWORD);
            this.Controls.Add(this.label_USER);
            this.Controls.Add(this.txtusr);
            this.Controls.Add(this.txtpaw);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Grifindo_Toys_payroll_system;
        private System.Windows.Forms.Label label_PASWORD;
        private System.Windows.Forms.Label label_USER;
        private System.Windows.Forms.TextBox txtusr;
        private System.Windows.Forms.TextBox txtpaw;
        private System.Windows.Forms.Button button1;

    }
}

