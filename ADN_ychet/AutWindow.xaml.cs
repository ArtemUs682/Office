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

namespace ADN_ychet
{
    /// <summary>
    /// Логика взаимодействия для AutWindow.xaml
    /// </summary>
    public partial class AutWindow : Window
    {
        public AutWindow()
        {
            InitializeComponent();
        }

        private void gif_MediaEnded(object sender, RoutedEventArgs e)
        {
            aurup.Position = new TimeSpan(0, 0, 1);
            aurup.Play();
            autdown.Position = new TimeSpan(0,0,1);
            autdown.Play();
        }
       

        private void aut_click(object sender, RoutedEventArgs e)
        {
            MainWindow autWindow = new MainWindow();
            this.Close();
            autWindow.Show();
        }


        private void X_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
