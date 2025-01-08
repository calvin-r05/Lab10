//https://github.com/calvin-r05/Lab10.git
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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Account> accounts = new List<Account>();
        List<Account> filteredAccounts = new List<Account>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Account selectedAccount = lbxAccounts.SelectedItem as Account;

            if (selectedAccount != null)
            {
                tbxFirstName.Text = selectedAccount.FirstName;
                tbxLastName.Text = selectedAccount.LastName;
                tbxBalance1.Text = selectedAccount.Balance.ToString("c");
                tbxAccType.Text = selectedAccount.GetType().Name;
                tbxInterestDate.Text = selectedAccount.InterestDate.ToString("d");


                // tbxInterestDate = selectedAccount.InterestDate;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentAccount ca1 = new CurrentAccount("John", "Doe", 1000, DateTime.Now.AddYears(-2), "1");
            CurrentAccount ca2 = new CurrentAccount("Jane", "Doe", 2000, DateTime.Now.AddYears(-4), "2");
            SavingsAccount sa1 = new SavingsAccount("John", "Smith", 10000, DateTime.Now.AddYears(-2), "3");
            SavingsAccount sa2 = new SavingsAccount("Jane", "Smith", 20000, DateTime.Now.AddYears(-4), "4");

            accounts.Add(ca1);
            accounts.Add(ca2);
            accounts.Add(sa1);
            accounts.Add(sa2);

            lbxAccounts.ItemsSource = accounts;
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            lbxAccounts.ItemsSource = null;
            filteredAccounts.Clear();
            bool savings = false, current = false;

            if (cbCurrent.IsChecked.Value)
            {
                current = true;
            }

            if (cbSavings.IsChecked.Value)
            {
                savings = true;
            }
            if (current && savings)
            {
                lbxAccounts.ItemsSource = accounts;
            }
            else if (current)
            {
                foreach (Account account in accounts)
                {
                    if (account is CurrentAccount)
                    {
                        filteredAccounts.Add(account);
                    }
                }
                lbxAccounts.ItemsSource = filteredAccounts;
            }

            else if (savings)
            {
                foreach (Account account in accounts)
                {
                    if ( account is SavingsAccount)
                    {
                        filteredAccounts.Add(account);
                    }
                }
                lbxAccounts.ItemsSource = filteredAccounts;
            }
            
        }
    }
}
