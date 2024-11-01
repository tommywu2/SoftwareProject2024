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
    public partial class NewItem : Form
    {
        // Creates public strings to store the data from the textboxes.
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string ProductBuyPrice { get; set; }
        public string ProductSellPrice { get; set; }
        public string ProductSales { get; set; }
        public string ProductStock { get; set; }
        public string ProductMeasurement { get; set; }
        public string ProductSupplier { get; set; }

        public NewItem()
        {
            InitializeComponent();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            // Sets the variables to the data in the textboxes.
            ProductCode = txtProductCode.Text;
            ProductName = txtProductName.Text;
            ProductCategory = txtProductCategory.Text;
            ProductBuyPrice = txtProductBuyPrice.Text;
            ProductSellPrice = txtProductSellPrice.Text;
            ProductSales = txtProductSales.Text;
            ProductStock = txtProductStock.Text;
            ProductMeasurement = txtProductMeasurement.Text;
            ProductSupplier = txtProductSupplier.Text;

            // Sends the DialogResult.
            this.DialogResult = DialogResult.OK;

            // Closes the Form.
            this.Close();
        }
    }
}
