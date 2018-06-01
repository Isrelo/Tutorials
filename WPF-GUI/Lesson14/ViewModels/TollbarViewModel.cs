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

        public Button BuildImageButton(String image_file_p, RoutedEventHandler button_click_p)
        {
            // Create a image to dsiplay on the button.
            Image button_image = new Image();
            button_image.Width = 24;
            button_image.Height = 24;
            button_image.Source = new BitmapImage(new Uri(image_file_p, UriKind.Relative));

            // Create actual image button.
            Button image_button = new Button();
            image_button.Width = 56;
            image_button.Height = 56;
            image_button.Background = Brushes.Transparent;
            image_button.BorderBrush = Brushes.Transparent;
            image_button.Click += button_click_p;
            image_button.Content = button_image;

            return image_button;
        }
    }
}
