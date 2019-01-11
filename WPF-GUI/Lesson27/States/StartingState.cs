using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Media;
using System.ComponentModel;
using System.Windows.Controls;
using TransactionRegister.Views;
using TransactionRegister.Models;
using TransactionRegister.Contexts;
using TransactionRegister.Controllers;
using TransactionRegister.ViewModels;
using TransactionRegister;

namespace TransactionRegister.States
{
    public class StartingState : IState
    {
        public BindingList<TransactionViewModel> Transactions_m { get; set; }
        public ToolbarController ToolbarController_m { get; set; }
        public WorkspaceController WorkspaceController_m { get; set; }
        public ApplicationContext ApplicationContext_m { get; set; }
        public TransactionsView TransactionsView_m { get; set; }

        public StartingState(ToolbarController toolbar_controller_p, WorkspaceController workspace_controller_p, BindingList<TransactionViewModel> transactions_list_p)
        {
            ToolbarController_m = toolbar_controller_p;
            WorkspaceController_m = workspace_controller_p;
            Transactions_m = transactions_list_p;
        }

        private void SetupToolbar(Visibility item_modifers_visablity_p)
        {
            // Test ToolbarViewModel
            ToolbarViewModel toolbar_view_model = new ToolbarViewModel();
            toolbar_view_model.Title = "Transaction Register";
            toolbar_view_model.Background_Color = Brushes.Blue;
            toolbar_view_model.Font_Color = Brushes.White;
            toolbar_view_model.Naigation_btn = GUIUtilites.BuildImageButton("../images/HamburgerMenuWhite.png",
                                                                            NavigationBtn_Click,
                                                                            56, 56,
                                                                            24, 24,
                                                                            Visibility.Visible,
                                                                            Brushes.Transparent,
                                                                            Brushes.Transparent,
                                                                            HorizontalAlignment.Center,
                                                                            VerticalAlignment.Center);
            // Add Item Modifer Buttons
            toolbar_view_model.ItemModifers.Add(GUIUtilites.BuildImageButton("../images/DeleteWhite.png",
                                                                             DeleteBtn_Click,
                                                                             56, 56,
                                                                             24, 24,
                                                                             item_modifers_visablity_p,
                                                                             Brushes.Transparent,
                                                                             Brushes.Transparent,
                                                                             HorizontalAlignment.Center,
                                                                             VerticalAlignment.Center));
            toolbar_view_model.ItemModifers.Add(GUIUtilites.BuildImageButton("../images/EditWhite.png",
                                                                             EditBtn_Click,
                                                                             56, 56,
                                                                             24, 24,
                                                                             item_modifers_visablity_p,
                                                                             Brushes.Transparent,
                                                                             Brushes.Transparent,
                                                                             HorizontalAlignment.Center,
                                                                             VerticalAlignment.Center));

            ToolbarController_m.UpdateViews(toolbar_view_model);
        }


        private void NavigationBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked navigation button!");
        }

        private void AddTransactionBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked add transaction button!");

            ApplicationContext_m.CurrentState_m = new AddTransactionState(ToolbarController_m, WorkspaceController_m, Transactions_m);
            ApplicationContext_m.CurrentState_m.SwitchToState(ApplicationContext_m);
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked edit button!");

            if (TransactionsView_m.TransactionsLB.SelectedItems.Count > 0)
            {
                TransactionViewModel transaction_view_model = TransactionsView_m.TransactionsLB.SelectedItems[0] as TransactionViewModel;
                System.Diagnostics.Debug.WriteLine(transaction_view_model.Description);
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked delete button!");
        }

        private void TransactionsLB_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked preview mouse down on list!");

            ListBox transaction_list = sender as ListBox;
            transaction_list.UnselectAll();
        }

        private void TransactionsLB_PreviewMouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked preview mouse up on list!");

            ListBox transaction_list = sender as ListBox;
            
            if(transaction_list.SelectedItems.Count > 0)
            {
                // Make the item modifer buttons visible.
                SetupToolbar(Visibility.Visible);
            }
            else
            {
                // Hide the item modifer buttons when nothing is selected.
                SetupToolbar(Visibility.Hidden);
            }
        }

        // States Interface

        public void SwitchToState(ApplicationContext app_context_p)
        {
            // Store the app context for later use.
            ApplicationContext_m = app_context_p;

            // Setup the initial toolbar.
            SetupToolbar(Visibility.Hidden);

            // Test WorkspaceViewModel
            WorkspaceViewModel workspacce_view_modle = new WorkspaceViewModel();

            // Calcualte Balance
            double balance = Utilities.CalcualteBalance(Transactions_m);

            TransactionsView_m = new TransactionsView();
            TransactionsView_m.CurrentBalanceLbl.Content = "$" + balance.ToString();
            // ***** Make the transaction items visible. ******
            TransactionsView_m.TransactionsLB.ItemsSource = Transactions_m;
            TransactionsView_m.TransactionsLB.PreviewMouseDown += TransactionsLB_PreviewMouseDown;
            TransactionsView_m.TransactionsLB.PreviewMouseUp += TransactionsLB_PreviewMouseUp;

            // Add Workspace Gid to Workspace
            workspacce_view_modle.Controls_m.Add(TransactionsView_m);

            // Create actual image button.
            Button image_button = GUIUtilites.BuildImageButton("../images/AddCirclePurple.png", 
                                                               AddTransactionBtn_Click, 
                                                               56, 56, 
                                                               56, 56, 
                                                               Visibility.Visible,
                                                               Brushes.Transparent, 
                                                               Brushes.Transparent, 
                                                               HorizontalAlignment.Right, 
                                                               VerticalAlignment.Bottom);
            workspacce_view_modle.Controls_m.Add(image_button);

            WorkspaceController_m.UpdateViews(workspacce_view_modle);
        }

        public void AddTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void EditTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void SelectTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        // Not Used States

        public void Cancel(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void DeleteTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void SaveTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void Starting(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void UnselectTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }
    }
}
