namespace PRN211_Slot2_2
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            text1 = new Label();
            text2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Location = new Point(113, 97);
            text1.Name = "text1";
            text1.Size = new Size(75, 20);
            text1.TabIndex = 0;
            text1.Text = "Username";
            // 
            // text2
            // 
            text2.AutoSize = true;
            text2.Location = new Point(113, 158);
            text2.Name = "text2";
            text2.Size = new Size(70, 20);
            text2.TabIndex = 1;
            text2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(247, 94);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(336, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(247, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(336, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(272, 210);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(285, 23);
            label1.Name = "label1";
            label1.Size = new Size(161, 58);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // button1
            // 
            button1.Location = new Point(395, 210);
            button1.Name = "button1";
            button1.Size = new Size(159, 29);
            button1.TabIndex = 6;
            button1.Text = "Reset password";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 318);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 7;
            label2.Text = "Copyright by NguyenHo";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(text2);
            Controls.Add(text1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text1;
        private Label text2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}