﻿
using QLCHBD_OOAD.view.returning;
using QLCHBD_OOAD.viewmodel.rental;
using QLCHBD_OOAD.viewmodel.returning;
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

namespace QLCHBD_OOAD.view.rental
{
    /// <summary>
    /// Interaction logic for RentalMainPage.xaml
    /// </summary>
    public partial class RentalMainPage : Page
    {
        public RentalMainPage()
        {
            InitializeComponent();
            DataContext = RentalPageViewModel.getIntance();
            retalHolder.Content = new RentalAllOrder();
            RentalPageViewModel.turnAllRentalToDetailRental += RentalNavigation_ChangePage;
            RentalPageViewModel.turnAllRentalToReturn += RentalPageViewModel_turnAllRentalToReturn;
            DetailRentalPageViewModel.turnBackPageHandler += turnBackToAllRentalPage;
            ReturningViewModel.turnBackPageHandler += turnBackToAllRentalPage;
            RentalPageViewModel.turnToAddPage += turnToAddPage;
            RentalAddPageViewModel.turnBackToRentalAllOrders += turnBackToAllRentalPage;            
        }

        private void RentalPageViewModel_turnAllRentalToReturn(long rentalId, long guestId)
        {
            retalHolder.Content = new ReturnPage(rentalId, guestId);
        }

        private void turnToAddPage(string page)
        {
            
            retalHolder.Content = new RentalAddPage();
        }

        private void RentalNavigation_ChangePage(long rentalId, long guestId)
        {          
            retalHolder.Content = new RentalDetailOrder(rentalId, guestId);
            
        }
        private void turnBackToAllRentalPage()
        {
            retalHolder.ClearValue(UidProperty);
            retalHolder.Content = new RentalAllOrder();
        }
    }
}
