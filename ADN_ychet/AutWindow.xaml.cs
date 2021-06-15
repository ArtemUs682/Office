using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
        AppContext db = new AppContext();
        SQLiteConnection con = new SQLiteConnection("Data Source =.\\OfficeDB.db");
        public AutWindow()
        {
            InitializeComponent();

        }

        private void RegButton(object sender, RoutedEventArgs e)
        {
            reg Reg = new reg();
            Reg.Show();
            Close();
        }
        private void LoginButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы возможно успешно авторизовались!");
        }

        private void gif_MediaEnded(object sender, RoutedEventArgs e)
        {
            aurup.Position = new TimeSpan(0, 0, 1);
            aurup.Play();
            autdown.Position = new TimeSpan(0, 0, 1);
            autdown.Play();
        }




        private void X_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void aut_click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(password.Password))
            {
                MessageBox.Show("Ошибочка! Не оставляйте поля пустыми!");
            }
            using (var db = new AppContext())
            {
                var user = db.Users.Where(u => u.Login == login.Text && u.Password == password.Password).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Ошибка! Пользователь с такими данными не найден.");
                }
                else
                {
                    MessageBox.Show("Вы успешно авторизовались!");
                    MainWindow autWindow = new MainWindow();
                    this.Close();
                    autWindow.Show();
                }
            }
        }
    }
}
