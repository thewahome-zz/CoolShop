using System;
using System.Windows;
using CustomerLibrary;
using FactoryCustomer;
using ICustomerInterface;

namespace CustomerUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ICustomer _customer = null;
            Factory obj = new Factory();
            _customer = obj.CreateCustomer((CustomerType)CboCustomerType.SelectedIndex);

            _customer.CustomerName = TxtCustomerName.Text;
            _customer.Address = TextBoxAddress.Text;
            _customer.PhoneNumber = TextBoxPhoneNumber.Text;
            _customer.BillDate = Convert.ToDateTime(TxtBillDate.Text);
            _customer.BillAmount = Convert.ToDecimal(TextBoxBillAmount.Text);
        }
    }
}
