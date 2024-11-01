namespace SoftwareProject2024
{
    partial class StoreInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreInventory));
            this.btnNewItem = new System.Windows.Forms.Button();
            this.dgvStoreInventory = new System.Windows.Forms.DataGridView();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            this.txtProductBuyPrice = new System.Windows.Forms.TextBox();
            this.txtProductMeasurement = new System.Windows.Forms.TextBox();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.txtProductSales = new System.Windows.Forms.TextBox();
            this.txtProductSellPrice = new System.Windows.Forms.TextBox();
            this.txtProductSupplier = new System.Windows.Forms.TextBox();
            this.btnSaveStoreInventory = new System.Windows.Forms.Button();
            this.btnSearchReset = new System.Windows.Forms.Button();
            this.comboBoxSearchCategory = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProductBuyPrice = new System.Windows.Forms.Label();
            this.lblProductSellPrice = new System.Windows.Forms.Label();
            this.lblProductSales = new System.Windows.Forms.Label();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.lblProductMeasurement = new System.Windows.Forms.Label();
            this.lblProductSupplier = new System.Windows.Forms.Label();
            this.plMenu = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tLPTextBoxes = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreInventory)).BeginInit();
            this.plMenu.SuspendLayout();
            this.tLPTextBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewItem
            // 
            this.btnNewItem.BackColor = System.Drawing.Color.White;
            this.btnNewItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewItem.FlatAppearance.BorderSize = 0;
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItem.ForeColor = System.Drawing.Color.Black;
            this.btnNewItem.Location = new System.Drawing.Point(0, 0);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(200, 50);
            this.btnNewItem.TabIndex = 0;
            this.btnNewItem.Text = "New Item";
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // dgvStoreInventory
            // 
            this.dgvStoreInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStoreInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvStoreInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoreInventory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStoreInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoreInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStoreInventory.GridColor = System.Drawing.Color.White;
            this.dgvStoreInventory.Location = new System.Drawing.Point(200, 53);
            this.dgvStoreInventory.MultiSelect = false;
            this.dgvStoreInventory.Name = "dgvStoreInventory";
            this.dgvStoreInventory.RowHeadersWidth = 25;
            this.dgvStoreInventory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
            this.dgvStoreInventory.Size = new System.Drawing.Size(1078, 391);
            this.dgvStoreInventory.TabIndex = 1;
            this.dgvStoreInventory.SelectionChanged += new System.EventHandler(this.dgvStoreInventory_SelectionChanged);
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.BackColor = System.Drawing.Color.White;
            this.btnSearchItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchItem.FlatAppearance.BorderSize = 0;
            this.btnSearchItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchItem.ForeColor = System.Drawing.Color.Black;
            this.btnSearchItem.Location = new System.Drawing.Point(0, 150);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(200, 50);
            this.btnSearchItem.TabIndex = 2;
            this.btnSearchItem.Text = "Search Item";
            this.btnSearchItem.UseVisualStyleBackColor = false;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.White;
            this.btnRemoveItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveItem.Location = new System.Drawing.Point(0, 50);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(200, 50);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.Color.White;
            this.txtProductCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductCode.ForeColor = System.Drawing.Color.Black;
            this.txtProductCode.Location = new System.Drawing.Point(3, 29);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(113, 20);
            this.txtProductCode.TabIndex = 4;
            this.txtProductCode.Text = "Product Code";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.Location = new System.Drawing.Point(122, 29);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(113, 20);
            this.txtProductName.TabIndex = 5;
            this.txtProductName.Text = "Product Name";
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.BackColor = System.Drawing.Color.White;
            this.txtProductCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductCategory.ForeColor = System.Drawing.Color.Black;
            this.txtProductCategory.Location = new System.Drawing.Point(241, 29);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(113, 20);
            this.txtProductCategory.TabIndex = 6;
            this.txtProductCategory.Text = "Product Category";
            // 
            // txtProductBuyPrice
            // 
            this.txtProductBuyPrice.BackColor = System.Drawing.Color.White;
            this.txtProductBuyPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductBuyPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductBuyPrice.ForeColor = System.Drawing.Color.Black;
            this.txtProductBuyPrice.Location = new System.Drawing.Point(360, 29);
            this.txtProductBuyPrice.Name = "txtProductBuyPrice";
            this.txtProductBuyPrice.Size = new System.Drawing.Size(113, 20);
            this.txtProductBuyPrice.TabIndex = 7;
            this.txtProductBuyPrice.Text = "Product Buy Price";
            // 
            // txtProductMeasurement
            // 
            this.txtProductMeasurement.BackColor = System.Drawing.Color.White;
            this.txtProductMeasurement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductMeasurement.ForeColor = System.Drawing.Color.Black;
            this.txtProductMeasurement.Location = new System.Drawing.Point(836, 29);
            this.txtProductMeasurement.Name = "txtProductMeasurement";
            this.txtProductMeasurement.Size = new System.Drawing.Size(113, 20);
            this.txtProductMeasurement.TabIndex = 11;
            this.txtProductMeasurement.Text = "Product Measurement";
            // 
            // txtProductStock
            // 
            this.txtProductStock.BackColor = System.Drawing.Color.White;
            this.txtProductStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductStock.ForeColor = System.Drawing.Color.Black;
            this.txtProductStock.Location = new System.Drawing.Point(717, 29);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(113, 20);
            this.txtProductStock.TabIndex = 10;
            this.txtProductStock.Text = "Product Stock";
            // 
            // txtProductSales
            // 
            this.txtProductSales.BackColor = System.Drawing.Color.White;
            this.txtProductSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductSales.ForeColor = System.Drawing.Color.Black;
            this.txtProductSales.Location = new System.Drawing.Point(598, 29);
            this.txtProductSales.Name = "txtProductSales";
            this.txtProductSales.Size = new System.Drawing.Size(113, 20);
            this.txtProductSales.TabIndex = 9;
            this.txtProductSales.Text = "Product Sales";
            // 
            // txtProductSellPrice
            // 
            this.txtProductSellPrice.BackColor = System.Drawing.Color.White;
            this.txtProductSellPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductSellPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductSellPrice.ForeColor = System.Drawing.Color.Black;
            this.txtProductSellPrice.Location = new System.Drawing.Point(479, 29);
            this.txtProductSellPrice.Name = "txtProductSellPrice";
            this.txtProductSellPrice.Size = new System.Drawing.Size(113, 20);
            this.txtProductSellPrice.TabIndex = 8;
            this.txtProductSellPrice.Text = "Product Sell Price";
            // 
            // txtProductSupplier
            // 
            this.txtProductSupplier.BackColor = System.Drawing.Color.White;
            this.txtProductSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductSupplier.ForeColor = System.Drawing.Color.Black;
            this.txtProductSupplier.Location = new System.Drawing.Point(955, 29);
            this.txtProductSupplier.Name = "txtProductSupplier";
            this.txtProductSupplier.Size = new System.Drawing.Size(120, 20);
            this.txtProductSupplier.TabIndex = 12;
            this.txtProductSupplier.Text = "Product Supplier";
            // 
            // btnSaveStoreInventory
            // 
            this.btnSaveStoreInventory.BackColor = System.Drawing.Color.White;
            this.btnSaveStoreInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveStoreInventory.FlatAppearance.BorderSize = 0;
            this.btnSaveStoreInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStoreInventory.ForeColor = System.Drawing.Color.Black;
            this.btnSaveStoreInventory.Location = new System.Drawing.Point(0, 100);
            this.btnSaveStoreInventory.Name = "btnSaveStoreInventory";
            this.btnSaveStoreInventory.Size = new System.Drawing.Size(200, 50);
            this.btnSaveStoreInventory.TabIndex = 13;
            this.btnSaveStoreInventory.Text = "Save Store Inventory";
            this.btnSaveStoreInventory.UseVisualStyleBackColor = false;
            this.btnSaveStoreInventory.Click += new System.EventHandler(this.btnSaveStoreInventory_Click);
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.BackColor = System.Drawing.Color.White;
            this.btnSearchReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchReset.FlatAppearance.BorderSize = 0;
            this.btnSearchReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReset.ForeColor = System.Drawing.Color.Black;
            this.btnSearchReset.Location = new System.Drawing.Point(0, 200);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(200, 50);
            this.btnSearchReset.TabIndex = 14;
            this.btnSearchReset.Text = "Search Reset";
            this.btnSearchReset.UseVisualStyleBackColor = false;
            this.btnSearchReset.Click += new System.EventHandler(this.btnSearchReset_Click);
            // 
            // comboBoxSearchCategory
            // 
            this.comboBoxSearchCategory.BackColor = System.Drawing.Color.White;
            this.comboBoxSearchCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearchCategory.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSearchCategory.FormattingEnabled = true;
            this.comboBoxSearchCategory.Items.AddRange(new object[] {
            "Product Code",
            "Product Name",
            "Product Category",
            "Product Buy Price",
            "Product Sell Price",
            "Product Sales",
            "Product Stock",
            "Product Measurement",
            "Product Supplier"});
            this.comboBoxSearchCategory.Location = new System.Drawing.Point(0, 250);
            this.comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            this.comboBoxSearchCategory.Size = new System.Drawing.Size(200, 27);
            this.comboBoxSearchCategory.TabIndex = 15;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.BackColor = System.Drawing.Color.White;
            this.txtSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchValue.ForeColor = System.Drawing.Color.Black;
            this.txtSearchValue.Location = new System.Drawing.Point(0, 277);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(200, 20);
            this.txtSearchValue.TabIndex = 16;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.BackColor = System.Drawing.Color.White;
            this.lblProductCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductCode.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.ForeColor = System.Drawing.Color.Black;
            this.lblProductCode.Location = new System.Drawing.Point(3, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(113, 26);
            this.lblProductCode.TabIndex = 17;
            this.lblProductCode.Text = "Product Code";
            this.lblProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.White;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductName.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Black;
            this.lblProductName.Location = new System.Drawing.Point(122, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(113, 26);
            this.lblProductName.TabIndex = 18;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.BackColor = System.Drawing.Color.White;
            this.lblProductCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductCategory.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.ForeColor = System.Drawing.Color.Black;
            this.lblProductCategory.Location = new System.Drawing.Point(241, 0);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(113, 26);
            this.lblProductCategory.TabIndex = 19;
            this.lblProductCategory.Text = "Product Category";
            this.lblProductCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductBuyPrice
            // 
            this.lblProductBuyPrice.AutoSize = true;
            this.lblProductBuyPrice.BackColor = System.Drawing.Color.White;
            this.lblProductBuyPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductBuyPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductBuyPrice.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductBuyPrice.ForeColor = System.Drawing.Color.Black;
            this.lblProductBuyPrice.Location = new System.Drawing.Point(360, 0);
            this.lblProductBuyPrice.Name = "lblProductBuyPrice";
            this.lblProductBuyPrice.Size = new System.Drawing.Size(113, 26);
            this.lblProductBuyPrice.TabIndex = 20;
            this.lblProductBuyPrice.Text = "Product Buy Price";
            this.lblProductBuyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductSellPrice
            // 
            this.lblProductSellPrice.AutoSize = true;
            this.lblProductSellPrice.BackColor = System.Drawing.Color.White;
            this.lblProductSellPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductSellPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductSellPrice.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSellPrice.ForeColor = System.Drawing.Color.Black;
            this.lblProductSellPrice.Location = new System.Drawing.Point(479, 0);
            this.lblProductSellPrice.Name = "lblProductSellPrice";
            this.lblProductSellPrice.Size = new System.Drawing.Size(113, 26);
            this.lblProductSellPrice.TabIndex = 21;
            this.lblProductSellPrice.Text = "Product Sell Price";
            this.lblProductSellPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductSales
            // 
            this.lblProductSales.AutoSize = true;
            this.lblProductSales.BackColor = System.Drawing.Color.White;
            this.lblProductSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductSales.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSales.ForeColor = System.Drawing.Color.Black;
            this.lblProductSales.Location = new System.Drawing.Point(598, 0);
            this.lblProductSales.Name = "lblProductSales";
            this.lblProductSales.Size = new System.Drawing.Size(113, 26);
            this.lblProductSales.TabIndex = 22;
            this.lblProductSales.Text = "Product Sales";
            this.lblProductSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.BackColor = System.Drawing.Color.White;
            this.lblProductStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductStock.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductStock.ForeColor = System.Drawing.Color.Black;
            this.lblProductStock.Location = new System.Drawing.Point(717, 0);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(113, 26);
            this.lblProductStock.TabIndex = 23;
            this.lblProductStock.Text = "Product Stock";
            this.lblProductStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductMeasurement
            // 
            this.lblProductMeasurement.AutoSize = true;
            this.lblProductMeasurement.BackColor = System.Drawing.Color.White;
            this.lblProductMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductMeasurement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductMeasurement.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductMeasurement.ForeColor = System.Drawing.Color.Black;
            this.lblProductMeasurement.Location = new System.Drawing.Point(836, 0);
            this.lblProductMeasurement.Name = "lblProductMeasurement";
            this.lblProductMeasurement.Size = new System.Drawing.Size(113, 26);
            this.lblProductMeasurement.TabIndex = 24;
            this.lblProductMeasurement.Text = "Product Measurement";
            this.lblProductMeasurement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductSupplier
            // 
            this.lblProductSupplier.AutoSize = true;
            this.lblProductSupplier.BackColor = System.Drawing.Color.White;
            this.lblProductSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductSupplier.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSupplier.ForeColor = System.Drawing.Color.Black;
            this.lblProductSupplier.Location = new System.Drawing.Point(955, 0);
            this.lblProductSupplier.Name = "lblProductSupplier";
            this.lblProductSupplier.Size = new System.Drawing.Size(120, 26);
            this.lblProductSupplier.TabIndex = 25;
            this.lblProductSupplier.Text = "Product Supplier";
            this.lblProductSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plMenu
            // 
            this.plMenu.BackColor = System.Drawing.Color.White;
            this.plMenu.Controls.Add(this.txtSearchValue);
            this.plMenu.Controls.Add(this.comboBoxSearchCategory);
            this.plMenu.Controls.Add(this.btnSearchReset);
            this.plMenu.Controls.Add(this.btnSearchItem);
            this.plMenu.Controls.Add(this.btnSaveStoreInventory);
            this.plMenu.Controls.Add(this.btnRemoveItem);
            this.plMenu.Controls.Add(this.btnNewItem);
            this.plMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plMenu.ForeColor = System.Drawing.Color.Black;
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(200, 444);
            this.plMenu.TabIndex = 26;
            // 
            // tLPTextBoxes
            // 
            this.tLPTextBoxes.BackColor = System.Drawing.Color.White;
            this.tLPTextBoxes.ColumnCount = 9;
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.Controls.Add(this.lblProductCode, 0, 0);
            this.tLPTextBoxes.Controls.Add(this.txtProductCode, 0, 1);
            this.tLPTextBoxes.Controls.Add(this.txtProductSupplier, 8, 1);
            this.tLPTextBoxes.Controls.Add(this.lblProductSupplier, 8, 0);
            this.tLPTextBoxes.Controls.Add(this.lblProductName, 1, 0);
            this.tLPTextBoxes.Controls.Add(this.lblProductMeasurement, 7, 0);
            this.tLPTextBoxes.Controls.Add(this.txtProductMeasurement, 7, 1);
            this.tLPTextBoxes.Controls.Add(this.txtProductName, 1, 1);
            this.tLPTextBoxes.Controls.Add(this.lblProductStock, 6, 0);
            this.tLPTextBoxes.Controls.Add(this.lblProductCategory, 2, 0);
            this.tLPTextBoxes.Controls.Add(this.txtProductStock, 6, 1);
            this.tLPTextBoxes.Controls.Add(this.lblProductSales, 5, 0);
            this.tLPTextBoxes.Controls.Add(this.txtProductCategory, 2, 1);
            this.tLPTextBoxes.Controls.Add(this.lblProductSellPrice, 4, 0);
            this.tLPTextBoxes.Controls.Add(this.txtProductSales, 5, 1);
            this.tLPTextBoxes.Controls.Add(this.lblProductBuyPrice, 3, 0);
            this.tLPTextBoxes.Controls.Add(this.txtProductBuyPrice, 3, 1);
            this.tLPTextBoxes.Controls.Add(this.txtProductSellPrice, 4, 1);
            this.tLPTextBoxes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tLPTextBoxes.ForeColor = System.Drawing.Color.Black;
            this.tLPTextBoxes.Location = new System.Drawing.Point(200, 0);
            this.tLPTextBoxes.Name = "tLPTextBoxes";
            this.tLPTextBoxes.RowCount = 2;
            this.tLPTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPTextBoxes.Size = new System.Drawing.Size(1078, 53);
            this.tLPTextBoxes.TabIndex = 27;
            // 
            // StoreInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 444);
            this.Controls.Add(this.dgvStoreInventory);
            this.Controls.Add(this.tLPTextBoxes);
            this.Controls.Add(this.plMenu);
            this.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 500);
            this.Name = "StoreInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Inventory";
            this.Load += new System.EventHandler(this.StoreInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreInventory)).EndInit();
            this.plMenu.ResumeLayout(false);
            this.plMenu.PerformLayout();
            this.tLPTextBoxes.ResumeLayout(false);
            this.tLPTextBoxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.DataGridView dgvStoreInventory;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCategory;
        private System.Windows.Forms.TextBox txtProductBuyPrice;
        private System.Windows.Forms.TextBox txtProductMeasurement;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.TextBox txtProductSales;
        private System.Windows.Forms.TextBox txtProductSellPrice;
        private System.Windows.Forms.TextBox txtProductSupplier;
        private System.Windows.Forms.Button btnSaveStoreInventory;
        private System.Windows.Forms.Button btnSearchReset;
        private System.Windows.Forms.ComboBox comboBoxSearchCategory;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProductBuyPrice;
        private System.Windows.Forms.Label lblProductSellPrice;
        private System.Windows.Forms.Label lblProductSales;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.Label lblProductMeasurement;
        private System.Windows.Forms.Label lblProductSupplier;
        private System.Windows.Forms.Panel plMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tLPTextBoxes;
    }
}