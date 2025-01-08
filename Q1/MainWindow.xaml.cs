﻿//https://github.com/calvin-r05/Lab10.git
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
    }
}
