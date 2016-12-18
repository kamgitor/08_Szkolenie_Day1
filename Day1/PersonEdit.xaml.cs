using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Day1
{
    /// <summary>
    /// Interaction logic for PersonEdit.xaml
    /// </summary>
    public partial class PersonEdit : Window
    {
        public bool wynik;

        public PersonEdit()
        {
            InitializeComponent();
        }

        private void Key_OK_Click(object sender, RoutedEventArgs e)
        {
            wynik = true;
            this.DialogResult = true;
            this.Close();
        }

        private void Key_Esc_Click(object sender, RoutedEventArgs e)
        {
            wynik = false;
            this.DialogResult = false;
            this.Close();
        }

    }
}
