using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KovatsNorbertBeadando
{
    public class MainViewModel
    {

        public Users user { get; set; }
        public MainViewModel()
        {
            var manager = new DataManager();
        }
    }
}
