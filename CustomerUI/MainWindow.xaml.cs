using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CustomerLibrary;

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
            CustomerBase customerBase = null;
            if (CboCustomerType.SelectedIndex == 0)
            {
                customerBase = new Lead();
            }
            else
            {
                customerBase= new Customer();
            }
            customerBase.CustomerName = TxtCustomerName.Text;
            customerBase.Address = TextBoxAddress.Text;
            customerBase.PhoneNumber = TextBoxPhoneNumber.Text;
            customerBase.BillDate = Convert.ToDateTime(TxtBillDate.Text);
            customerBase.BillAmount = Convert.ToDecimal(TextBoxBillAmount.Text);
        }
    }
}
