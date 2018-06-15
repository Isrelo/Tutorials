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

using TransactionRegister.Controllers;
using TransactionRegister.ViewModels;

namespace TransactionRegister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ToolbarController toolbar_controller_m;

        public MainWindow()
        {
            InitializeComponent();

            // Setup Toolbar Controller
            toolbar_controller_m = new ToolbarController();
            toolbar_controller_m.AddView(MainToolbar);

            // Test ToolbarViewModel
            ToolbarViewModel toolbar_view_model = new ToolbarViewModel();
            toolbar_view_model.Title = "Testing Title";
            toolbar_view_model.Background_Color = Brushes.Blue;
            toolbar_view_model.Font_Color = Brushes.White;
            toolbar_view_model.Naigation_btn = toolbar_view_model.BuildImageButton("../images/HamburgerMenuWhite.png", NavigationBtn_Click);

            toolbar_controller_m.UpdateViews(toolbar_view_model);

            // Add Item Modifer Buttons
            //tool_bar_view_model.ItemModifers.Add(tool_bar_view_model.BuildImageButton("../images/DeleteWhite.png", DeleteBtn_Click));
            //tool_bar_view_model.ItemModifers.Add(tool_bar_view_model.BuildImageButton("../images/EditWhite.png", EditBtn_Click));
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
