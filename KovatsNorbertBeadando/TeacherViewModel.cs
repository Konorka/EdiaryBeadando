using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KovatsNorbertBeadando
{
    public class TeacherViewModel
    {
        NewEDiaryEntities users = new NewEDiaryEntities();
        public int userId { get; set; }

        public int TeacherItemIndex()
        {
            var user = users.Teachers.FirstOrDefault(x=>x.Teacher_ID==userId);
            return user.Teacher_ID - 1;
        }
        public int TeacherDepartmentIndex()
        {
            var dep_user = users.Departments.FirstOrDefault(x => x.Department_Teacher_ID == userId);
            return dep_user.Department_ID-1;
        }
    }
}
