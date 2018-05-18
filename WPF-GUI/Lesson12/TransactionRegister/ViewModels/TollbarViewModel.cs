using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace TransactionRegister
{
    public class TollbarViewModel
    {
        public Brush Background_Color { get; set; }
        public Brush Font_Color { get; set; }
        public String Navigation_img { get; set; }
        public RoutedEventHandler Navigation_reh { get; set; } 
        public Label Title_lbl { get; set; }
        public List<Button> ItemModifers { get; set; }

        public TollbarViewModel()
        {
            Background_Color = Brushes.White;
            Font_Color = Brushes.White;
            Navigation_img = "";
            Title_lbl = new Label();
            ItemModifers = new List<Button>();
        }
    }
}
