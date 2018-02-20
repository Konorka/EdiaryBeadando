using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;

namespace KovatsNorbertBeadando
{

    public class StudentViewModel
    {
        NewEDiaryEntities users = new NewEDiaryEntities();
        public int userId { get; set;}

        public StudentViewModel()
        { }

        public int studentItemIndex()            
        {
            int UserIndex;
            var user = users.Students.FirstOrDefault(x => x.Student_User_ID == userId);
            return UserIndex = user.Student_ID -1;
        }

        public int studentDeparmantIndex()
        {
            int UserIndex;
            var user = users.Students.FirstOrDefault(x => x.Student_User_ID == userId);
            var department = users.Departments.FirstOrDefault(x => x.Department_ID ==user.Departments_ID);
            return UserIndex = department.Department_ID - 1;
        }
        public double studentCourseAVG(int course)
        {
            try
            {

            
            if (course == -1)
            {
                return -1;
            }
            else
            {
                var user = users.Students.FirstOrDefault(x => x.Student_User_ID == userId);
                var mark = users.Marks
                    .Where(x=>x.Student_Mark_ID==user.Student_ID)
                    .Where(x => x.Course_ID == course + 1)
                    .Average(x => x.Mark);
                var AVG = users.Marks.Where(x => x.Course_ID == course+1).Average(x => x.Mark);
                
                return mark;
            }
            }
            catch (Exception)
            {

                return -1; ;
            }
        }
    }
}
