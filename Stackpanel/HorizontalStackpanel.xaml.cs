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

namespace StackpanelDemo
{
    /// <summary>
    /// Interaction logic for HorizontalStackpanel.xaml
    /// </summary>
    public partial class HorizontalStackpanel : Window
    {
        public HorizontalStackpanel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VerticalGrid verticalGrid = new VerticalGrid();
            verticalGrid.Show();
            this.Close();
        }
    }
}
