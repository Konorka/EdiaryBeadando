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
        NewEDiaryDataSetTableAdapters.CoursesTableAdapter newEDiaryDataSetCoursesTableAdapter = new NewEDiaryDataSetTableAdapters.CoursesTableAdapter();
        NewEDiaryDataSetTableAdapters.AbsentsTableAdapter newEDiaryDataSetAbsentsTableAdapter = new NewEDiaryDataSetTableAdapters.AbsentsTableAdapter();
        NewEDiaryDataSet1TableAdapters.StudentsTableAdapter newEDiaryDataSet1StudentsTableAdapter = new NewEDiaryDataSet1TableAdapters.StudentsTableAdapter();
        NewEDiaryDataSet1TableAdapters.AbsentsTableAdapter newEDiaryDataSet1AbsentsTableAdapter = new NewEDiaryDataSet1TableAdapters.AbsentsTableAdapter();
        NewEDiaryDataSet1TableAdapters.MarksTableAdapter newEDiaryDataSet1MarksTableAdapter = new NewEDiaryDataSet1TableAdapters.MarksTableAdapter();
        NewEDiaryDataSet1TableAdapters.DepartmentsTableAdapter newEDiaryDataSet1DepartmentsTableAdapter = new NewEDiaryDataSet1TableAdapters.DepartmentsTableAdapter();

        public StudentView()
        {
            
            InitializeComponent();
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            newEDiaryDataSet = ((NewEDiaryDataSet)(FindResource("newEDiaryDataSet")));

            newEDiaryDataSetCoursesTableAdapter.Fill(newEDiaryDataSet.Courses);
            dbViewSource = ((CollectionViewSource)(FindResource("coursesViewSource")));

            newEDiaryDataSetAbsentsTableAdapter.Fill(newEDiaryDataSet.Absents);
            dbViewSource = ((CollectionViewSource)(FindResource("absentsViewSource")));

            NewEDiaryDataSet1 newEDiaryDataSet1 = ((NewEDiaryDataSet1)(FindResource("newEDiaryDataSet1")));

            newEDiaryDataSet1StudentsTableAdapter.Fill(newEDiaryDataSet1.Students);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsViewSource1")));

            newEDiaryDataSet1AbsentsTableAdapter.Fill(newEDiaryDataSet1.Absents);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsAbsentsViewSource1")));

            newEDiaryDataSet1MarksTableAdapter.Fill(newEDiaryDataSet1.Marks);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsMarksViewSource1")));
            
            newEDiaryDataSet1DepartmentsTableAdapter.Fill(newEDiaryDataSet1.Departments);
            dbViewSource = ((CollectionViewSource)(FindResource("studentsDepartmentsViewSource1")));

            student_IDComboBox.SelectedIndex = _sVM.studentItemIndex();
            int comboIndex = titleComboBox.SelectedIndex;
            coursAVG.Content = _sVM.studentCourseAVG(comboIndex).ToString();
            titleComboBox.SelectedIndex = 0;
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
