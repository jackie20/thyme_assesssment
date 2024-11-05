using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.Unicode;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ThymeFrontEnd.Models;
using Newtonsoft.Json.Linq;
using System.DirectoryServices;
using System.Text.RegularExpressions;
using System.Text.Json;



namespace ThymeFrontEnd
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;
        private string logs_path = Application.StartupPath + "logs.txt";
        private ListBox CustomersIdsLisbox = new ListBox();
        private List<CustomerDisplay> customerDisplaysList = new List<CustomerDisplay>();
        private int editCustomerId = 0;
        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7062/api/")
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            CustomersIdsLisbox = new ListBox();
        }

        private void addlogs(string contentToWrite)
        {
            logs_path = Application.StartupPath + "logs.txt";
            try
            {
                if (!File.Exists(logs_path))
                {
                    // Create the file and write content
                    using (StreamWriter writer = File.CreateText(logs_path))
                    {
                        writer.WriteLine(contentToWrite);
                    }
                }
                else
                {
                    // If the file exists, append new content
                    using (StreamWriter writer = File.AppendText(logs_path))
                    {
                        writer.WriteLine($"\n {DateTime.Now.ToLongDateString()} :  " + contentToWrite);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private async void loadCustomers()
        {
            addlogs("loadCustomers");
            CustomersIdsLisbox.Items.Clear();
            txt_add_invoice_CustomerCombo.Items.Clear();
            customerDisplaysList.Clear();
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("Customer");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    // Parse the JSON response
                    var jsonObject = JObject.Parse(jsonResponse);

                    // Check if the response was successful
                    if (jsonObject["success"]?.Value<bool>() == true)
                    {
                        CustomersdataGridView.Rows.Clear();

                        // Extract the "data" array and deserialize it to List<Customer>
                        var customerData = jsonObject["data"].ToObject<List<CustomerDisplay>>();

                        // Add each customer to the DataGridView
                        foreach (var customer in customerData)
                        {
                            CustomersdataGridView.Rows.Add(
                                customer.CustomerDescription,
                                customer.EmailAddress,
                                customer.PartnerContact,
                                customer.PartnerCustomerCode,
                                customer.CountInvoices,
                                " ",
                                "Edit Customer",
                                "Delete Customer",
                                "View Invoices"
                            );
                            CustomersIdsLisbox.Items.Add(customer.CustomerID.ToString());
                            txt_add_invoice_CustomerCombo.Items.Add(customer.CustomerDescription);
                            customerDisplaysList.Add(customer);
                        }
                    }
                    else
                    {
                        var message = jsonObject["message"]?.ToString() ?? "Unknown error";
                        MessageBox.Show("Error: " + message);
                        addlogs("Error: " + message);
                    }
                }
                else
                {
                    MessageBox.Show("Error retrieving customers: " + response.ReasonPhrase);
                    addlogs("Error retrieving customers: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                addlogs("An error occurred: " + ex.Message);
            }

        }

        // Helper function to check if a string is valid JSON
        private bool IsJson(string input)
        {
            input = input.Trim();
            return (input.StartsWith("{") && input.EndsWith("}")) || // For JSON objects
                   (input.StartsWith("[") && input.EndsWith("]"));   // For JSON arrays
        }


        private void ArrangePanels()
        {
            HomePanel.Hide();
            HomePanel.Dock = DockStyle.Fill;

            addCustomerPanel.Hide();
            addCustomerPanel.Dock = DockStyle.Fill;

            EditCustomerPanel.Hide();
            EditCustomerPanel.Dock = DockStyle.Fill;


            add_invoice_panel.Hide();
            add_invoice_panel.Dock = DockStyle.Fill;

            view_invoices_panel.Hide();
            view_invoices_panel.Dock = DockStyle.Fill;

            edit_invoice_panel.Hide();
            edit_invoice_panel.Dock = DockStyle.Fill;

        }

        private void loadCustomer(int customerId)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrangePanels();
            HomePanel.Show();
            loadCustomers();


            addlogs("loadCustomer");

        }

        private void btnCancelAddClient_Click(object sender, EventArgs e)
        {
            ArrangePanels();
            HomePanel.Show();
        }

        private async void btnSaveNewCustomer_Click(object sender, EventArgs e)
        {
            string email_address = txtCustomer_add_address.Text.ToString().ToLower();
            string description = txtCustomer_add_description.Text.ToString().ToLower();
            string contact = txtCustomer_add_contact.Text.ToString().ToLower();
            string code = txtCustomer_add_code.Text.ToString().ToLower();

            Customer customer = new Customer
            {
                CustomerDescription = description,
                CustomerID = 0,
                PartnerContact = contact,
                PartnerCustomerCode = code,
                EmailAddress = email_address,
            };

            if (isValidForm(customer))
            {


                string json = JsonConvert.SerializeObject(customer);


                // Create the HTTP content with JSON data
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    // Send the POST request
                    HttpResponseMessage response = await _httpClient.PostAsync("Customer/addcustomer", content);

                    // Check the response status
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Customer added successfully!");
                        addlogs("Customer added successfully!");

                        txtCustomer_add_address.Clear();
                        txtCustomer_add_code.Clear();
                        txtCustomer_add_contact.Clear();
                        txtCustomer_add_description.Clear();
                        loadCustomers();

                    }
                    else
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Failed to add customer. Status code: {response.StatusCode}\n{responseBody}");
                        addlogs($"Failed to add customer. Status code: {response.StatusCode}\n{responseBody}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    addlogs($"An error occurred: {ex.Message}");
                }
            }

        }

        private static bool isValidForm(Customer customer)
        {
            bool isValid = true;

            if (customer.PartnerContact.Length < 10)
            {
                isValid = false;
                MessageBox.Show("Provide valid contact with at least 10 digits");
            }

            if (!IsValidEmail(customer.EmailAddress))
            {
                isValid = false;
                MessageBox.Show("Provide valid Email ");
            }

            if (customer.CustomerDescription.Length <= 3)
            {
                isValid = false;
                MessageBox.Show("Provide valid Description ");
            }
            if (customer.PartnerCustomerCode.Length < 5)
            {
                MessageBox.Show("Provide valid Code with at least 5 digits ");
                isValid = false;
            }



            return isValid;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            // Basic regular expression pattern for validating an email address
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, pattern);
        }

        private void btnCancelEditCustomer_Click(object sender, EventArgs e)
        {
            ArrangePanels();
            HomePanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void btnSaveEditCustomer_Click(object sender, EventArgs e)
        {
            string email_address = txtEditCustomer_address.Text.ToString().ToLower();
            string description = txtEditCustomer_discription.Text.ToString().ToLower();
            string contact = txtEditCustomer_contact.Text.ToString().ToLower();
            string code = txtEditCustomer_code.Text.ToString().ToLower();


       


            Customer customer = new Customer
            {
                CustomerDescription = description,
                CustomerID = editCustomerId,
                PartnerContact = contact,
                PartnerCustomerCode = code,
                EmailAddress = email_address,
            };

            if (isValidForm(customer))
            {

                string json = JsonConvert.SerializeObject(customer);


                // Create the HTTP content with JSON data
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    // Send the POST request
                    HttpResponseMessage response = await _httpClient.PutAsync($"Customer/updatecustomer/{editCustomerId}", content);

                    // Check the response status
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Customer updated successfully!");
                        addlogs("Customer updated successfully!");

                        txtCustomer_add_address.Clear();
                        txtCustomer_add_code.Clear();
                        txtCustomer_add_contact.Clear();
                        txtCustomer_add_description.Clear();
                        loadCustomers();
                        editCustomerId = 0;
                    }
                    else
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Failed to update customer. Status code: {response.StatusCode}\n{responseBody}");
                        addlogs($"Failed to update customer. Status code: {response.StatusCode}\n{responseBody}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    addlogs($"An error occurred: {ex.Message}");
                }

            }
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            ArrangePanels();
            addCustomerPanel.Show();
        }

        private async void deleteCustomer(int rowindex)
        {




            string json = JsonConvert.SerializeObject(editCustomerId);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");


            try
            {
                // Send the POST request
                HttpResponseMessage response = await _httpClient.DeleteAsync($"Customer/deletecustomer/{editCustomerId}");

                // Check the response status
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Customer Deleted successfully!");
                    addlogs("Customer Deleted successfully!");

                    loadCustomers();

                }
                else
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to delete customer. Status code: {response.StatusCode}\n{responseBody}");
                    addlogs($"Failed to delete customer. Status code: {response.StatusCode}\n{responseBody}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                addlogs($"An error occurred: {ex.Message}");
            }













        }

        private void populateEditprofile(CustomerDisplay customerDisplay)
        {
            if (customerDisplay != null)
            {

                // txtEditCustomer
                txtEditCustomer_address.Text = customerDisplay.EmailAddress;
                txtEditCustomer_code.Text = customerDisplay.PartnerCustomerCode;
                txtEditCustomer_contact.Text = customerDisplay.PartnerContact;
                txtEditCustomer_discription.Text = customerDisplay.CustomerDescription;

            }
        }
        private void CustomersdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 3)
            {
                var cellValue = CustomersdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Check if the cell value is not null
                if (cellValue != null)
                {
                    // Assuming CustomerID is stored in the first column (index 0)

                    CustomerDisplay customerDisplay = customerDisplaysList.ElementAt(e.RowIndex);

                    var customerID = CustomersIdsLisbox.Items[e.RowIndex].ToString();
                    string descriptionOCusmtomer = CustomersdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    editCustomerId = System.Convert.ToInt16(customerID);
                    customerDisplay.CustomerID = editCustomerId;

                   


                    switch (e.ColumnIndex)
                    {
                        case 6:
                            ArrangePanels();
                            EditCustomerPanel.Show();

                            populateEditprofile(customerDisplay);

                            break;

                        case 7:

                            var selection = MessageBox.Show($"Are you sure you want to delete this customer : {descriptionOCusmtomer} ", "Confirm deletion", MessageBoxButtons.YesNoCancel);

                            if (selection == DialogResult.Yes)
                            {
                                deleteCustomer(e.RowIndex);



                            }
                            break;

                        case 8:

                            ArrangePanels();
                            view_invoices_panel.Show();
                            break;

                        default:
                            break;


                    }
                    //6- EditCustomerPanel 
                    //    7-DeleteChildAccessRule 
                    //    8- View invoices 
                }
            }
        }

        private void btnCancel_add_invoice_Click(object sender, EventArgs e)
        {
            ArrangePanels();
            HomePanel.Show();
        }


        public bool isValidInvoice(InvoiceDTO invoiceDTO)
        {
            bool isValid = true;
            add_invoice_error_label.Text = "";
            if (invoiceDTO == null)
            {
            
                add_invoice_error_label.Text = "Invoice data cannot be null.";
                isValid = false;
            }

            if (invoiceDTO.InvoiceHeader == null)
            {
                add_invoice_error_label.Text = "Invoice header is required."; 
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(invoiceDTO.InvoiceHeader.CustomerName))
            {
             
                add_invoice_error_label.Text = "Customer name is required in the invoice header.";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(invoiceDTO.InvoiceHeader.CustomerAddress))
            {
                
                add_invoice_error_label.Text = "Customer address is required in the invoice header";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(invoiceDTO.InvoiceHeader.CustomerTelephone) || invoiceDTO.InvoiceHeader.CustomerTelephone.Length > 15)
            {
              
                add_invoice_error_label.Text = "Customer telephone is required and must not exceed 15 characters";
                isValid = false;
            }
            // Validate InvoiceDetail
            if (invoiceDTO.invoiceDetail == null)
            {
                
                add_invoice_error_label.Text = "Invoice detail is required";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(invoiceDTO.invoiceDetail.ItemDescription))
            {
             
                add_invoice_error_label.Text = "Item description in the invoice detail is required";
                isValid = false;
            }
            if (invoiceDTO.invoiceDetail.Quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                add_invoice_error_label.Text = "";
                isValid = false;
            }
            if (invoiceDTO.invoiceDetail.UnitPrice <= 0)
            {
                MessageBox.Show("Unit price must be greater than 0.");
                add_invoice_error_label.Text = "";
                isValid = false;
            }

            if (invoiceDTO.invoice == null)
            {
             
                add_invoice_error_label.Text = "Invoice information is required.";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(invoiceDTO.invoice.CustomerName))
            {
                
                add_invoice_error_label.Text = "Customer name in the invoice is required.";
                isValid = false;
            }
           
            if (string.IsNullOrWhiteSpace(invoiceDTO.invoice.CustomerAddress))
            {

                add_invoice_error_label.Text = "Customer address in the invoice is required.";
                isValid = false;
            }

            return isValid;
        }
        private async void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            add_invoice_error_label.Text = "";
            if (txt_add_invoice_CustomerCombo.SelectedIndex != -1) { 

            string address = txt_add_invoice_address.Text.ToString().ToLower();
            int customerId = int.TryParse(CustomersIdsLisbox.Items[txt_add_invoice_CustomerCombo.SelectedIndex].ToString(), out int tempResultId) ? tempResultId : 0;  
            string description = txt_add_invoice_item_description.Text.ToString().ToLower();
            string names = txt_add_invoice_names.Text.ToString().ToLower();
            int quantity = int.TryParse(txt_add_invoice_quantity.Text.ToString().ToLower(), out int tempResultint) ? tempResultint : 0;  
            string telephone = txt_add_invoice_telephone.Text.ToString().ToLower();
             decimal unitprice = decimal.TryParse(txt_add_invoice_unit_price.Text.ToString().ToLower(), out decimal tempResultprice) ? tempResultprice : 0m;
            decimal total = quantity * unitprice;
            txt_add_invoice_line_total.Text = total.ToString();

                    // decimal result = decimal.TryParse(input, out decimal tempResult) ? tempResult : 0m;
                    //int result = int.TryParse(input, out int tempResult) ? tempResult : 0;

                    Invoice invoice = new Invoice
            {
                InvoiceDate = DateTime.UtcNow,
                InvoiceNumber = 0,
                CustomerAddress = address,
                CustomerName = names,
                CustomerTelephoneNumber = telephone,
            };
            InvoiceDetail detail = new InvoiceDetail
            { 
                ItemDescription = description,
                LineTotal = total, 
                Quantity = quantity, 
                UnitPrice = unitprice,
                DetailID = 0 ,
               
            };
            InvoiceHeader invoiceHeader = new InvoiceHeader
            {
                InvoiceDate = invoice.InvoiceDate,
                CustomerAddress = address,
                CustomerID = customerId , 
                InvoiceID = 0,
                InvoiceNumber = "0",
                CustomerName= names,
                CustomerTelephone = telephone
            };

            InvoiceDTO invoiceDTO = new InvoiceDTO
            {
                invoice = invoice,
                InvoiceHeader = invoiceHeader,
                invoiceDetail = detail
            };


                if (isValidInvoice(invoiceDTO))
                {


                    string json = JsonConvert.SerializeObject(invoiceDTO);


                    // Create the HTTP content with JSON data
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    try
                    {
                        // Send the POST request
                        HttpResponseMessage response = await _httpClient.PostAsync("Invoices/addcustomerinvoice", content);

                        // Check the response status
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Customer Invoice added successfully!");
                            addlogs("Customer Invoice added successfully!");
                             
                            loadCustomers();

                        }
                        else
                        {
                            string responseBody = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Failed to add customer. Status code: {response.StatusCode}\n{responseBody}");
                            addlogs($"Failed to add customer. Status code: {response.StatusCode}\n{responseBody}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                        addlogs($"An error occurred: {ex.Message}");
                    }

                }else
                {
                    add_invoice_error_label.Text = "Customer is required ";
                    MessageBox.Show($"Selecte Customer ");
                }
            }
        }

        private void addInvoiceBtn_Click(object sender, EventArgs e)
        {
            ArrangePanels();
            add_invoice_panel.Show();
        }

        private void btn_add_invocie_Click(object sender, EventArgs e)
        {
            ArrangePanels();
            add_invoice_panel.Show();
        }

        private void btn_go_back_Click(object sender, EventArgs e)
        {
            ArrangePanels();
            HomePanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrangePanels();
            HomePanel.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Save Edit incoive information
        }
    }
}
