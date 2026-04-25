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

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void DlgProc(object sender, EventArgs e)
        {
             switch (sender.GetType().Name)
             {
                case nameof(TextBox):if ((e as KeyEventArgs).Key == Key.Enter) DlgProc(btnADD, null);break;
                case nameof(System.Windows.Controls.ListBox):if ((e as KeyEventArgs).Key == Key.Delete) DlgProc(btnDEL, null);break;
                case nameof(Button):
                    switch ((sender as Button).Content)
                    {
                        case "ADD":
                            if (!listBox.Items.Contains(tbInput.Text))
                            {
                                if (tbInput.Text.Trim() == "") break;
                                listBox.Items.Add(tbInput.Text);
                                tbInput.Text = null;
                                tbInput.Focus();
                            }
                            break;
                        case "CLR": listBox.Items.Clear(); break;
                        case "DEL":
                            if (listBox.SelectedIndex >= 0)
                                listBox.Items.RemoveAt(listBox.SelectedIndex);
                            break;
                    }
                    break;
             }
            
        }
    }
}
