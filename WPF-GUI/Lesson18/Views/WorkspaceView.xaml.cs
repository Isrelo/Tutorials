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
using TransactionRegister.Models;
using TransactionRegister.ViewModels;

namespace TransactionRegister
{
    /// <summary>
    /// Interaction logic for WorkspaceView.xaml
    /// </summary>
    public partial class WorkspaceView : UserControl, IView
    {
        public WorkspaceView()
        {
            InitializeComponent();
        }

        public void Draw(BaseModel model_to_draw_p)
        {
            WorkspaceViewModel workspace_view_model = model_to_draw_p as WorkspaceViewModel;

            if(workspace_view_model != null)
            {
                WorkspaceGr.Children.Clear();

                for (int count = 0; count < workspace_view_model.Controls_m.Count; count++)
                {
                    UIElement control = workspace_view_model.Controls_m[count];
                    WorkspaceGr.Children.Add(control);
                }
            }
        }
    }
}
