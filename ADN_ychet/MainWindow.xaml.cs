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
using System.Data.SqlClient;

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

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("insert into Equipment (Id, Name, Limit) values ('" + Id_Eq.Text + "', '" + Name_Eq.Text + "', '" + Limit_Eq.Text + "');");
            com.ExecuteNonQuery();
            sc.Close();
        }

        private void DelBut_Eq_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Update Equipment where Id = " + Id_Eq.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
        }

        private void RedBut_Eq_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Update Equipment set Name = " + Name_Eq.Text + ", Limit = " + Limit_Eq.Text + " where Id = " + Id_Eq.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
        }

        private void Add_Room_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("insert into Rooms (Id, Number) values ('" + Id_Room.Text + "', '" + Number_Rooms.Text + "');");
            com.ExecuteNonQuery();
            sc.Close();
        }

        private void DelBut_Room_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Delete from Rooms where Id = " + Id_Room.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
        }

        private void RedBut_Room_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Update Rooms set Number = " + Number_Rooms.Text + " where Id = " + Id_Room.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
        }

        private void Add_Unit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("insert into Units (Id, EquipmetId, Comissioned, RoomId) values ('" + Id_Unit.Text + "', '" + EqID_Unit.Text + "', '" + Commisioned_Unit.Text + "', '" +RoomID_Unit+"');");
            com.ExecuteNonQuery();
            sc.Close();
        }

        private void Del_Unit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Delete from Units where Id = " + Id_Unit.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
        }

        private void Red_Unit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Update Units set EquipmetId = " + EqID_Unit.Text + ", Comissioned = " +Commisioned_Unit+", RoomId = "+RoomID_Unit+" where Id = " + Id_Unit.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
        }
    }
}
 