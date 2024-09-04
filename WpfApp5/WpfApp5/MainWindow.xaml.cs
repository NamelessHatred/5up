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
using WpfApp5.FORGODSAKEDataSetTableAdapters;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LoginGORETableAdapter adapter = new LoginGORETableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var allLogins = adapter.GetData().Rows;

            for (int i = 0; i < allLogins.Count; i++)
            {
                if (allLogins[i][1].ToString() == LoginTbx.Text &&
                    allLogins[i][2].ToString() == PasswordTbx.Password)
                {
                    int roleID = (int)allLogins[i][3];

                    switch (roleID)
                    {
                        case 1:
                            FirstRoleWindow role = new FirstRoleWindow(); 
                            role.Show();
                            break;
                        case 2:
                            SecondRoleWindow second = new SecondRoleWindow();
                            second.Show();
                            break;
                    }
                }
            }
        }
    }
}
