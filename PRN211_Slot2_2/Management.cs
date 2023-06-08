using Services.Models;
using Services.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Slot2_2
{
    public partial class Management : Form
    {
        List<Student> students = new List<Student>();
        AccountTypeService accountTypeService = new AccountTypeService();
        public Management()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                var student = new Student();
                student.Name = "Ho Duong " + i.ToString();
                student.Id = i;
                student.Age = i;
                student.Description = "Description " + i.ToString();
                student.Created = DateTime.Now;
                student.Phone = "0847919292";
                student.Email = "nguyenhdtse172921@fpt.edu.vn";
                students.Add(student);
            }
            dgvStudent.DataSource = accountTypeService.GetAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student();
                int id = 0, age = 0;
                bool checkId = int.TryParse(txtId.Text, out id);
                bool checkAge = int.TryParse(txtAge.Text, out age);
                bool checkValidAge1 = true;
                if (age < 18 && age > 100)
                {
                    MessageBox.Show("Student's age must be older than 18 to study at FPTU!", "Thong bao", MessageBoxButtons.OK);
                    txtAge.Text = string.Empty;
                    checkValidAge1 = false;
                }
                else
                {
                    DialogResult checkValidAge = MessageBox.Show("Do you want to confirm this student's age?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (checkValidAge == DialogResult.Yes)
                    {
                        checkValidAge1 = true;
                    }
                }
                bool checkExist = false;
                bool checkPhoneNumber = ValidatePhoneNumber(txtPhone.Text.Trim());
                bool checkEmail = ValidateEmail(txtEmail.Text.Trim());
                if (checkId && checkAge && checkPhoneNumber && checkEmail && checkValidAge1 && txtNameUpdate.Text.Trim().Length > 0 && txtDescriptionUpdate.Text.Trim().Length > 0)
                {
                    foreach (var i in students)
                    {
                        if (i.Id == id)
                        {
                            MessageBox.Show("Id is duplicate! Try Again!", "Thong bao", MessageBoxButtons.OK);
                            txtId.Text = string.Empty;
                            checkExist = true;
                            break;
                        }
                    }
                    if (checkExist != true)
                    {
                        student.Id = id;
                        student.Name = txtName.Text.Trim();
                        student.Description = txtDescription.Text.Trim();
                        student.Created = DateTime.Now;
                        student.Email = txtEmail.Text.Trim();
                        student.Phone = txtPhone.Text.Trim();
                        student.Age = age;
                        students.Add(student);
                        dgvStudent.DataSource = new BindingSource() { DataSource = students };
                        txtId.Text = string.Empty;
                        txtName.Text = string.Empty;
                        txtAge.Text = string.Empty;
                        txtDescription.Text = string.Empty;
                        txtPhone.Text = string.Empty;
                        txtEmail.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Data invalid! Try again!", "Thong bao", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui long ton trong ung dung! :)))", "Thong bao", MessageBoxButtons.OK);
            }
            /**/
        }

        private void dgvStudent_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = students[e.RowIndex];
            if (student != null)
            {
                txtIdUpdate.Text = student.Id.ToString();
                txtNameUpdate.Text = student.Name;
                txtAgeUpdate.Text = student.Age.ToString();
                txtDescriptionUpdate.Text = student.Description;
                txtEmailUpdate.Text = student.Email;
                txtPhoneUpdate.Text = student.Phone;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student();
                int id = 0, age = 0;
                bool checkId = int.TryParse(txtIdUpdate.Text, out id);
                bool checkAge = int.TryParse(txtAgeUpdate.Text, out age);
                string email = txtEmailUpdate.Text.Trim();
                string phone = txtPhoneUpdate.Text.Trim();
                bool checkPhone = ValidatePhoneNumber(phone);
                bool checkEmail = ValidateEmail(email);
                bool checkExist = false;
                bool checkValidAge1 = true;
                if (age < 18 && age < 100)
                {
                    MessageBox.Show("Student's age must be older than 18 to study at FPTU!", "Thong bao", MessageBoxButtons.OK);
                    txtAge.Text = string.Empty;
                    checkValidAge1 = false;
                }
                else
                {
                    DialogResult checkValidAge = MessageBox.Show("Do you want to confirm this student's age?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (checkValidAge == DialogResult.Yes)
                    {
                        checkValidAge1 = true;
                    }
                }
                if (checkId && checkAge && checkEmail && checkPhone && checkValidAge1 && txtNameUpdate.Text.Trim().Length > 0 && txtDescriptionUpdate.Text.Trim().Length > 0)
                {
                    foreach (var i in students)
                    {
                        if (i.Id == id)
                        {
                            checkExist = true;
                            break;
                        }
                    }
                    if (checkExist == true)
                    {
                        student.Id = id;
                        student.Name = txtNameUpdate.Text.Trim();
                        student.Created = DateTime.Now;
                        student.Description = txtDescriptionUpdate.Text.Trim();
                        student.Age = age;
                        student.Email = email;
                        student.Phone = phone;
                        students[student.Id] = student;
                        dgvStudent.DataSource = new BindingSource() { DataSource = students };
                        txtIdUpdate.Text = string.Empty;
                        txtNameUpdate.Text = string.Empty;
                        txtAgeUpdate.Text = string.Empty;
                        txtDescriptionUpdate.Text = string.Empty;
                        txtEmailUpdate.Text = string.Empty;
                        txtPhoneUpdate.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Data invalid! Try again!", "Thong bao", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui long ton trong ung dung! :)))", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            // Regular expression pattern for Vietnamese phone number validation
            string pattern = @"^0[1-9]\d{8}$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Match method to check if the phone number matches the pattern
            Match match = regex.Match(phoneNumber);

            // Return true if there is a match, indicating a valid phone number
            return match.Success;
        }

        public static bool ValidateEmail(string email)
        {
            // Regular expression pattern for email validation with domain "fpt.edu.vn"
            string pattern = @"^[A-Za-z0-9._%+-]+@fpt\.edu\.vn$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Match method to check if the email matches the pattern
            Match match = regex.Match(email);

            // Return true if there is a match, indicating a valid email
            return match.Success;
        }

        private void txtDescriptionUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudent.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete this student?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int rowIndex = dgvStudent.SelectedCells[0].RowIndex;
                        for (int i = 0; i < students.Count; i++)
                        {
                            if (students[i].Id == rowIndex)
                            {
                                students.Remove(students[i]);
                                break;
                            }
                        }
                        dgvStudent.DataSource = new BindingSource() { DataSource = students };
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui long ton trong ung dung :)))", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name, description must not be null!\n" +
                            "Age must be older than 18 to study at university, and must be less than 200.\n" +
                            "Phone number must contain 10 numbers and start with 0.\n" +
                            "Email must be FPT University, format ***@fpt.edu.vn", "Bo quy tac", MessageBoxButtons.OK);
        }

        private void Management_Load(object sender, EventArgs e)
        {

        }
    }
}
