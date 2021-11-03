﻿using System;
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
using System.Windows.Shapes;
using QLCHBD_OOAD.viewmodel.delivery;

namespace QLCHBD_OOAD.view.delivery.Add_Order
{
    /// <summary>
    /// Interaction logic for NewDeliveryWindow.xaml
    /// </summary>
    public partial class NewDeliveryWindow : Window
    {
        public NewDeliveryWindow()
        {
            InitializeComponent();
            DataContext = new DeliveryaAddOrderFormViewModel();
            DeliveryaAddOrderFormViewModel.closeForm += closeWindow;

        }

        private void closeWindow()
        {
            this.Close();
        }
    }
}
