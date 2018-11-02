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

using System.ComponentModel;
using TransactionRegister.Views;
using TransactionRegister.States;
using TransactionRegister.Contexts;
using TransactionRegister.Controllers;
using TransactionRegister.ViewModels;

namespace TransactionRegister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ToolbarController toolbar_controller_m;
        public WorkspaceController workspace_controller_m;
        public BindingList<TransactionViewModel> transactions_list_m;

        public MainWindow()
        {
            InitializeComponent();

            // Setup Toolbar Controller
            toolbar_controller_m = new ToolbarController();
            toolbar_controller_m.AddView(MainToolbar);

            // Setup Workspace Controller
            workspace_controller_m = new WorkspaceController();
            workspace_controller_m.AddView(MainWorkspace);

            // Setup Our Transaction List
            transactions_list_m = new BindingList<TransactionViewModel>();

            ApplicationContext app_context = new ApplicationContext(new StartingState(toolbar_controller_m, workspace_controller_m, transactions_list_m));
            app_context.CurrentState_m.SwitchToState(app_context);

            // Add Item Modifer Buttons
            //tool_bar_view_model.ItemModifers.Add(tool_bar_view_model.BuildImageButton("../images/DeleteWhite.png", DeleteBtn_Click));
            //tool_bar_view_model.ItemModifers.Add(tool_bar_view_model.BuildImageButton("../images/EditWhite.png", EditBtn_Click));
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
