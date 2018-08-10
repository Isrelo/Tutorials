using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace TransactionRegister
{
    public class GUIUtilites
    {
        public static Button BuildImageButton(String image_file_p, RoutedEventHandler button_click_p, 
                                              int button_width_p, int button_height_p, 
                                              int image_width_p, int image_height_p,
                                              Brush background_color_p, Brush border_color_p,
                                              HorizontalAlignment button_horz_align_p, VerticalAlignment button_vert_algin_p)
        {
            // Create a image to dsiplay on the button.
            Image button_image = new Image();
            button_image.Width = image_width_p;
            button_image.Height = image_height_p;
            button_image.Source = new BitmapImage(new Uri(image_file_p, UriKind.Relative));

            // Create actual image button.
            Button image_button = new Button();
            image_button.Width = button_width_p;
            image_button.Height = button_height_p;
            image_button.Background = background_color_p;
            image_button.BorderBrush = border_color_p;
            image_button.HorizontalAlignment = button_horz_align_p;
            image_button.VerticalAlignment = button_vert_algin_p;
            image_button.Click += button_click_p;
            image_button.Content = button_image;

            return image_button;
        }
    }
}
