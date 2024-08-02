using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WaterBillApp
{
    public partial class Form1 : Form
    {
        private List<Customer> customers = new List<Customer>(); // Khai báo một danh sách các khách hàng (Customer)
        private int editingCustomerIndex = -1; // theo dõi khách hàng đang được chỉnh sửa
        private Button btnEditCustomer;

        public Form1()
        {
            InitializeComponent();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (!loginForm.IsAuthenticated)
            {
                MessageBox.Show("You are not authenticated. The application will now close.", "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnCalculateBill_Click(object sender, EventArgs e)  //xử lý khi người dùng nhấn nút "Calculate Bill"
        {
            // Lấy dữ liệu từ các textbox và combobox
            string name = txtName.Text;
            if (!int.TryParse(txtLastMonth.Text, out int lastMonth) ||
                !int.TryParse(txtThisMonth.Text, out int thisMonth))
            {
                MessageBox.Show("Invalid input for month indices.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lastMonth >= thisMonth)// Check chỉ số nhập vào tháng trc phải nhỏ hơn tháng sau
            {
                MessageBox.Show("Last month's index must be smaller than this month's index.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string customerType = cmbCustomerType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(customerType)) // Yêu cầu người dùng chọn tyoe khách hàng
            {
                MessageBox.Show("Please select a customer type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numberPeople = 0;
            if (customerType == "Household")
            {
                if (!int.TryParse(txtNumberPeople.Text, out numberPeople) || numberPeople <= 0)
                {
                    MessageBox.Show("Invalid input for number of people.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int consumption = thisMonth - lastMonth; //tính lượng tiêu thụ
            double totalBill = CalculateWaterBill(customerType, consumption, numberPeople);

            Customer customer = new Customer //Tạo đối tượng Customer và thêm vào danh sách
            {
                Name = name,
                LastMonth = lastMonth,
                ThisMonth = thisMonth,
                CustomerType = customerType,
                NumberPeople = numberPeople,
                TotalBill = totalBill
            };

            if (editingCustomerIndex >= 0) // Nếu đang chỉnh sửa khách hàng
            {
                customers[editingCustomerIndex] = customer; // Cập nhật thông tin khách hàng
                editingCustomerIndex = -1; // Reset lại chỉ số chỉnh sửa
            }
            else
            {
                customers.Add(customer); // Thêm khách hàng mới vào danh sách
            }

            UpdateCustomerList();
            ClearFormFields();

            txtResult.Text = $"\r\n--------------- Water Bill ---------------\r\n" +
                             $"| Customer Name      : {customer.Name}          \r\n" +
                             $"|--------------------------------------------\r\n" +
                             $"| Last Month Index   : {customer.LastMonth}          \r\n" +
                             $"| This Month Index   : {customer.ThisMonth}          \r\n" +
                             $"| Water Consumption  : {consumption} m³          \r\n" +
                             $"| Customer Type      : {customer.CustomerType}       \r\n" +
                             $"|--------------------------------------------\r\n" +
                             $"| Amount (excl. VAT) : {customer.TotalBill:N0} VND   \r\n" +
                             $"| VAT (10%)          : {customer.TotalBill * 0.1:N0} VND   \r\n" +
                             $"|--------------------------------------------\r\n" +
                             $"| Total Amount       : {customer.TotalBill * 1.1:N0} VND   \r\n" +
                             $"--------------------------------------------";
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e) //xử lý khi người dùng nhấn nút "Search Customer"
        {
            string searchName = txtSearchName.Text.ToLower();
            lstCustomers.Items.Clear();
            txtResult.Clear();

            // Tìm tất cả khách hàng phù hợp với tiêu chí tìm kiếm
            List<Customer> foundCustomers = new List<Customer>();
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Name.ToLower().Contains(searchName))
                {
                    foundCustomers.Add(customers[i]);
                }
            }

            if (foundCustomers.Count > 0)
            {
                for (int i = 0; i < foundCustomers.Count; i++)
                {
                    Customer customer = foundCustomers[i];
                    lstCustomers.Items.Add($"Name: {customer.Name}, Consumption: {customer.ThisMonth - customer.LastMonth} m³, Type: {customer.CustomerType}, Bill: {customer.TotalBill * 1.1:N0} VND");

                    // Hiển thị hóa đơn chi tiết cho từng khách hàng tìm thấy
                    txtResult.Text += $"\r\n--------------- Water Bill ---------------\r\n" +
                                      $"| Customer Name      : {customer.Name}          \r\n" +
                                      $"|--------------------------------------------\r\n" +
                                      $"| Last Month Index   : {customer.LastMonth}          \r\n" +
                                      $"| This Month Index   : {customer.ThisMonth}          \r\n" +
                                      $"| Water Consumption  : {customer.ThisMonth - customer.LastMonth} m³          \r\n" +
                                      $"| Customer Type      : {customer.CustomerType}       \r\n" +
                                      $"|--------------------------------------------\r\n" +
                                      $"| Amount (excl. VAT) : {customer.TotalBill:N0} VND   \r\n" +
                                      $"| VAT (10%)          : {customer.TotalBill * 0.1:N0} VND   \r\n" +
                                      $"|--------------------------------------------\r\n" +
                                      $"| Total Amount       : {customer.TotalBill * 1.1:N0} VND   \r\n" +
                                      $"--------------------------------------------\r\n";
                }
            }
            else
            {
                lstCustomers.Items.Add("No customers found.");
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)// sửa thông tin của một khách hàng đã được chọn trong danh sách
        {
            if (lstCustomers.SelectedIndex >= 0)
            {
                editingCustomerIndex = lstCustomers.SelectedIndex; //Lưu thông tin khách hàng được chọn vào biến editingCustomerIndex
                Customer customer = customers[editingCustomerIndex]; //Lấy đối tượng Customer tương ứng với chỉ số đã chọn từ danh sách customers.

                txtName.Text = customer.Name;//cập nhật thông tin
                txtLastMonth.Text = customer.LastMonth.ToString();
                txtThisMonth.Text = customer.ThisMonth.ToString();
                cmbCustomerType.SelectedItem = customer.CustomerType;
                txtNumberPeople.Text = customer.NumberPeople.ToString();
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCustomerList() //Cập nhật danh sách khách hàng
        {
            lstCustomers.Items.Clear(); //Xóa tất cả các mục hiện có trong danh sách khách hàng
            foreach (Customer customer in customers) //Duyệt qua từng đối tượng Customer trong danh sách customers.
            {
                lstCustomers.Items.Add($"Name: {customer.Name}, Consumption: {customer.ThisMonth - customer.LastMonth} m³, Type: {customer.CustomerType}, Bill: {customer.TotalBill * 1.1:N0} VND"); //thêm thông tin khách hàng vào danh sách
            }
        }

        private void ClearFormFields() //xóa trên form nhập
        {
            txtName.Clear();
            txtLastMonth.Clear();
            txtThisMonth.Clear();
            cmbCustomerType.SelectedIndex = -1;
            txtNumberPeople.Clear();
        }

        private double CalculateWaterBill(string customerType, int consumption, int numberOfPeople) //Phương thức tính toán hóa đơn tiền nước dựa trên loại khách hàng, lượng nước tiêu thụ và số người (nếu là hộ gia đình)
        {
            double bill = 0.0;
            double rate = 0.0;
            switch (customerType)
            {
                case "Household":
                    double consumptionPerPerson = (double)consumption / numberOfPeople;
                    if (consumptionPerPerson <= 10)
                    {
                        rate = 5973;
                    }
                    else if (consumptionPerPerson <= 20)
                    {
                        rate = 7052;
                    }
                    else if (consumptionPerPerson <= 30)
                    {
                        rate = 8699;
                    }
                    else
                    {
                        rate = 15929;
                    }
                    bill = (rate * consumption) * 1.1;
                    break;
                case "Administrative":
                    rate = 9955;
                    bill = (rate * consumption) * 1.1;
                    break;
                case "Production":
                    rate = 11615;
                    bill = (rate * consumption) * 1.1;
                    break;
                case "Business":
                    rate = 22068;
                    bill = (rate * consumption) * 1.1;
                    break;
                default:
                    MessageBox.Show("Invalid customer type.");
                    break;
            }
            return bill;
        }

        private class Customer //Lớp để lưu trữ thông tin của khách hàng, bao gồm tên, chỉ số tháng trước, chỉ số tháng này, loại khách hàng, số người (nếu là hộ gia đình) và tổng hóa đơn.
        {
            public string Name { get; set; }
            public int LastMonth { get; set; }
            public int ThisMonth { get; set; }
            public string CustomerType { get; set; }
            public int NumberPeople { get; set; }
            public double TotalBill { get; set; }
        }


        private void btClear_Click(object sender, EventArgs e)
        {
            lstCustomers.Items.Clear();
            txtResult.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
