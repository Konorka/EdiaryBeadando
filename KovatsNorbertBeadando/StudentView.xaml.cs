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
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : Window
    {

        public StudentViewModel _sVM = new StudentViewModel();

        NewEDiaryDataSet newEDiaryDataSet;
        CollectionViewSource dbViewSource = new CollectionViewSource();
        NewEDiaryDataSetTableAdapters.StudentsTableAdapter newEDiaryDataSetStudentsTableAdapter = new NewEDiaryDataSetTableAdapters.StudentsTableAdapter();
        NewEDiaryDataSetTableAdapters.MarksTableAdapter newEDiaryDataSetMarksTableAdapter = new NewEDiaryDataSetTableAdapters.MarksTableAdapter();
        NewEDiaryDataSetTableAdapters.DepartmentsTableAdapter newEDiaryDataSetDepartmentsTableAdapter = new NewEDiaryDataSetTableAdapters.DepartmentsTableAdapter();
        NewEDiaryDataSetTableAdapters.CoursesTableAdapter newEDiaryDataSetCoursesTableAdapter = new NewEDiaryDataSetTableAdapters.CoursesTableAdapter();
        NewEDiaryDataSetTableAdapters.AbsentsTableAdapter newEDiaryDataSetAbsentsTableAdapter = new NewEDiaryDataSetTableAdapters.AbsentsTableAdapter();

        public StudentView()
        {
            
            InitializeComponent();
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            newEDiaryDataSet = ((NewEDiaryDataSet)(FindResource("newEDiaryDataSet")));

            newEDiaryDataSetStudentsTableAdapter.Fill(newEDiaryDataSet.Students);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsViewSource")));


            
            newEDiaryDataSetMarksTableAdapter.Fill(newEDiaryDataSet.Marks);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsMarksViewSource")));


            
            newEDiaryDataSetDepartmentsTableAdapter.Fill(newEDiaryDataSet.Departments);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsDepartmentsViewSource")));


            
            newEDiaryDataSetCoursesTableAdapter.Fill(newEDiaryDataSet.Courses);
            dbViewSource = ((CollectionViewSource)(FindResource("coursesViewSource")));

            
            newEDiaryDataSetAbsentsTableAdapter.Fill(newEDiaryDataSet.Absents);
            dbViewSource = ((CollectionViewSource)(this.FindResource("absentsViewSource")));



            student_IDComboBox.SelectedIndex = _sVM.studentItemIndex();
            int comboIndex = titleComboBox.SelectedIndex;
            
            coursAVG.Content = _sVM.studentCourseAVG(comboIndex).ToString();
        }

        private void titleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int comboIndex = titleComboBox.SelectedIndex;
            if (_sVM.studentCourseAVG(comboIndex) != -1)
            {
                coursAVG.Content = _sVM.studentCourseAVG(comboIndex).ToString();
            }
            else
                coursAVG.Content = "Nincs jegy";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
