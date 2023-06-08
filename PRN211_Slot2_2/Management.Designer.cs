namespace PRN211_Slot2_2
{
    partial class Management
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
            dgvStudent = new DataGridView();
            id = new Label();
            name = new Label();
            age = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            create = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIdUpdate = new TextBox();
            label4 = new Label();
            txtNameUpdate = new TextBox();
            label5 = new Label();
            txtAgeUpdate = new TextBox();
            button1 = new Button();
            label8 = new Label();
            txtDescription = new TextBox();
            txtDescriptionUpdate = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtPhone = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            txtEmailUpdate = new TextBox();
            label10 = new Label();
            txtPhoneUpdate = new TextBox();
            label11 = new Label();
            btnDelete = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToResizeRows = false;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStudent.BackgroundColor = SystemColors.Window;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.GridColor = SystemColors.ControlText;
            dgvStudent.Location = new Point(12, 12);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.RowTemplate.Height = 29;
            dgvStudent.Size = new Size(1139, 241);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellContentDoubleClick += dgvStudent_CellContentDoubleClick;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(12, 314);
            id.Name = "id";
            id.Size = new Size(24, 20);
            id.TabIndex = 1;
            id.Text = "ID";
            id.Click += label1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 349);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 2;
            name.Text = "Name";
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(12, 382);
            age.Name = "age";
            age.Size = new Size(36, 20);
            age.TabIndex = 3;
            age.Text = "Age";
            age.Click += age_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(131, 311);
            txtId.Name = "txtId";
            txtId.Size = new Size(262, 27);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 346);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 27);
            txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(131, 379);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(262, 27);
            txtAge.TabIndex = 6;
            // 
            // create
            // 
            create.Location = new Point(148, 524);
            create.Name = "create";
            create.Size = new Size(94, 29);
            create.TabIndex = 7;
            create.Text = "Create";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 273);
            label1.Name = "label1";
            label1.Size = new Size(213, 31);
            label1.TabIndex = 8;
            label1.Text = "Create new Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(627, 273);
            label2.Name = "label2";
            label2.Size = new Size(174, 31);
            label2.TabIndex = 9;
            label2.Text = "Update student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(627, 314);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 10;
            label3.Text = "ID";
            // 
            // txtIdUpdate
            // 
            txtIdUpdate.Location = new Point(743, 311);
            txtIdUpdate.Name = "txtIdUpdate";
            txtIdUpdate.ReadOnly = true;
            txtIdUpdate.Size = new Size(262, 27);
            txtIdUpdate.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(627, 349);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 12;
            label4.Text = "Name";
            // 
            // txtNameUpdate
            // 
            txtNameUpdate.Location = new Point(743, 346);
            txtNameUpdate.Name = "txtNameUpdate";
            txtNameUpdate.Size = new Size(262, 27);
            txtNameUpdate.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(627, 382);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 14;
            label5.Text = "Age";
            // 
            // txtAgeUpdate
            // 
            txtAgeUpdate.Location = new Point(743, 379);
            txtAgeUpdate.Name = "txtAgeUpdate";
            txtAgeUpdate.Size = new Size(262, 27);
            txtAgeUpdate.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(743, 524);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 415);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 17;
            label8.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(131, 412);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(262, 27);
            txtDescription.TabIndex = 18;
            // 
            // txtDescriptionUpdate
            // 
            txtDescriptionUpdate.Location = new Point(743, 412);
            txtDescriptionUpdate.Name = "txtDescriptionUpdate";
            txtDescriptionUpdate.Size = new Size(262, 27);
            txtDescriptionUpdate.TabIndex = 19;
            txtDescriptionUpdate.TextChanged += txtDescriptionUpdate_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(627, 415);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 20;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 451);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 21;
            label7.Text = "Phone number";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(131, 448);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(262, 27);
            txtPhone.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 490);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 23;
            label9.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 487);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 27);
            txtEmail.TabIndex = 24;
            // 
            // txtEmailUpdate
            // 
            txtEmailUpdate.Location = new Point(743, 487);
            txtEmailUpdate.Name = "txtEmailUpdate";
            txtEmailUpdate.Size = new Size(262, 27);
            txtEmailUpdate.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(624, 490);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 27;
            label10.Text = "Email";
            // 
            // txtPhoneUpdate
            // 
            txtPhoneUpdate.Location = new Point(743, 448);
            txtPhoneUpdate.Name = "txtPhoneUpdate";
            txtPhoneUpdate.Size = new Size(262, 27);
            txtPhoneUpdate.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(624, 451);
            label11.Name = "label11";
            label11.Size = new Size(105, 20);
            label11.TabIndex = 25;
            label11.Text = "Phone number";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1057, 259);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1067, 524);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 30;
            button2.Text = "Rules";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 565);
            Controls.Add(button2);
            Controls.Add(btnDelete);
            Controls.Add(txtEmailUpdate);
            Controls.Add(label10);
            Controls.Add(txtPhoneUpdate);
            Controls.Add(label11);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(txtPhone);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDescriptionUpdate);
            Controls.Add(txtDescription);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(txtAgeUpdate);
            Controls.Add(label5);
            Controls.Add(txtNameUpdate);
            Controls.Add(label4);
            Controls.Add(txtIdUpdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(create);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(age);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(dgvStudent);
            Name = "Management";
            Text = "Management";
            Load += Management_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudent;
        private Label id;
        private Label name;
        private Label age;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAge;
        private Button create;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdUpdate;
        private Label label4;
        private TextBox txtNameUpdate;
        private Label label5;
        private TextBox txtAgeUpdate;
        private Button button1;
        private Label label8;
        private TextBox txtDescription;
        private TextBox txtDescriptionUpdate;
        private Label label6;
        private Label label7;
        private TextBox txtPhone;
        private Label label9;
        private TextBox txtEmail;
        private TextBox txtEmailUpdate;
        private Label label10;
        private TextBox txtPhoneUpdate;
        private Label label11;
        private Button btnDelete;
        private Button button2;
    }
}