﻿using QLCHBD_OOAD.appUtil;
using QLCHBD_OOAD.viewmodel.images;
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
    /// Interaction logic for DeleteImageForm.xaml
    /// </summary>
    public partial class DeleteImageForm : Window
    {

        public static event ToggleFormDialogNotifyHandler ToggleForm;
        public DeleteImageForm(long id)
        {
            InitializeComponent();
            ToggleForm();
            DataContext = new DeleteImageViewModel(id);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ToggleForm();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            ToggleForm();
        }
    }
}
