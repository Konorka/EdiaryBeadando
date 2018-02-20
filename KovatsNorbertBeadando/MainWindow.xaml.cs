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
        NewEDiaryEntities context = new NewEDiaryEntities();



       
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
                
                switch (_vm.user.User_Access_Rank)
                {
                    case 1:
                        _av.Show();
                        Hide();
                        break;
                    case 2:
                        TeacherView _tV = new TeacherView();
                        _tV.Show();
                        Hide();
                      
                        break;
                    case 3:
                        StudentView _sV = new StudentView();
                        _sV._sVM.userId = _vm.user.User_ID;
                        
                        _sV.Show();
                        Hide();

                        break;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("lol?");
                Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
