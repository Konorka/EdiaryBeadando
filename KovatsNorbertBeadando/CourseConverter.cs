using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace KovatsNorbertBeadando
{
    public class CourseConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int Val = (int)value;
            switch (Val)
            {
                case 1: return "Magyar nyelv";
                case 2: return "Magyar Irodalom";
                case 3: return "Matematika";
                case 4: return "Történelem";
                case 5: return "Testnevelés";
                case 6: return "Földrajz";
                case 7: return "Biológia";
                case 8: return "Fizika";
                case 9: return "Kémia";
                case 10: return "Informatika";
                default: return "Kérem forduljon a rendszergazdához";
            }
            //NewEDiaryDataSet departmants = new NewEDiaryDataSet();
            //var department = departmants.Departments.FirstOrDefault(x => x.Department_ID == Val);
            //return department.Department_Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}