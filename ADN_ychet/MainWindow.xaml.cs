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
            Vivod();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sc = new SQLiteConnection();
            SQLiteCommand com = new SQLiteCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("insert into Equipment (Id, Name, Limit) values ('" + Id_Eq.Text + "', '" + Name_Eq.Text + "', '" + Limit_Eq.Text + "');");
            com.ExecuteNonQuery();
            sc.Close();
            Vivod();
        }

        private void DelBut_Eq_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sc = new SQLiteConnection();
            SQLiteCommand com = new SQLiteCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Update Equipment where Id = " + Id_Eq.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
            Vivod();
        }

        private void RedBut_Eq_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sc = new SQLiteConnection();
            SQLiteCommand com = new SQLiteCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Update Equipment set Name = " + Name_Eq.Text + ", Limit = " + Limit_Eq.Text + " where Id = " + Id_Eq.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
            Vivod();
        }

        private void Add_Room_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sc = new SQLiteConnection();
            SQLiteCommand com = new SQLiteCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("insert into Rooms (Id, Number) values ('" + Id_Room.Text + "', '" + Number_Rooms.Text + "');");
            com.ExecuteNonQuery();
            sc.Close();
            Vivod();
        }

        private void DelBut_Room_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sc = new SQLiteConnection();
            SQLiteCommand com = new SQLiteCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Delete from Rooms where Id = " + Id_Room.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
        }

        private void RedBut_Room_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sc = new SQLiteConnection();
            SQLiteCommand com = new SQLiteCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Update Rooms set Number = " + Number_Rooms.Text + " where Id = " + Id_Room.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
            Vivod();
        }

        private void Add_Unit_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sc = new SQLiteConnection();
            SQLiteCommand com = new SQLiteCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("insert into Units (Id, EquipmentId, Comissioned, RoomId) values ('" + Id_Unit.Text + "', '" + EqID_Unit.Text + "', '" + Commisioned_Unit.Text + "', '" +RoomID_Unit+"');");
            com.ExecuteNonQuery();
            sc.Close();
            Vivod();
        }

        private void Del_Unit_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sc = new SQLiteConnection();
            SQLiteCommand com = new SQLiteCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Delete from Units where Id = " + Id_Unit.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
            Vivod();
        }

        private void Red_Unit_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sc = new SQLiteConnection();
            SQLiteCommand com = new SQLiteCommand();
            sc.ConnectionString = ("Data Source =.\\OfficeDB.db");
            sc.Open();
            com.Connection = sc;
            com.CommandText = ("Update Units set EquipmentId = " + EqID_Unit.Text + ", Comissioned = " +Commisioned_Unit+", RoomId = "+RoomID_Unit+" where Id = " + Id_Unit.Text + ";");
            com.ExecuteNonQuery();
            sc.Close();
            Vivod();
        }

        public void Vivod ()
        {
            string query;
            DataTable dataTable = new DataTable();

            query = "SELECT Id AS '№', Name AS Наименование, Equipment.'Limit' AS Лимит FROM Equipment;";
            dataTable = WorkWithQuery(query);
            EqDg.ItemsSource = dataTable.DefaultView;

            query = "SELECT Id AS '№', Number AS Кабинет FROM Rooms;";
            dataTable = WorkWithQuery(query);
            RoomDg.ItemsSource = dataTable.DefaultView;

            query = "SELECT Units.Id AS '№', Equipment.Name AS 'Наименование', Comissioned AS Дата, Rooms.Number AS Кабинет FROM Units " +
                "INNER JOIN Equipment ON Units.EquipmentId = Equipment.Id " +
                "INNER JOIN Rooms ON Units.RoomId = Rooms.Id;";
            dataTable = WorkWithQuery(query);
            UnDg.ItemsSource = dataTable.DefaultView;
        }

        public DataTable WorkWithQuery(string query)
        {
            con.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "1";
            DataTable dataTable = new DataTable();
            dataTable = GridStatsFunc(query);
            gridstats.ItemsSource = dataTable.DefaultView;
        }

        public DataTable GridStatsFunc(string Adding)
        {
            con.Open();
            string query = "SELECT Units.Id AS '№', Equipment.Name AS 'Наименование', Comissioned AS Дата, Rooms.Number AS Кабинет FROM Units " +
                "INNER JOIN Equipment ON Units.EquipmentId = Equipment.Id " +
                "INNER JOIN Rooms ON Units.RoomId = Rooms.Id " +
                "WHERE Equipment.Id = " + Adding + " ;";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string query = "2";
            DataTable dataTable = new DataTable();
            dataTable = GridStatsFunc(query);
            gridstats.ItemsSource = dataTable.DefaultView;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string query = "3";
            DataTable dataTable = new DataTable();
            dataTable = GridStatsFunc(query);
            gridstats.ItemsSource = dataTable.DefaultView;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string query = "4";
            DataTable dataTable = new DataTable();
            dataTable = GridStatsFunc(query);
            gridstats.ItemsSource = dataTable.DefaultView;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string query = "5";
            DataTable dataTable = new DataTable();
            dataTable = GridStatsFunc(query);
            gridstats.ItemsSource = dataTable.DefaultView;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string query = "6";
            DataTable dataTable = new DataTable();
            dataTable = GridStatsFunc(query);
            gridstats.ItemsSource = dataTable.DefaultView;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string query = "7";
            DataTable dataTable = new DataTable();
            dataTable = GridStatsFunc(query);
            gridstats.ItemsSource = dataTable.DefaultView;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string query = "8";
            DataTable dataTable = new DataTable();
            dataTable = GridStatsFunc(query);
            gridstats.ItemsSource = dataTable.DefaultView;
        }
    }
}

 