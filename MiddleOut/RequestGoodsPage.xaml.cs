﻿using FirstFloor.ModernUI.Windows.Navigation;
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

namespace MiddleOut
{
    /// <summary>
    /// Author: Karanbir Toor 
    /// Interaction logic for RequestGoodsPage.xaml 
    /// </summary>
    public partial class RequestGoodsPage : UserControl
    {
        private DonationTypes _donationType;
        private string _description;
        public RequestGoodsPage()
        {
            InitializeComponent();
            OtherTextBox.Text = "Donation";
            _description = string.Empty;
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Gets the checkbox that is checked, and assigns the DonationType to _donationType.
        /// </summary>
        private void checkWhichButtonChecked()
        {
            DonationTypes result = DonationTypes.Other;
            if ((bool) ToysRadioButton.IsChecked)
            {
                result = DonationTypes.Toys;
            }
            else if ((bool) ClothesRadioButton.IsChecked)
            {
                result = DonationTypes.Clothes;
            }
            else if ((bool) TechRadioButton.IsChecked)
            {
                result = DonationTypes.Tech;
            }
            else if ((bool) FirstAidGoodsButton.IsChecked)
            {
                result = DonationTypes.FirstAid;
            }
            else if ((bool) FoodRadioButton.IsChecked)
            {
                result = DonationTypes.Food;
            }
            else if ((bool) HygieneProductsRadioButton.IsChecked)
            {
                result = DonationTypes.Hygene;
            }
            else if ((bool) OtherRadioButton.IsChecked)
            {
                result = DonationTypes.Other;
            }
            _donationType =  result;
        }

        private void OtherTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (OtherTextBox.Text == "")
            {
                OtherTextBox.Text = "Donation";
                //OtherTextBox.ForeColor = Color.LightGray;
            }
        }

        private void OtherTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (OtherTextBox.Text == "Donation")
            {
                OtherTextBox.Text = "";
                //OtherTextBox.ForeColor = Color.White;
            }
        }

        private void nextPage_Click(object sender, RoutedEventArgs e)
        {
            checkWhichButtonChecked();

            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            User user = mainWindow.getUser();

            Service service = new Service(user.getName(), user.getEmail());

            service.setServiceType(mainWindow.getServiceType());
            service.setDonationRequest(_donationType);
            if (_donationType != DonationTypes.Other)
            {
                service.setDescription(_donationType.ToString());
            }
            else
            {
                service.setDescription(_description);

            }

            user.addService(service);

            ServiceDatabase serviceDatabase = mainWindow.GetServiceDatabase();
            serviceDatabase.createService(mainWindow.getServiceType(), _donationType, user, service);

            IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
            NavigationCommands.GoToPage.Execute("/ThankYou.xaml", target);
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Sets the description of the service using the otherTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OtherTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            _description = OtherTextBox.Text;
        }
    }
}
