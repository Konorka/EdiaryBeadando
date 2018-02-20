using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KovatsNorbertBeadando
{
    class DataManager
    {
        readonly NewEDiaryEntities _ctx;
        public DataManager()
        {
            _ctx = new NewEDiaryEntities();
            if (!_ctx.Users.Any(x => x.User_Name == "admin"))
            {
                _ctx.Users.Add(new Users
                {
                    User_ID = 0,
                    User_Name = "admin",
                    Password = "admin",
                    User_Access_Rank = 1

                });
                _ctx.SaveChanges();
            }
        }
        public Users GetUser(string username, string password)
        {
            try
            {
                return _ctx.Users.FirstOrDefault(x => x.User_Name == username && x.Password == password);
            }
            catch (InvalidOperationException)
            {

                return null;
            }
        }
    }
}
