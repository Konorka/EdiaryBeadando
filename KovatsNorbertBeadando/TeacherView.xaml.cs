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
        NewEDiaryDataSet newEDiaryDataSet;
        public TeacherViewModel _tVM = new TeacherViewModel();
        CollectionViewSource dbViewSource = new CollectionViewSource();
        NewEDiaryDataSetTableAdapters.DepartmentsTableAdapter newEDiaryDataSetDepartmentsTableAdapter = new NewEDiaryDataSetTableAdapters.DepartmentsTableAdapter();
        NewEDiaryDataSetTableAdapters.StudentsTableAdapter newEDiaryDataSetStudentsTableAdapter = new NewEDiaryDataSetTableAdapters.StudentsTableAdapter();
        NewEDiaryDataSetTableAdapters.TeachersTableAdapter newEDiaryDataSetTeachersTableAdapter = new NewEDiaryDataSetTableAdapters.TeachersTableAdapter();
        NewEDiaryDataSetTableAdapters.MarksTableAdapter newEDiaryDataSetMarksTableAdapter = new NewEDiaryDataSetTableAdapters.MarksTableAdapter();
        NewEDiaryDataSetTableAdapters.AbsentsTableAdapter newEDiaryDataSetAbsentsTableAdapter = new NewEDiaryDataSetTableAdapters.AbsentsTableAdapter();


        public TeacherView()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            newEDiaryDataSet = ((NewEDiaryDataSet)(FindResource("newEDiaryDataSet")));
            

            
            newEDiaryDataSetDepartmentsTableAdapter.Fill(newEDiaryDataSet.Departments);
            dbViewSource = ((CollectionViewSource)(FindResource("departmentsViewSource")));
            

            
            
            newEDiaryDataSetStudentsTableAdapter.Fill(newEDiaryDataSet.Students);
            dbViewSource = ((CollectionViewSource)(FindResource("departmentsStudentsViewSource")));
            
            
            
            
            newEDiaryDataSetTeachersTableAdapter.Fill(newEDiaryDataSet.Teachers);
            dbViewSource = ((CollectionViewSource)(FindResource("teachersViewSource")));

            
            
            newEDiaryDataSetMarksTableAdapter.Fill(newEDiaryDataSet.Marks);
            dbViewSource = ((CollectionViewSource)(this.FindResource("departmentsStudentsMarksViewSource")));
            
            
            
            newEDiaryDataSetAbsentsTableAdapter.Fill(newEDiaryDataSet.Absents);
            dbViewSource = ((CollectionViewSource)(this.FindResource("departmentsStudentsAbsentsViewSource")));
            


            
            teacher_IDComboBox.SelectedIndex = _tVM.TeacherItemIndex();
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
