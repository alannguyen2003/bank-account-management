namespace PRN211_Slot2_2
{
    partial class Management1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management1));
            dgvBankAccount = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            lblMessage = new Label();
            label7 = new Label();
            txtBranch = new TextBox();
            label8 = new Label();
            label2 = new Label();
            btnCreate = new Button();
            txtName = new TextBox();
            txtId = new TextBox();
            age = new Label();
            name = new Label();
            id = new Label();
            btnUpdate = new Button();
            label12 = new Label();
            btnDelete = new Button();
            dtpDate = new DateTimePicker();
            btnSearch = new Button();
            cbType = new ComboBox();
            cbTypeUpdate = new ComboBox();
            dtpDateUpdate = new DateTimePicker();
            label3 = new Label();
            txtBranchUpdate = new TextBox();
            label4 = new Label();
            txtNameUpdate = new TextBox();
            txtIdUpdate = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBankAccount).BeginInit();
            SuspendLayout();
            // 
            // dgvBankAccount
            // 
            dgvBankAccount.AllowUserToResizeRows = false;
            dgvBankAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBankAccount.BackgroundColor = SystemColors.Window;
            dgvBankAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankAccount.GridColor = SystemColors.ControlText;
            dgvBankAccount.Location = new Point(12, 59);
            dgvBankAccount.Name = "dgvBankAccount";
            dgvBankAccount.ReadOnly = true;
            dgvBankAccount.RowHeadersWidth = 51;
            dgvBankAccount.RowTemplate.Height = 29;
            dgvBankAccount.Size = new Size(1082, 241);
            dgvBankAccount.TabIndex = 1;
            dgvBankAccount.CellContentDoubleClick += dgvBankAccount_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(594, 19);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 2;
            label1.Text = "Search by Branch: ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(737, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(237, 27);
            txtSearch.TabIndex = 3;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(21, 15);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(129, 20);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "Search by Branch: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 520);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 35;
            label7.Text = "Account type";
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(131, 481);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(262, 27);
            txtBranch.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 484);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 33;
            label8.Text = "Branch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 334);
            label2.Name = "label2";
            label2.Size = new Size(215, 31);
            label2.TabIndex = 32;
            label2.Text = "Create new account";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(144, 555);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 31;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 415);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 27);
            txtName.TabIndex = 29;
            // 
            // txtId
            // 
            txtId.Location = new Point(131, 380);
            txtId.Name = "txtId";
            txtId.Size = new Size(262, 27);
            txtId.TabIndex = 28;
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(12, 451);
            age.Name = "age";
            age.Size = new Size(79, 20);
            age.TabIndex = 27;
            age.Text = "Open date";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 418);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 26;
            name.Text = "Name";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(12, 383);
            id.Name = "id";
            id.Size = new Size(82, 20);
            id.TabIndex = 25;
            id.Text = "Account ID";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(767, 558);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(621, 338);
            label12.Name = "label12";
            label12.Size = new Size(177, 31);
            label12.TabIndex = 39;
            label12.Text = "Update account";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1000, 318);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(131, 446);
            dtpDate.MaxDate = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            dtpDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(262, 27);
            dtpDate.TabIndex = 54;
            dtpDate.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1000, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 55;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(131, 521);
            cbType.Name = "cbType";
            cbType.Size = new Size(262, 28);
            cbType.TabIndex = 56;
            // 
            // cbTypeUpdate
            // 
            cbTypeUpdate.FormattingEnabled = true;
            cbTypeUpdate.Location = new Point(737, 524);
            cbTypeUpdate.Name = "cbTypeUpdate";
            cbTypeUpdate.Size = new Size(262, 28);
            cbTypeUpdate.TabIndex = 66;
            // 
            // dtpDateUpdate
            // 
            dtpDateUpdate.Location = new Point(737, 449);
            dtpDateUpdate.MaxDate = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            dtpDateUpdate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpDateUpdate.Name = "dtpDateUpdate";
            dtpDateUpdate.Size = new Size(262, 27);
            dtpDateUpdate.TabIndex = 65;
            dtpDateUpdate.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(618, 523);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 64;
            label3.Text = "Account type";
            // 
            // txtBranchUpdate
            // 
            txtBranchUpdate.Location = new Point(737, 484);
            txtBranchUpdate.Name = "txtBranchUpdate";
            txtBranchUpdate.Size = new Size(262, 27);
            txtBranchUpdate.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(618, 487);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 62;
            label4.Text = "Branch";
            // 
            // txtNameUpdate
            // 
            txtNameUpdate.Location = new Point(737, 418);
            txtNameUpdate.Name = "txtNameUpdate";
            txtNameUpdate.Size = new Size(262, 27);
            txtNameUpdate.TabIndex = 61;
            // 
            // txtIdUpdate
            // 
            txtIdUpdate.Location = new Point(737, 383);
            txtIdUpdate.Name = "txtIdUpdate";
            txtIdUpdate.ReadOnly = true;
            txtIdUpdate.Size = new Size(262, 27);
            txtIdUpdate.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(618, 454);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 59;
            label5.Text = "Open date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(618, 421);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 58;
            label6.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(618, 386);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 57;
            label9.Text = "Account ID";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1014, 558);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 67;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Management1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1106, 598);
            Controls.Add(btnLogout);
            Controls.Add(cbTypeUpdate);
            Controls.Add(dtpDateUpdate);
            Controls.Add(label3);
            Controls.Add(txtBranchUpdate);
            Controls.Add(label4);
            Controls.Add(txtNameUpdate);
            Controls.Add(txtIdUpdate);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(cbType);
            Controls.Add(btnSearch);
            Controls.Add(dtpDate);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(txtBranch);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(btnCreate);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(age);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(lblMessage);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgvBankAccount);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Management1";
            Text = "Management1";
            Load += Management1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBankAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBankAccount;
        private Label label1;
        private TextBox txtSearch;
        private Label lblMessage;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label label7;
        private TextBox txtBranch;
        private Label label8;
        private Label label2;
        private Button btnCreate;
        private TextBox txtAge;
        private TextBox txtName;
        private TextBox txtId;
        private Label age;
        private Label name;
        private Label id;
        private TextBox txtEmailUpdate;
        private Label label10;
        private TextBox txtPhoneUpdate;
        private Label label11;
        private TextBox txtDescriptionUpdate;
        private Button btnUpdate;
        private TextBox txtAgeUpdate;
        private Label label12;
        private Button btnDelete;
        private DateTimePicker dtpDate;
        private Button btnSearch;
        private ComboBox cbType;
        private ComboBox cbTypeUpdate;
        private DateTimePicker dtpDateUpdate;
        private Label label3;
        private TextBox txtBranchUpdate;
        private Label label4;
        private TextBox txtNameUpdate;
        private TextBox txtIdUpdate;
        private Label label5;
        private Label label6;
        private Label label9;
        private Button btnLogout;
    }
}