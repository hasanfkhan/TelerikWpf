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

namespace TelerikWpf
{
    /// <summary>
    /// Interaction logic for ColorPickerDemo.xaml
    /// </summary>
    public partial class ColorPickerDemo : Window
    {
        public ColorPickerDemo()
        {
            InitializeComponent();
        }

        private void Cpicker_SelectedColorChanged(object sender, EventArgs e)
        {
            TxtBlock.Foreground = new SolidColorBrush(Cpicker.SelectedColor);
        }
    }
}
