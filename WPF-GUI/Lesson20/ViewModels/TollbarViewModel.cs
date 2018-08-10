using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using TransactionRegister.Models;

namespace TransactionRegister.ViewModels
{
    public class ToolbarViewModel : BaseModel
    {
        public Brush Background_Color { get; set; }
        public Brush Font_Color { get; set; }
        public Button Naigation_btn { get; set; }
        public String Title { get; set; }
        public List<Button> ItemModifers { get; set; }

        public ToolbarViewModel()
        {
            // Initialize Default Colors.
            Background_Color = Brushes.White;
            Font_Color = Brushes.White;

            // Initialize Navigation Button
            Naigation_btn = new Button();
            Naigation_btn.Background = Brushes.Transparent;
            Naigation_btn.BorderBrush = Brushes.Transparent;
            Naigation_btn.Visibility = Visibility.Hidden;

            // Initialize Title
            Title = "";

            // Initialize Item Modifiers List.
            ItemModifers = new List<Button>();
        }
    }
}
