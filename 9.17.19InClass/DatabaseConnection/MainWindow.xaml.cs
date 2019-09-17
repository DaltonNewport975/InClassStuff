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

namespace DatabaseConnection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB_128040_practiceEntities db = new DB_128040_practiceEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTNRun_Click(object sender, RoutedEventArgs e)
        {
            foreach (Student student in db.Students)
            {
                string temp = $"{student.FirstName}, {student.LastName}, {student.StudentID}, {student.FavoriteColor}";
                LSBData.Items.Add(temp);
            }
        }
    }
}
