namespace SoftwareProject2024
{
    partial class CustomerData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerData));
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.dgvCustomerData = new System.Windows.Forms.DataGridView();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCardCVV = new System.Windows.Forms.TextBox();
            this.txtCardDate = new System.Windows.Forms.TextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnSaveCustomerData = new System.Windows.Forms.Button();
            this.btnSearchReset = new System.Windows.Forms.Button();
            this.comboBoxSearchCategory = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblCardDate = new System.Windows.Forms.Label();
            this.lblCardCVV = new System.Windows.Forms.Label();
            this.plMenu = new System.Windows.Forms.Panel();
            this.tLPTextBoxes = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).BeginInit();
            this.plMenu.SuspendLayout();
            this.tLPTextBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewCustomer.FlatAppearance.BorderSize = 0;
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCustomer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNewCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(220, 68);
            this.btnNewCustomer.TabIndex = 0;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // dgvCustomerData
            // 
            this.dgvCustomerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomerData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.dgvCustomerData.Location = new System.Drawing.Point(220, 106);
            this.dgvCustomerData.MultiSelect = false;
            this.dgvCustomerData.Name = "dgvCustomerData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerData.RowHeadersWidth = 25;
            this.dgvCustomerData.RowTemplate.Height = 28;
            this.dgvCustomerData.Size = new System.Drawing.Size(1258, 338);
            this.dgvCustomerData.TabIndex = 1;
            this.dgvCustomerData.SelectionChanged += new System.EventHandler(this.dgvCustomerData_SelectionChanged);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSearchCustomer.Location = new System.Drawing.Point(0, 272);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(220, 68);
            this.btnSearchCustomer.TabIndex = 2;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveCustomer.FlatAppearance.BorderSize = 0;
            this.btnRemoveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCustomer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnRemoveCustomer.Location = new System.Drawing.Point(0, 68);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(220, 68);
            this.btnRemoveCustomer.TabIndex = 3;
            this.btnRemoveCustomer.Text = "Remove Customer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCustomerID.Location = new System.Drawing.Point(3, 56);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(151, 25);
            this.txtCustomerID.TabIndex = 4;
            this.txtCustomerID.Text = "Customer ID";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtFirstName.Location = new System.Drawing.Point(160, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(151, 25);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.Text = "First Name";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSurname.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtSurname.Location = new System.Drawing.Point(317, 56);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(151, 25);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.Text = "Surname";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtAddress.Location = new System.Drawing.Point(474, 56);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(151, 25);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.Text = "Address";
            // 
            // txtCardCVV
            // 
            this.txtCardCVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtCardCVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardCVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCardCVV.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardCVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCardCVV.Location = new System.Drawing.Point(1102, 56);
            this.txtCardCVV.Name = "txtCardCVV";
            this.txtCardCVV.Size = new System.Drawing.Size(153, 25);
            this.txtCardCVV.TabIndex = 11;
            this.txtCardCVV.Text = "Card CVV";
            // 
            // txtCardDate
            // 
            this.txtCardDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtCardDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCardDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCardDate.Location = new System.Drawing.Point(945, 56);
            this.txtCardDate.Name = "txtCardDate";
            this.txtCardDate.Size = new System.Drawing.Size(151, 25);
            this.txtCardDate.TabIndex = 10;
            this.txtCardDate.Text = "Card Date";
            // 
            // txtCardName
            // 
            this.txtCardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtCardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCardName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCardName.Location = new System.Drawing.Point(788, 56);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(151, 25);
            this.txtCardName.TabIndex = 9;
            this.txtCardName.Text = "Card Name";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCardNumber.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCardNumber.Location = new System.Drawing.Point(631, 56);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(151, 25);
            this.txtCardNumber.TabIndex = 8;
            this.txtCardNumber.Text = "Card Number";
            // 
            // btnSaveCustomerData
            // 
            this.btnSaveCustomerData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveCustomerData.FlatAppearance.BorderSize = 0;
            this.btnSaveCustomerData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCustomerData.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCustomerData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSaveCustomerData.Location = new System.Drawing.Point(0, 136);
            this.btnSaveCustomerData.Name = "btnSaveCustomerData";
            this.btnSaveCustomerData.Size = new System.Drawing.Size(220, 68);
            this.btnSaveCustomerData.TabIndex = 13;
            this.btnSaveCustomerData.Text = "Save Customer Data";
            this.btnSaveCustomerData.UseVisualStyleBackColor = true;
            this.btnSaveCustomerData.Click += new System.EventHandler(this.btnSaveCustomerData_Click);
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchReset.FlatAppearance.BorderSize = 0;
            this.btnSearchReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReset.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSearchReset.Location = new System.Drawing.Point(0, 204);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(220, 68);
            this.btnSearchReset.TabIndex = 14;
            this.btnSearchReset.Text = "Search Reset";
            this.btnSearchReset.UseVisualStyleBackColor = true;
            this.btnSearchReset.Click += new System.EventHandler(this.btnSearchReset_Click);
            // 
            // comboBoxSearchCategory
            // 
            this.comboBoxSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.comboBoxSearchCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearchCategory.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.comboBoxSearchCategory.FormattingEnabled = true;
            this.comboBoxSearchCategory.Items.AddRange(new object[] {
            "Customer ID",
            "First Name",
            "Surname",
            "Address",
            "Card Number",
            "Card Name",
            "Card Data",
            "Card CVV"});
            this.comboBoxSearchCategory.Location = new System.Drawing.Point(0, 340);
            this.comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            this.comboBoxSearchCategory.Size = new System.Drawing.Size(220, 33);
            this.comboBoxSearchCategory.TabIndex = 15;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.txtSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchValue.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtSearchValue.Location = new System.Drawing.Point(0, 373);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(220, 25);
            this.txtSearchValue.TabIndex = 16;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblCustomerID.Location = new System.Drawing.Point(3, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(151, 53);
            this.lblCustomerID.TabIndex = 17;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblFirstName.Location = new System.Drawing.Point(160, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(151, 53);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSurname.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblSurname.Location = new System.Drawing.Point(317, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(151, 53);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Surname";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblAddress.Location = new System.Drawing.Point(474, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(151, 53);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Address";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCardNumber.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblCardNumber.Location = new System.Drawing.Point(631, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(151, 53);
            this.lblCardNumber.TabIndex = 21;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCardName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblCardName.Location = new System.Drawing.Point(788, 0);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(151, 53);
            this.lblCardName.TabIndex = 22;
            this.lblCardName.Text = "Card Name";
            // 
            // lblCardDate
            // 
            this.lblCardDate.AutoSize = true;
            this.lblCardDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCardDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblCardDate.Location = new System.Drawing.Point(945, 0);
            this.lblCardDate.Name = "lblCardDate";
            this.lblCardDate.Size = new System.Drawing.Size(151, 53);
            this.lblCardDate.TabIndex = 23;
            this.lblCardDate.Text = "Card Date";
            // 
            // lblCardCVV
            // 
            this.lblCardCVV.AutoSize = true;
            this.lblCardCVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCardCVV.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardCVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblCardCVV.Location = new System.Drawing.Point(1102, 0);
            this.lblCardCVV.Name = "lblCardCVV";
            this.lblCardCVV.Size = new System.Drawing.Size(153, 53);
            this.lblCardCVV.TabIndex = 24;
            this.lblCardCVV.Text = "Card CVV";
            // 
            // plMenu
            // 
            this.plMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.plMenu.Controls.Add(this.txtSearchValue);
            this.plMenu.Controls.Add(this.comboBoxSearchCategory);
            this.plMenu.Controls.Add(this.btnSearchCustomer);
            this.plMenu.Controls.Add(this.btnSearchReset);
            this.plMenu.Controls.Add(this.btnSaveCustomerData);
            this.plMenu.Controls.Add(this.btnRemoveCustomer);
            this.plMenu.Controls.Add(this.btnNewCustomer);
            this.plMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(220, 444);
            this.plMenu.TabIndex = 29;
            // 
            // tLPTextBoxes
            // 
            this.tLPTextBoxes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tLPTextBoxes.ColumnCount = 8;
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPTextBoxes.Controls.Add(this.lblCustomerID, 0, 0);
            this.tLPTextBoxes.Controls.Add(this.txtCustomerID, 0, 1);
            this.tLPTextBoxes.Controls.Add(this.txtCardCVV, 7, 1);
            this.tLPTextBoxes.Controls.Add(this.lblCardCVV, 7, 0);
            this.tLPTextBoxes.Controls.Add(this.lblFirstName, 1, 0);
            this.tLPTextBoxes.Controls.Add(this.lblCardNumber, 4, 0);
            this.tLPTextBoxes.Controls.Add(this.lblCardName, 5, 0);
            this.tLPTextBoxes.Controls.Add(this.lblCardDate, 6, 0);
            this.tLPTextBoxes.Controls.Add(this.txtFirstName, 1, 1);
            this.tLPTextBoxes.Controls.Add(this.lblSurname, 2, 0);
            this.tLPTextBoxes.Controls.Add(this.txtSurname, 2, 1);
            this.tLPTextBoxes.Controls.Add(this.lblAddress, 3, 0);
            this.tLPTextBoxes.Controls.Add(this.txtCardDate, 6, 1);
            this.tLPTextBoxes.Controls.Add(this.txtAddress, 3, 1);
            this.tLPTextBoxes.Controls.Add(this.txtCardName, 5, 1);
            this.tLPTextBoxes.Controls.Add(this.txtCardNumber, 4, 1);
            this.tLPTextBoxes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tLPTextBoxes.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLPTextBoxes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tLPTextBoxes.Location = new System.Drawing.Point(220, 0);
            this.tLPTextBoxes.Name = "tLPTextBoxes";
            this.tLPTextBoxes.RowCount = 2;
            this.tLPTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPTextBoxes.Size = new System.Drawing.Size(1258, 106);
            this.tLPTextBoxes.TabIndex = 30;
            // 
            // CustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 444);
            this.Controls.Add(this.dgvCustomerData);
            this.Controls.Add(this.tLPTextBoxes);
            this.Controls.Add(this.plMenu);
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 500);
            this.Name = "CustomerData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Data";
            this.Load += new System.EventHandler(this.CustomerData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).EndInit();
            this.plMenu.ResumeLayout(false);
            this.plMenu.PerformLayout();
            this.tLPTextBoxes.ResumeLayout(false);
            this.tLPTextBoxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.DataGridView dgvCustomerData;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCardCVV;
        private System.Windows.Forms.TextBox txtCardDate;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Button btnSaveCustomerData;
        private System.Windows.Forms.Button btnSearchReset;
        private System.Windows.Forms.ComboBox comboBoxSearchCategory;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblCardDate;
        private System.Windows.Forms.Label lblCardCVV;
        private System.Windows.Forms.Panel plMenu;
        private System.Windows.Forms.TableLayoutPanel tLPTextBoxes;
    }
}