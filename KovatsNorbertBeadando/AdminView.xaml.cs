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

namespace KovatsNorbertBeadando
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        NewEDiaryDataSet newEDiaryDataSet = new NewEDiaryDataSet();
        NewEDiaryDataSetTableAdapters.StudentsTableAdapter StudentContext = new NewEDiaryDataSetTableAdapters.StudentsTableAdapter();
        NewEDiaryDataSetTableAdapters.TeachersTableAdapter TeacherContext = new NewEDiaryDataSetTableAdapters.TeachersTableAdapter();
        CollectionViewSource dbViewSource = new CollectionViewSource();
       

        public AdminView()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            studentsDataGrid.Visibility = Visibility.Hidden;
            StudentStackPanel.Visibility = Visibility.Hidden;

            newEDiaryDataSet = ((NewEDiaryDataSet)(FindResource("newEDiaryDataSet")));
            StudentContext.Fill(newEDiaryDataSet.Students);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsViewSource")));

            TeacherContext.Fill(newEDiaryDataSet.Teachers);
            dbViewSource = ((CollectionViewSource)(this.FindResource("teachersViewSource")));


           
        }

        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            StudentContext.Update(newEDiaryDataSet);
            TeacherContext.Update(newEDiaryDataSet);
           
        }

        private void teachersOrStudentsButton(object sender, RoutedEventArgs e)
        {
            if (teachersDataGrid.IsVisible == false)
            {
                studentsDataGrid.Visibility = Visibility.Hidden;
                StudentStackPanel.Visibility = Visibility.Hidden;
                TeacherStackPanel.Visibility = Visibility.Visible;
                teachersDataGrid.Visibility = Visibility.Visible;
                studentOrTeacers.Content = "Diákok";
            }
            else
            {
                TeacherStackPanel.Visibility = Visibility.Hidden;
                teachersDataGrid.Visibility = Visibility.Hidden;
                studentsDataGrid.Visibility = Visibility.Visible;
                StudentStackPanel.Visibility = Visibility.Visible;
                studentOrTeacers.Content = "Tanárok";
            }
        }
    }
}
