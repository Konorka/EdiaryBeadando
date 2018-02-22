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
        NewEDiaryDataSetTableAdapters.DepartmentsTableAdapter DepartmantContext = new NewEDiaryDataSetTableAdapters.DepartmentsTableAdapter();
        NewEDiaryDataSetTableAdapters.StudentsTableAdapter StudentContext = new NewEDiaryDataSetTableAdapters.StudentsTableAdapter();
        NewEDiaryDataSetTableAdapters.TeachersTableAdapter TeacherContext = new NewEDiaryDataSetTableAdapters.TeachersTableAdapter();
        NewEDiaryDataSetTableAdapters.MarksTableAdapter MarkContext = new NewEDiaryDataSetTableAdapters.MarksTableAdapter();
        NewEDiaryDataSetTableAdapters.AbsentsTableAdapter AbsentContext = new NewEDiaryDataSetTableAdapters.AbsentsTableAdapter();


        public TeacherView()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            newEDiaryDataSet = ((NewEDiaryDataSet)(FindResource("newEDiaryDataSet")));



            DepartmantContext.Fill(newEDiaryDataSet.Departments);
            dbViewSource = ((CollectionViewSource)(FindResource("departmentsViewSource")));




            StudentContext.Fill(newEDiaryDataSet.Students);
            dbViewSource = ((CollectionViewSource)(FindResource("departmentsStudentsViewSource")));




            TeacherContext.Fill(newEDiaryDataSet.Teachers);
            dbViewSource = ((CollectionViewSource)(FindResource("teachersViewSource")));


            MarkContext.Fill(newEDiaryDataSet.Marks);
            dbViewSource = ((CollectionViewSource)(this.FindResource("departmentsStudentsMarksViewSource")));


            AbsentContext.Fill(newEDiaryDataSet.Absents);
            dbViewSource = ((CollectionViewSource)(this.FindResource("departmentsStudentsAbsentsViewSource")));
            


            
            teacher_IDComboBox.SelectedIndex = _tVM.TeacherItemIndex();
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(1);
        }

        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            DepartmantContext.Update(newEDiaryDataSet);
            StudentContext.Update(newEDiaryDataSet);
            TeacherContext.Update(newEDiaryDataSet);
            MarkContext.Update(newEDiaryDataSet);
            AbsentContext.Update(newEDiaryDataSet);
        }
    }
}
