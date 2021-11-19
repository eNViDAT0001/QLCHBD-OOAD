﻿using QLCHBD_OOAD.viewmodel.delivery.detail_order;
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
using System.Windows.Shapes;

namespace QLCHBD_OOAD.Components
{
    /// <summary>
    /// Interaction logic for AddNewAlbumWindow.xaml
    /// </summary>
    public partial class AddNewAlbumWindow : Window
    {
        public AddNewAlbumWindow()
        {
            InitializeComponent();
            DataContext = new DeliveryAddNewAlbumViewModel();
            DeliveryAddNewAlbumViewModel.closeForm += closeWindow;
        }

        private void closeWindow()
        {
            this.Close();
        }
    }
}
