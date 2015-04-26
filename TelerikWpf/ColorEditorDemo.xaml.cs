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
using System.Windows.Shapes;
using Telerik.Windows.Controls.ColorEditor;

namespace TelerikWpf
{
    /// <summary>
    /// Interaction logic for ColorEditorDemo.xaml
    /// </summary>
    public partial class ColorEditorDemo : Window
    {
        public ColorEditorDemo()
        {
            InitializeComponent();
        }

        private void RadColorEditor_SelectedColorChanged(object sender, ColorChangeEventArgs e)
        {
            TxtBlock.Foreground = new SolidColorBrush(e.Color);
        }
    }
}
