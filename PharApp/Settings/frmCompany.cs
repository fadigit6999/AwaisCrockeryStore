using PharApp.WinHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PharApp.Settings
{
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private async void frmCompany_Load(object sender, EventArgs e)
        {
            loadCompany();
        }

        private async void loadCompany()
        {
            var companyBal = new BAL.Company(Helper.GetConnectionStringFromSettings());
            List<BML.Company> companies = await companyBal.ReadCompanyAsync();

            if (companies != null && companies.Count > 0)
            {
                BML.Company company = companies[0];

                txtName.Text = company.CompanyName;
                txtAddress.Text = company.Address;
                txtCity.Text = company.City;
                txtState.Text = company.State;
                txtPostalCode.Text = company.PostalCode;
                txtCountry.Text = company.Country;
                txtPhone.Text = company.Phone;
                txtFax.Text = company.Fax;
                txtEmail.Text = company.Email;
                txtWebSite.Text = company.Website;
                txtContactPerson.Text = company.ContactPerson;
                txtContactPerson.Text = company.ContactPhone;
                txtEmail.Text = company.ContactEmail;
                txtRegistrationNo.Text = company.RegistrationNumber;
                txtTaxNo.Text = company.TaxNumber;
                txtNotes.Text = company.Notes;
            }
            else
            {
                MessageBox.Show("No companies found.");
            }
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            var companyBal = new BAL.Company(Helper.GetConnectionStringFromSettings());
            var company = new BML.Company();

            company.CompanyName = txtName.Text;
            company.Address = txtAddress.Text;
            company.City = txtCity.Text;
            company.State = txtState.Text;
            company.PostalCode = txtPostalCode.Text;
            company.Country = txtCountry.Text;
            company.Phone = txtPhone.Text;
            company.Fax = txtFax.Text;
            company.Email = txtEmail.Text;
            company.Website = txtWebSite.Text;
            company.ContactPerson = txtContactPerson.Text;
            company.ContactPhone = txtPhone.Text; // Corrected assignment
            company.ContactEmail = txtEmail.Text; // Corrected assignment
            company.RegistrationNumber = txtRegistrationNo.Text;
            company.TaxNumber = txtTaxNo.Text;
            company.Notes = txtNotes.Text;


            try
            {
                int result = await companyBal.CreateCompanyAsync(company.CompanyName,
    company.Address,
    company.City,
    company.State,
    company.PostalCode,
    company.Country,
    company.Phone,
    company.Fax,
    company.Email,
    company.Website,
    company.ContactPerson,
    company.ContactPhone,
    company.ContactEmail,
    company.RegistrationNumber,
    company.TaxNumber,
    company.Notes);
                Helper.Log("Company (Created-Updated): " + " ," + company.CompanyName);
                if (result > 0)
                {
                    MessageBox.Show("Company created successfully!");
                    loadCompany();
                }
                else
                {
                    MessageBox.Show("Failed to create company.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating company: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
