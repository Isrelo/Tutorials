using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
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
        public AddAndEditTransactionView AddAndEditTransactionView_m { get; set; }

        public AddTransactionState(ToolbarController toolbar_controller_p, WorkspaceController workspace_controller_p, BindingList<TransactionViewModel> transactions_list_p)
        {
            ToolbarController_m = toolbar_controller_p;
            WorkspaceController_m = workspace_controller_p;
            Transactions_m = transactions_list_p;
        }

        private void NavigationBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked navigation button inside add state!");
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked save button inside add state!");

            // Adding Test Transaction For Now
            TransactionViewModel temp_transaciton = new TransactionViewModel();
            temp_transaciton.Description = AddAndEditTransactionView_m.DescriptionTxtBlk.Text;
            double temp_amount = 0.00f;
            Double.TryParse(AddAndEditTransactionView_m.AmountTxtBox.Text.ToString(), out temp_amount);
            temp_transaciton.Amount = temp_amount;
            ComboBoxItem temp_debit_or_credit = (ComboBoxItem)AddAndEditTransactionView_m.DebitOrCreditCB.SelectedValue;
            if (temp_debit_or_credit.Content.ToString() == "Credit")
            {
                temp_transaciton.IsCredit = true;
                temp_transaciton.Font_Color = Brushes.Green;
            }
            else
            {
                temp_transaciton.IsCredit = false;
                temp_transaciton.Font_Color = Brushes.Red;
            }

            Transactions_m.Add(temp_transaciton);

            ApplicationContext_m.CurrentState_m = new StartingState(ToolbarController_m, WorkspaceController_m, Transactions_m);
            ApplicationContext_m.CurrentState_m.SwitchToState(ApplicationContext_m);
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked cancel button inside add state!");

            ApplicationContext_m.CurrentState_m = new StartingState(ToolbarController_m, WorkspaceController_m, Transactions_m);
            ApplicationContext_m.CurrentState_m.SwitchToState(ApplicationContext_m);
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
                                                                            Visibility.Visible,
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
                                                                            100, 56,
                                                                            Brushes.Transparent,
                                                                            Brushes.Transparent,
                                                                            Brushes.White,
                                                                            HorizontalAlignment.Center,
                                                                            VerticalAlignment.Center));

            ToolbarController_m.UpdateViews(toolbar_view_model);

            // Test WorkspaceViewModel
            WorkspaceViewModel workspacce_view_modle = new WorkspaceViewModel();

            // Initilize Add and Edit View
            AddAndEditTransactionView_m = new AddAndEditTransactionView();

            workspacce_view_modle.Controls_m.Add(AddAndEditTransactionView_m);

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
