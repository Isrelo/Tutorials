﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using TransactionRegister.Contexts;
using TransactionRegister.Controllers;
using TransactionRegister.ViewModels;

namespace TransactionRegister.States
{
    public class StartingState : IState
    {
        public ToolbarController ToolbarController_m { get; set; }
        public WorkspaceController WorkspaceController_m { get; set; }
        public ApplicationContext ApplicationContext_m { get; set; }

        public StartingState(ToolbarController toolbar_controller_p, WorkspaceController workspace_controller_p)
        {
            ToolbarController_m = toolbar_controller_p;
            WorkspaceController_m = workspace_controller_p;
        }

        private void NavigationBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked navigation button!");
        }

        private void AddTransactionBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked add transaction button!");

            ApplicationContext_m.CurrentState_m = new AddTransactionState(ToolbarController_m, WorkspaceController_m);
            ApplicationContext_m.CurrentState_m.SwitchToState(ApplicationContext_m);
        }

        // States Interface

        public void SwitchToState(ApplicationContext app_context_p)
        {
            // Store the app context for later use.
            ApplicationContext_m = app_context_p;

            // Test ToolbarViewModel
            ToolbarViewModel toolbar_view_model = new ToolbarViewModel();
            toolbar_view_model.Title = "Testing Title";
            toolbar_view_model.Background_Color = Brushes.Blue;
            toolbar_view_model.Font_Color = Brushes.White;
            toolbar_view_model.Naigation_btn = GUIUtilites.BuildImageButton("../images/HamburgerMenuWhite.png", NavigationBtn_Click, 56, 56, 24, 24, Brushes.Transparent, Brushes.Transparent, HorizontalAlignment.Center, VerticalAlignment.Center);

            ToolbarController_m.UpdateViews(toolbar_view_model);

            // Test WorkspaceViewModel
            WorkspaceViewModel workspacce_view_modle = new WorkspaceViewModel();

            // Create actual image button.
            Button image_button = GUIUtilites.BuildImageButton("../images/EditWhite.png", AddTransactionBtn_Click, 56, 56, 24, 24, Brushes.SeaGreen, Brushes.Transparent, HorizontalAlignment.Right, VerticalAlignment.Bottom);
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
