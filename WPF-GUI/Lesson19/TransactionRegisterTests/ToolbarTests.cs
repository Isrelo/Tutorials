using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Windows;
using System.Windows.Media;
using TransactionRegister;
using TransactionRegister.ViewModels;
using TransactionRegister.Controllers;

namespace TransactionRegisterTests
{
    [TestClass]
    public class ToolbarTests
    {
        ToolbarController toolbar_controller_m;

        public ToolbarTests()
        {
            TestToolbarView test_toolbar_view = new TestToolbarView();

            // Setup Toolbar Controller
            toolbar_controller_m = new ToolbarController();
            toolbar_controller_m.AddView(test_toolbar_view);
        }

        [TestMethod]
        public void DefaultToolbarTest()
        {


            // Test ToolbarViewModel
            ToolbarViewModel toolbar_view_model = new ToolbarViewModel();
            toolbar_view_model.Title = "Testing Title";
            toolbar_view_model.Background_Color = Brushes.Blue;
            toolbar_view_model.Font_Color = Brushes.White;
            toolbar_view_model.Naigation_btn = GUIUtilites.BuildImageButton("../images/HamburgerMenuWhite.png", NavigationBtn_Click, 56, 56, 24, 24, Brushes.Transparent, Brushes.Transparent, HorizontalAlignment.Center, VerticalAlignment.Center);

            toolbar_controller_m.UpdateViews(toolbar_view_model);
        }

        private void NavigationBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked navigation button!");
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked edit button!");
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked delete button!");
        }
    }
}
