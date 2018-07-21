using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransactionRegister.Models;
using TransactionRegister.Views;
using TransactionRegister.ViewModels;

namespace TransactionRegisterTests
{
    public class TestToolbarView : IView
    {
        public void Draw(BaseModel model_to_draw_p)
        {
            ToolbarViewModel tool_bar_view_model = model_to_draw_p as ToolbarViewModel;
            if (tool_bar_view_model != null)
            {
                Assert.AreEqual(tool_bar_view_model.Title, "Testing Title");
                Assert.AreEqual(tool_bar_view_model.Background_Color, Brushes.Blue);
                Assert.AreEqual(tool_bar_view_model.Font_Color, Brushes.White);
            }
            else
            {
                Assert.Fail("Failed to reterive ToolbarViewModel.");
            }
        }
    }
}
