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
using System.Windows.Media.Animation;
using System.Data.SQLite;
using System.Data;

namespace ADN_ychet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContext db = new AppContext();
        SQLiteConnection con = new SQLiteConnection("Data Source =.\\OfficeDB.db");
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation animAddBut = new DoubleAnimation();
            animAddBut.From = 0;
            animAddBut.To = 133;
            animAddBut.Duration = TimeSpan.FromSeconds(1);
            AddBut.BeginAnimation(Button.WidthProperty,animAddBut);
            DelBut.BeginAnimation(Button.WidthProperty, animAddBut);
            RedBut.BeginAnimation(Button.WidthProperty, animAddBut);

            DoubleAnimation animAddImag = new DoubleAnimation();
            animAddImag.From = 0;
            animAddImag.To = 30;
            animAddImag.Duration = TimeSpan.FromSeconds(1);
            addImag.BeginAnimation(Button.WidthProperty, animAddImag);
            DelImag.BeginAnimation(Button.WidthProperty, animAddImag);
            RedImag.BeginAnimation(Button.WidthProperty, animAddImag);

            DoubleAnimation animList = new DoubleAnimation();
            animList.From = 0;
            animList.To = 500;
            animList.Duration = TimeSpan.FromSeconds(1);
            list1.BeginAnimation(ListBox.WidthProperty, animList);

            DoubleAnimation animGrid = new DoubleAnimation();
            animList.From = 0;
            animList.To = 500;
            animList.Duration = TimeSpan.FromSeconds(1);
            // gridstats.BeginAnimation(ListBox.WidthProperty, animGrid);


           
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void gif_MediaEnded(object sender, RoutedEventArgs e)
        {
            gif.Position = new TimeSpan(0, 0, 1);
            gif.Play();
        }

        private void gif2_MediaEnded(object sender, RoutedEventArgs e)
        {
            gif.Position = new TimeSpan(0, 0, 1);
            gif.Play();
        }

        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
 