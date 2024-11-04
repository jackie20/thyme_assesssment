namespace ThymeFrontEnd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HomePanel = new Panel();
            panel1 = new Panel();
            CustomersdataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            Column8 = new DataGridViewButtonColumn();
            Column9 = new DataGridViewButtonColumn();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            addInvoiceBtn = new Button();
            addCustomerBtn = new Button();
            addCustomerPanel = new Panel();
            panel5 = new Panel();
            btnCancelAddClient = new Button();
            btnSaveNewCustomer = new Button();
            txtCustomer_add_code = new TextBox();
            txtCustomer_add_address = new TextBox();
            label4 = new Label();
            txtCustomer_add_contact = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCustomer_add_description = new TextBox();
            label1 = new Label();
            EditCustomerPanel = new Panel();
            panel7 = new Panel();
            label9 = new Label();
            btnCancelEditCustomer = new Button();
            btnSaveEditCustomer = new Button();
            txtEditCustomer_code = new TextBox();
            txtEditCustomer_address = new TextBox();
            label5 = new Label();
            txtEditCustomer_contact = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtEditCustomer_discription = new TextBox();
            label8 = new Label();
            add_invoice_panel = new Panel();
            btnCancel_add_invoice = new Button();
            btnSaveInvoice = new Button();
            label15 = new Label();
            label20 = new Label();
            panel8 = new Panel();
            txt_add_invoice_quantity = new NumericUpDown();
            txt_add_invoice_line_total = new TextBox();
            txt_add_invoice_unit_price = new TextBox();
            txt_add_invoice_item_description = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            panel6 = new Panel();
            txt_add_invoice_CustomerCombo = new ComboBox();
            txtInvoiceNumber = new Label();
            txt_add_invoice_address = new TextBox();
            txt_add_invoice_telephone = new TextBox();
            txt_add_invoice_names = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label21 = new Label();
            label14 = new Label();
            view_invoices_panel = new Panel();
            InvoicesdataGridView = new DataGridView();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewButtonColumn();
            Column20 = new DataGridViewButtonColumn();
            Column21 = new DataGridViewButtonColumn();
            panel12 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            btn_go_back = new Button();
            btn_add_invocie = new Button();
            panel9 = new Panel();
            edit_invoice_panel = new Panel();
            button1 = new Button();
            button2 = new Button();
            label22 = new Label();
            label23 = new Label();
            panel14 = new Panel();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            panel15 = new Panel();
            comboBox1 = new ComboBox();
            label28 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            HomePanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersdataGridView).BeginInit();
            addCustomerPanel.SuspendLayout();
            panel5.SuspendLayout();
            EditCustomerPanel.SuspendLayout();
            panel7.SuspendLayout();
            add_invoice_panel.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txt_add_invoice_quantity).BeginInit();
            panel6.SuspendLayout();
            view_invoices_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvoicesdataGridView).BeginInit();
            panel10.SuspendLayout();
            edit_invoice_panel.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel15.SuspendLayout();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(panel1);
            HomePanel.Controls.Add(addInvoiceBtn);
            HomePanel.Controls.Add(addCustomerBtn);
            HomePanel.Location = new Point(883, 497);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(139, 95);
            HomePanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(CustomersdataGridView);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, -523);
            panel1.Name = "panel1";
            panel1.Size = new Size(139, 618);
            panel1.TabIndex = 2;
            // 
            // CustomersdataGridView
            // 
            CustomersdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersdataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            CustomersdataGridView.Dock = DockStyle.Fill;
            CustomersdataGridView.Location = new Point(55, 0);
            CustomersdataGridView.Name = "CustomersdataGridView";
            CustomersdataGridView.RowHeadersWidth = 51;
            CustomersdataGridView.Size = new Size(28, 518);
            CustomersdataGridView.TabIndex = 2;
            CustomersdataGridView.CellContentClick += CustomersdataGridView_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Customer Description";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 300;
            // 
            // Column2
            // 
            Column2.HeaderText = "Email Address";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.HeaderText = "partner Contact ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 300;
            // 
            // Column4
            // 
            Column4.HeaderText = "Customer Code";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Number of invoices";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Date Created";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Edit Customer";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Delete Customer";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "View Invoices";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(55, 518);
            panel4.Name = "panel4";
            panel4.Size = new Size(28, 100);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(83, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(56, 618);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 618);
            panel2.TabIndex = 0;
            // 
            // addInvoiceBtn
            // 
            addInvoiceBtn.Location = new Point(323, 38);
            addInvoiceBtn.Name = "addInvoiceBtn";
            addInvoiceBtn.Size = new Size(262, 35);
            addInvoiceBtn.TabIndex = 3;
            addInvoiceBtn.Text = "Add Invoice";
            addInvoiceBtn.UseVisualStyleBackColor = true;
            addInvoiceBtn.Click += addInvoiceBtn_Click;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Location = new Point(55, 38);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(262, 35);
            addCustomerBtn.TabIndex = 4;
            addCustomerBtn.Text = "Add Customer";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // addCustomerPanel
            // 
            addCustomerPanel.Controls.Add(panel5);
            addCustomerPanel.Location = new Point(154, 450);
            addCustomerPanel.Name = "addCustomerPanel";
            addCustomerPanel.Size = new Size(132, 89);
            addCustomerPanel.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnCancelAddClient);
            panel5.Controls.Add(btnSaveNewCustomer);
            panel5.Controls.Add(txtCustomer_add_code);
            panel5.Controls.Add(txtCustomer_add_address);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtCustomer_add_contact);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtCustomer_add_description);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(288, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(560, 574);
            panel5.TabIndex = 0;
            // 
            // btnCancelAddClient
            // 
            btnCancelAddClient.BackColor = Color.Firebrick;
            btnCancelAddClient.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnCancelAddClient.Location = new Point(59, 397);
            btnCancelAddClient.Name = "btnCancelAddClient";
            btnCancelAddClient.Size = new Size(405, 41);
            btnCancelAddClient.TabIndex = 2;
            btnCancelAddClient.Text = "Cancel";
            btnCancelAddClient.UseVisualStyleBackColor = false;
            btnCancelAddClient.Click += btnCancelAddClient_Click;
            // 
            // btnSaveNewCustomer
            // 
            btnSaveNewCustomer.BackColor = Color.SeaGreen;
            btnSaveNewCustomer.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnSaveNewCustomer.ForeColor = Color.White;
            btnSaveNewCustomer.Location = new Point(59, 350);
            btnSaveNewCustomer.Name = "btnSaveNewCustomer";
            btnSaveNewCustomer.Size = new Size(405, 41);
            btnSaveNewCustomer.TabIndex = 2;
            btnSaveNewCustomer.Text = "Save Customer";
            btnSaveNewCustomer.UseVisualStyleBackColor = false;
            btnSaveNewCustomer.Click += btnSaveNewCustomer_Click;
            // 
            // txtCustomer_add_code
            // 
            txtCustomer_add_code.Font = new Font("Century Gothic", 12F);
            txtCustomer_add_code.Location = new Point(59, 296);
            txtCustomer_add_code.Name = "txtCustomer_add_code";
            txtCustomer_add_code.Size = new Size(405, 27);
            txtCustomer_add_code.TabIndex = 1;
            // 
            // txtCustomer_add_address
            // 
            txtCustomer_add_address.Font = new Font("Century Gothic", 12F);
            txtCustomer_add_address.Location = new Point(59, 159);
            txtCustomer_add_address.Name = "txtCustomer_add_address";
            txtCustomer_add_address.Size = new Size(405, 27);
            txtCustomer_add_address.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(59, 266);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 0;
            label4.Text = "Customer Code";
            // 
            // txtCustomer_add_contact
            // 
            txtCustomer_add_contact.Font = new Font("Century Gothic", 12F);
            txtCustomer_add_contact.Location = new Point(59, 225);
            txtCustomer_add_contact.Name = "txtCustomer_add_contact";
            txtCustomer_add_contact.Size = new Size(405, 27);
            txtCustomer_add_contact.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(59, 129);
            label2.Name = "label2";
            label2.Size = new Size(154, 23);
            label2.TabIndex = 0;
            label2.Text = "Customer Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(59, 195);
            label3.Name = "label3";
            label3.Size = new Size(160, 23);
            label3.TabIndex = 0;
            label3.Text = "Customer Contact";
            // 
            // txtCustomer_add_description
            // 
            txtCustomer_add_description.Font = new Font("Century Gothic", 12F);
            txtCustomer_add_description.Location = new Point(59, 88);
            txtCustomer_add_description.Name = "txtCustomer_add_description";
            txtCustomer_add_description.Size = new Size(405, 27);
            txtCustomer_add_description.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(59, 58);
            label1.Name = "label1";
            label1.Size = new Size(179, 23);
            label1.TabIndex = 0;
            label1.Text = "Customer Description";
            // 
            // EditCustomerPanel
            // 
            EditCustomerPanel.Controls.Add(panel7);
            EditCustomerPanel.Location = new Point(481, 363);
            EditCustomerPanel.Name = "EditCustomerPanel";
            EditCustomerPanel.Size = new Size(162, 129);
            EditCustomerPanel.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label9);
            panel7.Controls.Add(btnCancelEditCustomer);
            panel7.Controls.Add(btnSaveEditCustomer);
            panel7.Controls.Add(txtEditCustomer_code);
            panel7.Controls.Add(txtEditCustomer_address);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(txtEditCustomer_contact);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(txtEditCustomer_discription);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(288, 75);
            panel7.Name = "panel7";
            panel7.Size = new Size(560, 574);
            panel7.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(185, 0);
            label9.Name = "label9";
            label9.Size = new Size(204, 23);
            label9.TabIndex = 3;
            label9.Text = "Edit Customer Details";
            // 
            // btnCancelEditCustomer
            // 
            btnCancelEditCustomer.BackColor = Color.Firebrick;
            btnCancelEditCustomer.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnCancelEditCustomer.Location = new Point(59, 397);
            btnCancelEditCustomer.Name = "btnCancelEditCustomer";
            btnCancelEditCustomer.Size = new Size(405, 41);
            btnCancelEditCustomer.TabIndex = 2;
            btnCancelEditCustomer.Text = "Cancel";
            btnCancelEditCustomer.UseVisualStyleBackColor = false;
            btnCancelEditCustomer.Click += btnCancelEditCustomer_Click;
            // 
            // btnSaveEditCustomer
            // 
            btnSaveEditCustomer.BackColor = Color.SeaGreen;
            btnSaveEditCustomer.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnSaveEditCustomer.ForeColor = Color.White;
            btnSaveEditCustomer.Location = new Point(59, 350);
            btnSaveEditCustomer.Name = "btnSaveEditCustomer";
            btnSaveEditCustomer.Size = new Size(405, 41);
            btnSaveEditCustomer.TabIndex = 2;
            btnSaveEditCustomer.Text = "Save Customer";
            btnSaveEditCustomer.UseVisualStyleBackColor = false;
            btnSaveEditCustomer.Click += btnSaveEditCustomer_Click;
            // 
            // txtEditCustomer_code
            // 
            txtEditCustomer_code.Font = new Font("Century Gothic", 12F);
            txtEditCustomer_code.Location = new Point(59, 296);
            txtEditCustomer_code.Name = "txtEditCustomer_code";
            txtEditCustomer_code.Size = new Size(405, 27);
            txtEditCustomer_code.TabIndex = 1;
            // 
            // txtEditCustomer_address
            // 
            txtEditCustomer_address.Font = new Font("Century Gothic", 12F);
            txtEditCustomer_address.Location = new Point(59, 159);
            txtEditCustomer_address.Name = "txtEditCustomer_address";
            txtEditCustomer_address.Size = new Size(405, 27);
            txtEditCustomer_address.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(59, 266);
            label5.Name = "label5";
            label5.Size = new Size(136, 23);
            label5.TabIndex = 0;
            label5.Text = "Customer Code";
            // 
            // txtEditCustomer_contact
            // 
            txtEditCustomer_contact.Font = new Font("Century Gothic", 12F);
            txtEditCustomer_contact.Location = new Point(59, 225);
            txtEditCustomer_contact.Name = "txtEditCustomer_contact";
            txtEditCustomer_contact.Size = new Size(405, 27);
            txtEditCustomer_contact.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Century Gothic", 12F);
            label6.Location = new Point(59, 129);
            label6.Name = "label6";
            label6.Size = new Size(199, 23);
            label6.TabIndex = 0;
            label6.Text = "Customer Email Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Century Gothic", 12F);
            label7.Location = new Point(59, 195);
            label7.Name = "label7";
            label7.Size = new Size(160, 23);
            label7.TabIndex = 0;
            label7.Text = "Customer Contact";
            // 
            // txtEditCustomer_discription
            // 
            txtEditCustomer_discription.Font = new Font("Century Gothic", 12F);
            txtEditCustomer_discription.Location = new Point(59, 88);
            txtEditCustomer_discription.Name = "txtEditCustomer_discription";
            txtEditCustomer_discription.Size = new Size(405, 27);
            txtEditCustomer_discription.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Century Gothic", 12F);
            label8.Location = new Point(59, 58);
            label8.Name = "label8";
            label8.Size = new Size(179, 23);
            label8.TabIndex = 0;
            label8.Text = "Customer Description";
            // 
            // add_invoice_panel
            // 
            add_invoice_panel.Controls.Add(btnCancel_add_invoice);
            add_invoice_panel.Controls.Add(btnSaveInvoice);
            add_invoice_panel.Controls.Add(label15);
            add_invoice_panel.Controls.Add(label20);
            add_invoice_panel.Controls.Add(panel8);
            add_invoice_panel.Controls.Add(panel6);
            add_invoice_panel.Controls.Add(label21);
            add_invoice_panel.Controls.Add(label14);
            add_invoice_panel.Location = new Point(748, 104);
            add_invoice_panel.Name = "add_invoice_panel";
            add_invoice_panel.Size = new Size(217, 176);
            add_invoice_panel.TabIndex = 3;
            // 
            // btnCancel_add_invoice
            // 
            btnCancel_add_invoice.BackColor = Color.Firebrick;
            btnCancel_add_invoice.Font = new Font("Century", 12F);
            btnCancel_add_invoice.ForeColor = Color.White;
            btnCancel_add_invoice.Location = new Point(542, 447);
            btnCancel_add_invoice.Name = "btnCancel_add_invoice";
            btnCancel_add_invoice.Size = new Size(378, 47);
            btnCancel_add_invoice.TabIndex = 2;
            btnCancel_add_invoice.Text = "Cancel";
            btnCancel_add_invoice.UseVisualStyleBackColor = false;
            btnCancel_add_invoice.Click += btnCancel_add_invoice_Click;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.BackColor = Color.SeaGreen;
            btnSaveInvoice.Font = new Font("Century", 12F);
            btnSaveInvoice.ForeColor = Color.White;
            btnSaveInvoice.Location = new Point(66, 447);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(378, 47);
            btnSaveInvoice.TabIndex = 2;
            btnSaveInvoice.Text = "Save Information";
            btnSaveInvoice.UseVisualStyleBackColor = false;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(192, 0, 0);
            label15.Location = new Point(65, 413);
            label15.Name = "label15";
            label15.Size = new Size(64, 20);
            label15.TabIndex = 1;
            label15.Text = "label20";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BorderStyle = BorderStyle.FixedSingle;
            label20.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(192, 0, 0);
            label20.Location = new Point(65, 212);
            label20.Name = "label20";
            label20.Size = new Size(64, 20);
            label20.TabIndex = 1;
            label20.Text = "label20";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(txt_add_invoice_quantity);
            panel8.Controls.Add(txt_add_invoice_line_total);
            panel8.Controls.Add(txt_add_invoice_unit_price);
            panel8.Controls.Add(txt_add_invoice_item_description);
            panel8.Controls.Add(label16);
            panel8.Controls.Add(label17);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(label19);
            panel8.Location = new Point(64, 248);
            panel8.Name = "panel8";
            panel8.Size = new Size(856, 162);
            panel8.TabIndex = 0;
            // 
            // txt_add_invoice_quantity
            // 
            txt_add_invoice_quantity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_add_invoice_quantity.Location = new Point(479, 35);
            txt_add_invoice_quantity.Name = "txt_add_invoice_quantity";
            txt_add_invoice_quantity.Size = new Size(357, 27);
            txt_add_invoice_quantity.TabIndex = 2;
            // 
            // txt_add_invoice_line_total
            // 
            txt_add_invoice_line_total.Enabled = false;
            txt_add_invoice_line_total.Font = new Font("Century Gothic", 12F);
            txt_add_invoice_line_total.Location = new Point(479, 104);
            txt_add_invoice_line_total.Name = "txt_add_invoice_line_total";
            txt_add_invoice_line_total.Size = new Size(357, 27);
            txt_add_invoice_line_total.TabIndex = 1;
            // 
            // txt_add_invoice_unit_price
            // 
            txt_add_invoice_unit_price.Font = new Font("Century Gothic", 12F);
            txt_add_invoice_unit_price.Location = new Point(22, 100);
            txt_add_invoice_unit_price.Name = "txt_add_invoice_unit_price";
            txt_add_invoice_unit_price.Size = new Size(357, 27);
            txt_add_invoice_unit_price.TabIndex = 1;
            // 
            // txt_add_invoice_item_description
            // 
            txt_add_invoice_item_description.Font = new Font("Century Gothic", 12F);
            txt_add_invoice_item_description.Location = new Point(22, 31);
            txt_add_invoice_item_description.Name = "txt_add_invoice_item_description";
            txt_add_invoice_item_description.Size = new Size(357, 27);
            txt_add_invoice_item_description.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Font = new Font("Century Gothic", 12F);
            label16.Location = new Point(479, 74);
            label16.Name = "label16";
            label16.Size = new Size(84, 23);
            label16.TabIndex = 0;
            label16.Text = "Line total";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Font = new Font("Century Gothic", 12F);
            label17.Location = new Point(479, 5);
            label17.Name = "label17";
            label17.Size = new Size(82, 23);
            label17.TabIndex = 0;
            label17.Text = "Quantity";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Font = new Font("Century Gothic", 12F);
            label18.Location = new Point(22, 74);
            label18.Name = "label18";
            label18.Size = new Size(84, 23);
            label18.TabIndex = 0;
            label18.Text = "Unit Price";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.Font = new Font("Century Gothic", 12F);
            label19.Location = new Point(22, 5);
            label19.Name = "label19";
            label19.Size = new Size(140, 23);
            label19.TabIndex = 0;
            label19.Text = "Item Description";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txt_add_invoice_CustomerCombo);
            panel6.Controls.Add(txtInvoiceNumber);
            panel6.Controls.Add(txt_add_invoice_address);
            panel6.Controls.Add(txt_add_invoice_telephone);
            panel6.Controls.Add(txt_add_invoice_names);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(64, 42);
            panel6.Name = "panel6";
            panel6.Size = new Size(856, 162);
            panel6.TabIndex = 0;
            // 
            // txt_add_invoice_CustomerCombo
            // 
            txt_add_invoice_CustomerCombo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_add_invoice_CustomerCombo.FormattingEnabled = true;
            txt_add_invoice_CustomerCombo.Location = new Point(479, 105);
            txt_add_invoice_CustomerCombo.Name = "txt_add_invoice_CustomerCombo";
            txt_add_invoice_CustomerCombo.Size = new Size(357, 29);
            txt_add_invoice_CustomerCombo.TabIndex = 2;
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.AutoSize = true;
            txtInvoiceNumber.BorderStyle = BorderStyle.FixedSingle;
            txtInvoiceNumber.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInvoiceNumber.Location = new Point(22, 134);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.Size = new Size(148, 21);
            txtInvoiceNumber.TabIndex = 0;
            txtInvoiceNumber.Text = "Invoice Number : ";
            // 
            // txt_add_invoice_address
            // 
            txt_add_invoice_address.Font = new Font("Century Gothic", 12F);
            txt_add_invoice_address.Location = new Point(479, 31);
            txt_add_invoice_address.Name = "txt_add_invoice_address";
            txt_add_invoice_address.Size = new Size(357, 27);
            txt_add_invoice_address.TabIndex = 1;
            // 
            // txt_add_invoice_telephone
            // 
            txt_add_invoice_telephone.Font = new Font("Century Gothic", 12F);
            txt_add_invoice_telephone.Location = new Point(22, 100);
            txt_add_invoice_telephone.Name = "txt_add_invoice_telephone";
            txt_add_invoice_telephone.Size = new Size(357, 27);
            txt_add_invoice_telephone.TabIndex = 1;
            // 
            // txt_add_invoice_names
            // 
            txt_add_invoice_names.Font = new Font("Century Gothic", 12F);
            txt_add_invoice_names.Location = new Point(22, 31);
            txt_add_invoice_names.Name = "txt_add_invoice_names";
            txt_add_invoice_names.Size = new Size(357, 27);
            txt_add_invoice_names.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Century Gothic", 12F);
            label13.Location = new Point(479, 74);
            label13.Name = "label13";
            label13.Size = new Size(151, 23);
            label13.TabIndex = 0;
            label13.Text = "Choose Customer";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Century Gothic", 12F);
            label12.Location = new Point(479, 5);
            label12.Name = "label12";
            label12.Size = new Size(158, 23);
            label12.TabIndex = 0;
            label12.Text = "Customer  Address";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Century Gothic", 12F);
            label11.Location = new Point(22, 74);
            label11.Name = "label11";
            label11.Size = new Size(174, 23);
            label11.TabIndex = 0;
            label11.Text = "Customer Telephone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Century Gothic", 12F);
            label10.Location = new Point(22, 5);
            label10.Name = "label10";
            label10.Size = new Size(140, 23);
            label10.TabIndex = 0;
            label10.Text = "Customer Name";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BorderStyle = BorderStyle.FixedSingle;
            label21.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label21.Location = new Point(454, 224);
            label21.Name = "label21";
            label21.Size = new Size(122, 21);
            label21.TabIndex = 0;
            label21.Text = "Invoice Details";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label14.Location = new Point(454, 18);
            label14.Name = "label14";
            label14.Size = new Size(68, 21);
            label14.TabIndex = 0;
            label14.Text = "Invoice";
            // 
            // view_invoices_panel
            // 
            view_invoices_panel.Controls.Add(InvoicesdataGridView);
            view_invoices_panel.Controls.Add(panel12);
            view_invoices_panel.Controls.Add(panel11);
            view_invoices_panel.Controls.Add(panel10);
            view_invoices_panel.Controls.Add(panel9);
            view_invoices_panel.Location = new Point(222, 93);
            view_invoices_panel.Name = "view_invoices_panel";
            view_invoices_panel.Size = new Size(91, 50);
            view_invoices_panel.TabIndex = 4;
            // 
            // InvoicesdataGridView
            // 
            InvoicesdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoicesdataGridView.Columns.AddRange(new DataGridViewColumn[] { Column10, Column11, Column12, Column13, Column14, Column15, Column16, Column17, Column18, Column19, Column20, Column21 });
            InvoicesdataGridView.Dock = DockStyle.Fill;
            InvoicesdataGridView.Location = new Point(110, 149);
            InvoicesdataGridView.Name = "InvoicesdataGridView";
            InvoicesdataGridView.Size = new Size(0, 0);
            InvoicesdataGridView.TabIndex = 1;
            // 
            // Column10
            // 
            Column10.HeaderText = "Customer Name";
            Column10.Name = "Column10";
            Column10.Width = 200;
            // 
            // Column11
            // 
            Column11.HeaderText = "Customer Telephone";
            Column11.Name = "Column11";
            Column11.Width = 200;
            // 
            // Column12
            // 
            Column12.HeaderText = "Customer Address";
            Column12.Name = "Column12";
            Column12.Width = 300;
            // 
            // Column13
            // 
            Column13.HeaderText = "Item description";
            Column13.Name = "Column13";
            Column13.Width = 300;
            // 
            // Column14
            // 
            Column14.HeaderText = "Unit Price";
            Column14.Name = "Column14";
            Column14.Width = 50;
            // 
            // Column15
            // 
            Column15.HeaderText = "Quantity";
            Column15.Name = "Column15";
            Column15.Width = 50;
            // 
            // Column16
            // 
            Column16.HeaderText = "Line Total";
            Column16.Name = "Column16";
            // 
            // Column17
            // 
            Column17.HeaderText = "Invoice Date";
            Column17.Name = "Column17";
            // 
            // Column18
            // 
            Column18.HeaderText = "Invoice Number";
            Column18.Name = "Column18";
            // 
            // Column19
            // 
            Column19.HeaderText = "View Details";
            Column19.Name = "Column19";
            // 
            // Column20
            // 
            Column20.HeaderText = "Edit Invoice";
            Column20.Name = "Column20";
            // 
            // Column21
            // 
            Column21.HeaderText = "Delete Invoice";
            Column21.Name = "Column21";
            // 
            // panel12
            // 
            panel12.Dock = DockStyle.Right;
            panel12.Location = new Point(-41, 149);
            panel12.Name = "panel12";
            panel12.Size = new Size(132, 0);
            panel12.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(0, 149);
            panel11.Name = "panel11";
            panel11.Size = new Size(110, 0);
            panel11.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(btn_go_back);
            panel10.Controls.Add(btn_add_invocie);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(91, 149);
            panel10.TabIndex = 0;
            // 
            // btn_go_back
            // 
            btn_go_back.BackColor = Color.Firebrick;
            btn_go_back.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn_go_back.ForeColor = Color.White;
            btn_go_back.Location = new Point(537, 52);
            btn_go_back.Name = "btn_go_back";
            btn_go_back.Size = new Size(278, 46);
            btn_go_back.TabIndex = 0;
            btn_go_back.Text = "Go back";
            btn_go_back.UseVisualStyleBackColor = false;
            btn_go_back.Click += btn_go_back_Click;
            // 
            // btn_add_invocie
            // 
            btn_add_invocie.BackColor = Color.SeaGreen;
            btn_add_invocie.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn_add_invocie.ForeColor = Color.White;
            btn_add_invocie.Location = new Point(233, 52);
            btn_add_invocie.Name = "btn_add_invocie";
            btn_add_invocie.Size = new Size(278, 46);
            btn_add_invocie.TabIndex = 0;
            btn_add_invocie.Text = "Add Invoice";
            btn_add_invocie.UseVisualStyleBackColor = false;
            btn_add_invocie.Click += btn_add_invocie_Click;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, -87);
            panel9.Name = "panel9";
            panel9.Size = new Size(91, 137);
            panel9.TabIndex = 0;
            // 
            // edit_invoice_panel
            // 
            edit_invoice_panel.Controls.Add(button1);
            edit_invoice_panel.Controls.Add(button2);
            edit_invoice_panel.Controls.Add(label22);
            edit_invoice_panel.Controls.Add(label23);
            edit_invoice_panel.Controls.Add(panel14);
            edit_invoice_panel.Controls.Add(panel15);
            edit_invoice_panel.Controls.Add(label33);
            edit_invoice_panel.Controls.Add(label34);
            edit_invoice_panel.Dock = DockStyle.Fill;
            edit_invoice_panel.Location = new Point(0, 0);
            edit_invoice_panel.Name = "edit_invoice_panel";
            edit_invoice_panel.Size = new Size(1046, 705);
            edit_invoice_panel.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Century", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(542, 447);
            button1.Name = "button1";
            button1.Size = new Size(378, 47);
            button1.TabIndex = 2;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.Font = new Font("Century", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(66, 447);
            button2.Name = "button2";
            button2.Size = new Size(378, 47);
            button2.TabIndex = 2;
            button2.Text = "Save Information";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BorderStyle = BorderStyle.FixedSingle;
            label22.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.FromArgb(192, 0, 0);
            label22.Location = new Point(65, 413);
            label22.Name = "label22";
            label22.Size = new Size(64, 20);
            label22.TabIndex = 1;
            label22.Text = "label20";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BorderStyle = BorderStyle.FixedSingle;
            label23.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(192, 0, 0);
            label23.Location = new Point(65, 212);
            label23.Name = "label23";
            label23.Size = new Size(64, 20);
            label23.TabIndex = 1;
            label23.Text = "label23";
            // 
            // panel14
            // 
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(numericUpDown1);
            panel14.Controls.Add(textBox1);
            panel14.Controls.Add(textBox2);
            panel14.Controls.Add(textBox3);
            panel14.Controls.Add(label24);
            panel14.Controls.Add(label25);
            panel14.Controls.Add(label26);
            panel14.Controls.Add(label27);
            panel14.Location = new Point(64, 248);
            panel14.Name = "panel14";
            panel14.Size = new Size(856, 162);
            panel14.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(479, 35);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(357, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Century Gothic", 12F);
            textBox1.Location = new Point(479, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 12F);
            textBox2.Location = new Point(22, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 12F);
            textBox3.Location = new Point(22, 31);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(357, 27);
            textBox3.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BorderStyle = BorderStyle.FixedSingle;
            label24.Font = new Font("Century Gothic", 12F);
            label24.Location = new Point(479, 74);
            label24.Name = "label24";
            label24.Size = new Size(84, 23);
            label24.TabIndex = 0;
            label24.Text = "Line total";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BorderStyle = BorderStyle.FixedSingle;
            label25.Font = new Font("Century Gothic", 12F);
            label25.Location = new Point(479, 5);
            label25.Name = "label25";
            label25.Size = new Size(82, 23);
            label25.TabIndex = 0;
            label25.Text = "Quantity";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BorderStyle = BorderStyle.FixedSingle;
            label26.Font = new Font("Century Gothic", 12F);
            label26.Location = new Point(22, 74);
            label26.Name = "label26";
            label26.Size = new Size(84, 23);
            label26.TabIndex = 0;
            label26.Text = "Unit Price";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BorderStyle = BorderStyle.FixedSingle;
            label27.Font = new Font("Century Gothic", 12F);
            label27.Location = new Point(22, 5);
            label27.Name = "label27";
            label27.Size = new Size(140, 23);
            label27.TabIndex = 0;
            label27.Text = "Item Description";
            // 
            // panel15
            // 
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Controls.Add(comboBox1);
            panel15.Controls.Add(label28);
            panel15.Controls.Add(textBox4);
            panel15.Controls.Add(textBox5);
            panel15.Controls.Add(textBox6);
            panel15.Controls.Add(label29);
            panel15.Controls.Add(label30);
            panel15.Controls.Add(label31);
            panel15.Controls.Add(label32);
            panel15.Location = new Point(64, 42);
            panel15.Name = "panel15";
            panel15.Size = new Size(856, 162);
            panel15.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(479, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(357, 29);
            comboBox1.TabIndex = 2;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BorderStyle = BorderStyle.FixedSingle;
            label28.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(22, 134);
            label28.Name = "label28";
            label28.Size = new Size(148, 21);
            label28.TabIndex = 0;
            label28.Text = "Invoice Number : ";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 12F);
            textBox4.Location = new Point(479, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(357, 27);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Century Gothic", 12F);
            textBox5.Location = new Point(22, 100);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(357, 27);
            textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Century Gothic", 12F);
            textBox6.Location = new Point(22, 31);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(357, 27);
            textBox6.TabIndex = 1;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BorderStyle = BorderStyle.FixedSingle;
            label29.Font = new Font("Century Gothic", 12F);
            label29.Location = new Point(479, 74);
            label29.Name = "label29";
            label29.Size = new Size(151, 23);
            label29.TabIndex = 0;
            label29.Text = "Choose Customer";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BorderStyle = BorderStyle.FixedSingle;
            label30.Font = new Font("Century Gothic", 12F);
            label30.Location = new Point(479, 5);
            label30.Name = "label30";
            label30.Size = new Size(158, 23);
            label30.TabIndex = 0;
            label30.Text = "Customer  Address";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BorderStyle = BorderStyle.FixedSingle;
            label31.Font = new Font("Century Gothic", 12F);
            label31.Location = new Point(22, 74);
            label31.Name = "label31";
            label31.Size = new Size(174, 23);
            label31.TabIndex = 0;
            label31.Text = "Customer Telephone";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BorderStyle = BorderStyle.FixedSingle;
            label32.Font = new Font("Century Gothic", 12F);
            label32.Location = new Point(22, 5);
            label32.Name = "label32";
            label32.Size = new Size(140, 23);
            label32.TabIndex = 0;
            label32.Text = "Customer Name";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BorderStyle = BorderStyle.FixedSingle;
            label33.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label33.Location = new Point(454, 224);
            label33.Name = "label33";
            label33.Size = new Size(122, 21);
            label33.TabIndex = 0;
            label33.Text = "Invoice Details";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BorderStyle = BorderStyle.FixedSingle;
            label34.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label34.Location = new Point(406, 9);
            label34.Name = "label34";
            label34.Size = new Size(170, 21);
            label34.TabIndex = 0;
            label34.Text = "EDIT INVOICE DETAILS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 705);
            Controls.Add(edit_invoice_panel);
            Controls.Add(view_invoices_panel);
            Controls.Add(add_invoice_panel);
            Controls.Add(EditCustomerPanel);
            Controls.Add(addCustomerPanel);
            Controls.Add(HomePanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thyme Assessemnt";
            Load += Form1_Load;
            HomePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomersdataGridView).EndInit();
            addCustomerPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            EditCustomerPanel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            add_invoice_panel.ResumeLayout(false);
            add_invoice_panel.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txt_add_invoice_quantity).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            view_invoices_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InvoicesdataGridView).EndInit();
            panel10.ResumeLayout(false);
            edit_invoice_panel.ResumeLayout(false);
            edit_invoice_panel.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HomePanel;
        private Panel panel1;
        private DataGridView CustomersdataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn Column7;
        private DataGridViewButtonColumn Column8;
        private DataGridViewButtonColumn Column9;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Button addInvoiceBtn;
        private Button addCustomerBtn;
        private Panel addCustomerPanel;
        private Panel panel5;
        private Button btnCancelAddClient;
        private Button btnSaveNewCustomer;
        private TextBox txtCustomer_add_code;
        private TextBox txtCustomer_add_address;
        private Label label4;
        private TextBox txtCustomer_add_contact;
        private Label label2;
        private Label label3;
        private TextBox txtCustomer_add_description;
        private Label label1;
        private Panel EditCustomerPanel;
        private Panel panel7;
        private Label label9;
        private Button btnCancelEditCustomer;
        private Button btnSaveEditCustomer;
        private TextBox txtEditCustomer_code;
        private TextBox txtEditCustomer_address;
        private Label label5;
        private TextBox txtEditCustomer_contact;
        private Label label6;
        private Label label7;
        private TextBox txtEditCustomer_discription;
        private Label label8;
        private Panel add_invoice_panel;
        private Panel panel6;
        private Label txtInvoiceNumber;
        private TextBox txt_add_invoice_address;
        private TextBox txt_add_invoice_telephone;
        private TextBox txt_add_invoice_names;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label14;
        private ComboBox txt_add_invoice_CustomerCombo;
        private Label label20;
        private Panel panel8;
        private NumericUpDown txt_add_invoice_quantity;
        private TextBox txt_add_invoice_line_total;
        private TextBox txt_add_invoice_unit_price;
        private TextBox txt_add_invoice_item_description;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label21;
        private Button btnCancel_add_invoice;
        private Button btnSaveInvoice;
        private Label label15;
        private Panel view_invoices_panel;
        private DataGridView InvoicesdataGridView;
        private Panel panel12;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Button btn_go_back;
        private Button btn_add_invocie;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewButtonColumn Column19;
        private DataGridViewButtonColumn Column20;
        private DataGridViewButtonColumn Column21;
        private Panel edit_invoice_panel;
        private Button button1;
        private Button button2;
        private Label label22;
        private Label label23;
        private Panel panel14;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Panel panel15;
        private ComboBox comboBox1;
        private Label label28;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
    }
}
