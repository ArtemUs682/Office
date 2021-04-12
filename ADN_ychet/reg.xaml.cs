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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Window
    {
        AppContext db = new AppContext();
        SQLiteConnection con = new SQLiteConnection("Data Source =.\\OfficeDB.db");
        public reg()
        {
           
            InitializeComponent();
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
        //    public void RegButton(object sender, RoutedEventArgs e)
        //    {
        //        if (db.Users.Select(item => item.Login).Contains(login.Text))
        //        {
        //            MessageBox.Show("Ошибка! Такой логин уже сущетсвует в системе!");
        //            return;
        //        }
        //        Users newUser = new Users()
        //        {
        //            Login = login.Text,
        //            Name = name.Text,
        //            Password = pass.Password,
        //        };
        //        db.Users.Add(newUser);
        //        db.SaveChanges();
        //        MessageBox.Show("Регистрация прошла успешна!");
        //        Login aw = new Login();
        //        aw.Show();
        //    }

        public void CancelButton(object sender, RoutedEventArgs e)
        {
            AutWindow aut = new AutWindow();
            aut.Show();
            Close();
        }


    }

}

