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

//using TransactionRegister.ViewModels;

namespace TransactionRegister
{
    /// <summary>
    /// Interaction logic for Toolbar.xaml
    /// </summary>
    public partial class Toolbar : UserControl
    {
        public Toolbar()
        {
            InitializeComponent();

            TollbarViewModel tool_bar_view_model = new TollbarViewModel();
            tool_bar_view_model.Background_Color = Brushes.Blue;
            tool_bar_view_model.Font_Color = Brushes.White;

            // Add Item Modifer Buttons
            tool_bar_view_model.ItemModifers.Add(tool_bar_view_model.BuildImageButton("../images/DeleteWhite.png", DeleteBtn_Click));
            tool_bar_view_model.ItemModifers.Add(tool_bar_view_model.BuildImageButton("../images/EditWhite.png", EditBtn_Click));
            
            // Display the navigation button in our parrent container.
            NavigationSp.Children.Add(tool_bar_view_model.BuildImageButton("../images/BackArrowWhite.png", NavigationBtn_Click));

            // Display Item Modifer Buttons
            foreach (Button temp_button in tool_bar_view_model.ItemModifers)
            {
                ItemModifersSp.Children.Add(temp_button);
            }


            this.DataContext = tool_bar_view_model;
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
