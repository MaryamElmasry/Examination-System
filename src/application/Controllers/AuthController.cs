using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Models;
using Microsoft.EntityFrameworkCore;
namespace application.Controllers
{
    public class AuthController
    {
        iti_ExamContext db = new iti_ExamContext();
        public User Login(string email, string password)
        {
          var user = db.Users
         .Include(u => u.Student)
         .Include(u => u.Instructor)
         .FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                return user;
            }
            return null;
        }
        
    }
}
