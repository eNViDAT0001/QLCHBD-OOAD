﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using QLCHBD_OOAD.appUtil;
using QLCHBD_OOAD.model.delivery;
using QLCHBD_OOAD.viewmodel.delivery;

namespace QLCHBD_OOAD.view.delivery.DeliveryPage
{
    /// <summary>
    /// Interaction logic for DeliveryDetailPage.xaml
    /// </summary>
    public partial class DeliveryDetailPage : Page
    {
        public DeliveryDetailPage(string id)
        {
            InitializeComponent();
            DataContext = new DeliveryDetailPageViewModel(id);
        }

    }
}
