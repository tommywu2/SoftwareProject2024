using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace SoftwareProject2024
{
    public partial class NewCustomer : Form
    {
        // Creates public strings to store the data from the textboxes.
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public string CardDate { get; set; }
        public string CardCVV { get; set; }

        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            // Sets the variables to the data in the textboxes.
            CustomerID = txtCustomerID.Text;
            FirstName = txtFirstName.Text;
            Surname = txtSurname.Text;
            Address = txtAddress.Text;
            CardNumber = txtCardNumber.Text;
            CardName = txtCardName.Text;
            CardDate = txtCardDate.Text;
            CardCVV = txtCardCVV.Text;

            // Sends the DialogResult.
            this.DialogResult = DialogResult.OK;

            // Closes the Form.
            this.Close();
        }
    }
}
