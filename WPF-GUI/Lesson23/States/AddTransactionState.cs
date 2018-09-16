using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Media;
using System.ComponentModel;
using TransactionRegister.Views;
using TransactionRegister.Contexts;
using TransactionRegister.ViewModels;
using TransactionRegister.Controllers;

namespace TransactionRegister.States
{
    public class AddTransactionState : IState
    {
        public BindingList<TransactionViewModel> Transactions_m { get; set; }
        public ToolbarController ToolbarController_m { get; set; }
        public WorkspaceController WorkspaceController_m { get; set; }
        public ApplicationContext ApplicationContext_m { get; set; }

        public AddTransactionState(ToolbarController toolbar_controller_p, WorkspaceController workspace_controller_p)
        {
            ToolbarController_m = toolbar_controller_p;
            WorkspaceController_m = workspace_controller_p;
        }

        private void NavigationBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked navigation button inside add state!");
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked save button inside add state!");
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked cancel button inside add state!");
        }

        // State Interface

        public void SwitchToState(ApplicationContext app_context_p)
        {
            // Store the app context for later use.
            ApplicationContext_m = app_context_p;

            // Test ToolbarViewModel
            ToolbarViewModel toolbar_view_model = new ToolbarViewModel();
            toolbar_view_model.Title = "Add Transaction";
            toolbar_view_model.Background_Color = Brushes.Blue;
            toolbar_view_model.Font_Color = Brushes.White;
            toolbar_view_model.Naigation_btn = GUIUtilites.BuildImageButton("../images/BackArrowWhite.png", 
                                                                            NavigationBtn_Click, 
                                                                            56, 56, 
                                                                            24, 24, 
                                                                            Brushes.Transparent, 
                                                                            Brushes.Transparent, 
                                                                            HorizontalAlignment.Center, 
                                                                            VerticalAlignment.Center);
            
            toolbar_view_model.ItemModifers.Add(GUIUtilites.BuildTextButton("SAVE",
                                                                            SaveBtn_Click,
                                                                            100, 56,
                                                                            Brushes.Transparent,
                                                                            Brushes.Transparent,
                                                                            Brushes.White,
                                                                            HorizontalAlignment.Center,
                                                                            VerticalAlignment.Center));
            toolbar_view_model.ItemModifers.Add(GUIUtilites.BuildTextButton("CANCEL",
                                                                            CancelBtn_Click,
                                                                            56, 56,
                                                                            Brushes.Transparent,
                                                                            Brushes.Transparent,
                                                                            Brushes.White,
                                                                            HorizontalAlignment.Center,
                                                                            VerticalAlignment.Center));

            ToolbarController_m.UpdateViews(toolbar_view_model);

            // Test WorkspaceViewModel
            WorkspaceViewModel workspacce_view_modle = new WorkspaceViewModel();

            // Initilize Add and Edit View
            AddAndEditTransactionView add_and_edit_transaction_view = new AddAndEditTransactionView();

            workspacce_view_modle.Controls_m.Add(add_and_edit_transaction_view);

            WorkspaceController_m.UpdateViews(workspacce_view_modle);
        }

        public void AddTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void Cancel(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        // Not Used States

        public void Starting(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void DeleteTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void EditTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void SaveTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void SelectTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void UnselectTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }
    }
}
