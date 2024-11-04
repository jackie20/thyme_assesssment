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
            HomePanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersdataGridView).BeginInit();
            addCustomerPanel.SuspendLayout();
            panel5.SuspendLayout();
            EditCustomerPanel.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(panel1);
            HomePanel.Controls.Add(addInvoiceBtn);
            HomePanel.Controls.Add(addCustomerBtn);
            HomePanel.Location = new Point(168, 189);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(88, 191);
            HomePanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(CustomersdataGridView);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, -427);
            panel1.Name = "panel1";
            panel1.Size = new Size(88, 618);
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
            CustomersdataGridView.Size = new Size(0, 518);
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
            panel4.Size = new Size(0, 100);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(32, 0);
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
            add_invoice_panel.Dock = DockStyle.Fill;
            add_invoice_panel.Location = new Point(0, 0);
            add_invoice_panel.Name = "add_invoice_panel";
            add_invoice_panel.Size = new Size(1046, 640);
            add_invoice_panel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 640);
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
    }
}
