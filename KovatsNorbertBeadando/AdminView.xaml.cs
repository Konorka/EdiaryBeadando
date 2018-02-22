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
    public partial class AdminView : Window
    {
        NewEDiaryDataSet newEDiaryDataSet;
        CollectionViewSource dbViewSource = new CollectionViewSource();
        NewEDiaryDataSetTableAdapters.StudentsTableAdapter StudentContext = new NewEDiaryDataSetTableAdapters.StudentsTableAdapter();
        NewEDiaryDataSetTableAdapters.TeachersTableAdapter TeacherContext = new NewEDiaryDataSetTableAdapters.TeachersTableAdapter();
        NewEDiaryDataSetTableAdapters.ParentsTableAdapter ParentContext = new NewEDiaryDataSetTableAdapters.ParentsTableAdapter();
        NewEDiaryDataSetTableAdapters.DepartmentsTableAdapter DepartmantContext = new NewEDiaryDataSetTableAdapters.DepartmentsTableAdapter();
        NewEDiaryDataSetTableAdapters.TDCTableAdapter TDCContext = new NewEDiaryDataSetTableAdapters.TDCTableAdapter();
        NewEDiaryDataSetTableAdapters.AbsentsTableAdapter StudentAbsentContext = new NewEDiaryDataSetTableAdapters.AbsentsTableAdapter();
        NewEDiaryDataSetTableAdapters.MarksTableAdapter StudentMarkContext = new NewEDiaryDataSetTableAdapters.MarksTableAdapter();

        public AdminView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            studentsDataGrid.Visibility = Visibility.Hidden;

            newEDiaryDataSet = ((NewEDiaryDataSet)(FindResource("newEDiaryDataSet")));

            StudentContext.Fill(newEDiaryDataSet.Students);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsViewSource")));

            TeacherContext.Fill(newEDiaryDataSet.Teachers);
            dbViewSource = ((CollectionViewSource)(FindResource("teachersViewSource")));

            ParentContext.Fill(newEDiaryDataSet.Parents);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsParentsViewSource")));

            TDCContext.Fill(newEDiaryDataSet.TDC);
            dbViewSource = ((CollectionViewSource)(FindResource("teachersTDCViewSource")));

            DepartmantContext.Fill(newEDiaryDataSet.Departments);
            dbViewSource = ((CollectionViewSource)(FindResource("teachersDepartmentsViewSource")));

            StudentAbsentContext.Fill(newEDiaryDataSet.Absents);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsAbsentsViewSource")));
            
            StudentMarkContext.Fill(newEDiaryDataSet.Marks);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsMarksViewSource")));
        }

        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            StudentContext.Update(newEDiaryDataSet);
            TeacherContext.Update(newEDiaryDataSet);
            ParentContext.Update(newEDiaryDataSet);
            DepartmantContext.Update(newEDiaryDataSet);
            TDCContext.Update(newEDiaryDataSet);
        }

        private void teachersOrStudentsButton(object sender, RoutedEventArgs e)
        {
            if (teachersDataGrid.IsVisible == false)
            {
                marksDataGrid.Visibility = Visibility.Hidden;
                classLabel.Visibility = Visibility.Visible;
                depParLabel.Content = "Osztályfőnök adatok:";
                teacherStudentLabel.Content = "Tanár adatai";
                departmentsDataGrid.Visibility = Visibility.Visible;
                tDCDataGrid.Visibility = Visibility.Visible;
                studentsDataGrid.Visibility = Visibility.Hidden;
                parentsDataGrid.Visibility = Visibility.Hidden;
                teachersDataGrid.Visibility = Visibility.Visible;
                studentOrTeacers.Content = "Diákok";
            }
            else
            {
                classLabel.Visibility = Visibility.Hidden;
                marksDataGrid.Visibility = Visibility.Visible;
                depParLabel.Content = "Szülő/Jegyek/hiányzások:";
                teacherStudentLabel.Content = "Tanuló adatai;";
                departmentsDataGrid.Visibility = Visibility.Hidden;
                tDCDataGrid.Visibility = Visibility.Hidden;
                parentsDataGrid.Visibility = Visibility.Visible;
                teachersDataGrid.Visibility = Visibility.Hidden;
                studentsDataGrid.Visibility = Visibility.Visible;
              
                studentOrTeacers.Content = "Tanárok";
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
