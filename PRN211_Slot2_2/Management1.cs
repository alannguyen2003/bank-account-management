using Services.Models;
using Services.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Slot2_2
{
    public partial class Management1 : Form
    {
        public User User;
        BankAccountService BankAccountService = new BankAccountService();
        AccountTypeService AccountTypeService = new AccountTypeService();
        public Management1(User user)
        {
            InitializeComponent();
            User = user;
            if (User.UserRole == 1)
            {
                dgvBankAccount.DataSource = BankAccountService.GetAll();
                lblMessage.Text = string.Empty;
                txtNameUpdate.ReadOnly = true;
                dtpDateUpdate.Enabled = false;
                txtBranchUpdate.ReadOnly = true;
                cbTypeUpdate.Enabled = false;
                btnUpdate.Enabled = false;
                cbType.DataSource = AccountTypeService.GetAll();
                cbType.DisplayMember = "TypeName";
                cbType.ValueMember = "TypeId";
                cbTypeUpdate.DataSource = AccountTypeService.GetAll();
                cbTypeUpdate.DisplayMember = "TypeName";
                cbTypeUpdate.ValueMember = "TypeId";
            }
            else
            {
                lblMessage.Text = "You don't have permission to enter these functions!";
                txtId.ReadOnly = true;
                txtIdUpdate.ReadOnly = true;
                txtName.ReadOnly = true;
                txtNameUpdate.ReadOnly = true;
                dtpDate.Enabled = false;
                dtpDateUpdate.Enabled = false;
                txtBranch.ReadOnly = true;
                txtBranchUpdate.ReadOnly = true;
                cbType.Enabled = false;
                cbTypeUpdate.Enabled = false;
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
                btnSearch.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            String searchText = txtSearch.Text.Trim();
            if (searchText.Length > 100)
            {
                MessageBox.Show("Too long to search!! \nPlease try again!", "Thong bao", MessageBoxButtons.OK);
                txtSearch.Text = string.Empty;
                return;
            }
            List<BankAccount> bankAccounts = new List<BankAccount>();
            if (searchText.Equals(""))
            {
                bankAccounts = BankAccountService.GetAll();
            }
            else
            {
                foreach (BankAccount bankAccount in BankAccountService.GetAll())
                {
                    if (bankAccount.BranchName.ToLower().Contains(searchText.ToLower()))
                    {
                        bankAccounts.Add(bankAccount);
                    }
                }
            }
            if (bankAccounts.Count == 0)
            {
                lblMessage.Text = "No research matchings!";
            }
            dgvBankAccount.DataSource = new BindingSource() { DataSource = bankAccounts };
        }

        private void dgvBankAccount_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMessage.Text = string.Empty;
            var account = BankAccountService.GetAll()[e.RowIndex];
            if (account != null)
            {
                txtNameUpdate.ReadOnly = false;
                dtpDateUpdate.Enabled = true;
                txtBranchUpdate.ReadOnly = false;
                cbTypeUpdate.Enabled = true;
                btnUpdate.Enabled = true;
                txtNameUpdate.Text = account.AccountName;
                txtBranchUpdate.Text = account.BranchName;
                txtIdUpdate.Text = account.AccountId.ToString();
                dtpDateUpdate.Value = (DateTime)account.OpenDate;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            try
            {
                BankAccount bankAccount = new BankAccount();
                bankAccount.AccountId = txtId.Text.Trim();
                bankAccount.AccountName = txtName.Text.Trim();
                bankAccount.OpenDate = dtpDate.Value;
                bankAccount.BranchName = txtBranch.Text.Trim();
                var selectedItem = (AccountType)cbType.SelectedItem;
                bankAccount.TypeId = selectedItem.TypeId;
                if (!string.IsNullOrEmpty(txtId.Text.Trim()) && !string.IsNullOrEmpty(txtName.Text.Trim()) &&
                isValidBranch(txtBranch.Text.Trim()) && isExistItem(BankAccountService.GetAll(), bankAccount))
                {
                    BankAccountService.Add(bankAccount);
                    dgvBankAccount.DataSource = new BindingSource() { DataSource = BankAccountService.GetAll() };
                    lblMessage.Text = "Add successful!!";
                    txtId.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtBranch.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Invalid data to add!!\nPlease try again!!", "Thong bao", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui long ton trong ung dung :)))", "Thong bao", MessageBoxButtons.OK);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            try
            {
                if (dgvBankAccount.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete this account?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int rowIndex = dgvBankAccount.SelectedCells[0].RowIndex;
                        BankAccount bankAccount = BankAccountService.GetAll()[rowIndex];
                        BankAccountService.Delete(bankAccount);
                        dgvBankAccount.DataSource = new BindingSource() { DataSource = BankAccountService.GetAll() };
                        lblMessage.Text = "Delete successful!!";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui long ton trong ung dung :)))", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            try
            {
                BankAccount bankAccount = BankAccountService.GetAll()[dgvBankAccount.CurrentRow.Index];
                bankAccount.AccountId = txtIdUpdate.Text.Trim();
                bankAccount.AccountName = txtNameUpdate.Text.Trim();
                bankAccount.OpenDate = dtpDateUpdate.Value;
                bankAccount.BranchName = txtBranchUpdate.Text.Trim();
                var selectedItem = (AccountType)cbTypeUpdate.SelectedItem;
                bankAccount.TypeId = selectedItem.TypeId;
                if (!string.IsNullOrEmpty(txtNameUpdate.Text.Trim()) &&
                isValidBranch(txtBranchUpdate.Text.Trim()))
                {
                    MessageBox.Show(!string.IsNullOrEmpty(txtIdUpdate.Text.Trim()) + " " + !string.IsNullOrEmpty(txtNameUpdate.Text.Trim()) + " " +
                                     isValidBranch(txtBranchUpdate.Text.Trim()) + " " + !isExistItem(BankAccountService.GetAll(), bankAccount), "Thong bao", MessageBoxButtons.OK);
                    BankAccountService.Update(bankAccount);
                    dgvBankAccount.DataSource = new BindingSource() { DataSource = BankAccountService.GetAll() };
                    txtNameUpdate.ReadOnly = true;
                    dtpDateUpdate.Enabled = false;
                    txtBranchUpdate.ReadOnly = true;
                    cbTypeUpdate.Enabled = false;
                    btnUpdate.Enabled = false;
                    cbTypeUpdate.DataSource = AccountTypeService.GetAll();
                    cbTypeUpdate.DisplayMember = "TypeName";
                    cbTypeUpdate.ValueMember = "TypeId";
                    lblMessage.Text = "Update successful!!!";
                }
                else
                {
                    MessageBox.Show(!string.IsNullOrEmpty(txtIdUpdate.Text.Trim()) + " " + !string.IsNullOrEmpty(txtNameUpdate.Text.Trim()) + " " +
                                     isValidBranch(txtBranchUpdate.Text.Trim()) + " " + !isExistItem(BankAccountService.GetAll(), bankAccount), "Thong bao", MessageBoxButtons.OK);
                    MessageBox.Show("Invalid data to update!!\nPlease try again!!", "Thong bao", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui long ton trong ung dung :)))", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private bool isExistItem(List<BankAccount> bankAccounts, BankAccount bankAccount)
        {
            foreach (BankAccount item in bankAccounts)
            {
                if (item.AccountId.Equals(bankAccount.AccountId))
                {
                    return false;
                }
            }
            return true;
        }

        private bool isValidBranch(string String)
        {
            string[] afterSplit = String.Split(' ');
            foreach (string item in afterSplit)
            {
                if (string.IsNullOrEmpty(item) || !char.IsUpper(item[0]))
                {
                    return false;
                }

            }
            return String.Length > 5;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frLogin = new login();
            frLogin.ShowDialog();
        }

        private void Management1_Load(object sender, EventArgs e)
        {

        }
    }
}
