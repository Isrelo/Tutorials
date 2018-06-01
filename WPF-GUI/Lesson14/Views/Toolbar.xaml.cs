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

using TransactionRegister.Views;
using TransactionRegister.ViewModels;
using TransactionRegister.Models;

namespace TransactionRegister
{
    /// <summary>
    /// Interaction logic for Toolbar.xaml
    /// </summary>
    public partial class Toolbar : UserControl, IView
    {
        public Toolbar()
        {
            InitializeComponent();
        }

        public void Draw(BaseModel model_to_draw_p)
        {
            ToolbarViewModel tool_bar_view_model = model_to_draw_p as ToolbarViewModel;
            if (tool_bar_view_model != null)
            {
                // Add the child navigation button.
                NavigationSp.Children.Clear();
                NavigationSp.Children.Add(tool_bar_view_model.Naigation_btn);

                // Display Item Modifer Buttons
                ItemModifersSp.Children.Clear();
                foreach (Button temp_button in tool_bar_view_model.ItemModifers)
                {
                    ItemModifersSp.Children.Add(temp_button);
                }

                this.DataContext = tool_bar_view_model;
            }
        }
    }
}
