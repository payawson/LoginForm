namespace LoginForm
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
            this.payawson = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // payawson
            // 
            this.payawson.AutoSize = true;
            this.payawson.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.payawson.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payawson.Location = new System.Drawing.Point(54, 29);
            this.payawson.Name = "payawson";
            this.payawson.Size = new System.Drawing.Size(80, 16);
            this.payawson.TabIndex = 1;
            this.payawson.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Articulate", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password :";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(121, 29);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(155, 20);
            this.username.TabIndex = 3;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(119, 101);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(155, 20);
            this.password.TabIndex = 4;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.login.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(158, 181);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 5;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Don\'t have accont? create a new account.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payawson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label payawson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label3;
    }
}

