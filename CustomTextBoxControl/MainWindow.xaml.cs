using CustomTextBoxControl.View.UserControls;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace CustomTextBoxControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClearableTextBox[] elements;
        public MainWindow()
        {
            InitializeComponent();
            elements = grid.Children.OfType<ClearableTextBox>().ToArray();
        }

        private void PressKey(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return) 
            {
                int tabIndex = (sender as ClearableTextBox).TabIndex;
                if (tabIndex > 5) return;
                foreach(var element in elements) 
                    if (element.TabIndex == tabIndex + 1)
                    {
                        element.txtInput.Focus();
                        break;
                    }
            }
        }
    }
}
