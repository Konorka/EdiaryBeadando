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

namespace KovatsNorbertBeadando
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainViewModel _vm;
        LoginView _lv = new LoginView();
        AdminView _av = new AdminView();
        eDiaryModel context = new eDiaryModel();

        public MainWindow()
        {
            try
            {
                InitializeComponent();
                var loginView = new LoginView();
                loginView.ShowDialog();
                _vm = new MainViewModel
                {
                    user = loginView.ViewModel.AuthenticatedUser
                };
                DataContext = _vm;

                switch (_vm.user.User_Access_Rank)
                {
                    case 1:
                        Hide();
                        _av.Show();
                        break;
                    case 2:
                      
                        break;
                    case 3:
                      
                        break;
                }

            }
            catch (Exception)
            {

                Hide();
            }



        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
