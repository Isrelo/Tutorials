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

            // Assign Button Properties
            tool_bar_view_model.Navigation_img = "../images/HamburgerMenuWhite.png";
            tool_bar_view_model.Navigation_reh = NavigationBtn_Click;
            NavigationBtn.Click += tool_bar_view_model.Navigation_reh;

            this.DataContext = tool_bar_view_model;
        }

        private void NavigationBtn_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
