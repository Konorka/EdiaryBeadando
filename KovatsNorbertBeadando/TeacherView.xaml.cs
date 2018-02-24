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
    /// Interaction logic for TeacherView.xaml
    /// </summary>
    public partial class TeacherView : Window
    {
        public TeacherViewModel _tVM = new TeacherViewModel();

        NewEDiaryDataSet newEDiaryDataSet;
        NewEDiaryDataSet1 newEDiaryDataSet1;
        CollectionViewSource dbViewSource = new CollectionViewSource();
        
        
        
        NewEDiaryDataSetTableAdapters.TeachersTableAdapter TeacherContext = new NewEDiaryDataSetTableAdapters.TeachersTableAdapter();
        
        NewEDiaryDataSetTableAdapters.ParentsTableAdapter newEDiaryDataSetParentsTableAdapter = new NewEDiaryDataSetTableAdapters.ParentsTableAdapter();

        NewEDiaryDataSet1TableAdapters.DepartmentsTableAdapter DepartmantContext = new NewEDiaryDataSet1TableAdapters.DepartmentsTableAdapter();
        NewEDiaryDataSet1TableAdapters.StudentsTableAdapter StudentContext = new NewEDiaryDataSet1TableAdapters.StudentsTableAdapter();
        NewEDiaryDataSet1TableAdapters.AbsentsTableAdapter AbsentContext = new NewEDiaryDataSet1TableAdapters.AbsentsTableAdapter();
        NewEDiaryDataSet1TableAdapters.MarksTableAdapter MarkContext = new NewEDiaryDataSet1TableAdapters.MarksTableAdapter();
        NewEDiaryDataSet1TableAdapters.ParentsTableAdapter ParentContext = new NewEDiaryDataSet1TableAdapters.ParentsTableAdapter();


        public TeacherView()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            newEDiaryDataSet = ((NewEDiaryDataSet)(FindResource("newEDiaryDataSet")));

            TeacherContext.Fill(newEDiaryDataSet.Teachers);
            dbViewSource = ((CollectionViewSource)(FindResource("teachersViewSource")));

            department_NameComboBox.SelectedIndex = _tVM.TeacherDepartmentIndex();
            teacher_IDComboBox.SelectedIndex = _tVM.TeacherItemIndex();



            newEDiaryDataSet1 = ((NewEDiaryDataSet1)(FindResource("newEDiaryDataSet1")));

            DepartmantContext.Fill(newEDiaryDataSet1.Departments);
            dbViewSource = ((CollectionViewSource)(FindResource("departmentsViewSource1")));

            StudentContext.Fill(newEDiaryDataSet1.Students);
            dbViewSource = ((CollectionViewSource)(FindResource("departmentsStudentsViewSource1")));

            AbsentContext.Fill(newEDiaryDataSet1.Absents);
            dbViewSource = ((CollectionViewSource)(FindResource("departmentsStudentsAbsentsViewSource1")));

            MarkContext.Fill(newEDiaryDataSet1.Marks);
            dbViewSource = ((CollectionViewSource)(FindResource("departmentsStudentsMarksViewSource1")));

            ParentContext.Fill(newEDiaryDataSet1.Parents);
            dbViewSource = ((CollectionViewSource)(FindResource("departmentsStudentsParentsViewSource1")));
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(1);
        }

        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            DepartmantContext.Update(newEDiaryDataSet1);
            StudentContext.Update(newEDiaryDataSet1);
            TeacherContext.Update(newEDiaryDataSet);
            MarkContext.Update(newEDiaryDataSet1);
            AbsentContext.Update(newEDiaryDataSet1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (StudentAvailability.Visibility == Visibility.Visible)
            {
                ChangeBtn.Content = "Tanuló elérhetőségek";

                absentsDataGrid.Visibility = Visibility.Visible;
                StudentAvailability.Visibility = Visibility.Hidden;
                marksDataGrid1.Visibility = Visibility.Visible;
            }
            else
            {
                ChangeBtn.Content = "Tanuló jegyek/hiányzások";

                absentsDataGrid.Visibility=Visibility.Hidden;
                StudentAvailability.Visibility = Visibility.Visible;
                marksDataGrid1.Visibility = Visibility.Hidden;
            }
            
        }
    }
}
