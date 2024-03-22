using Microsoft.EntityFrameworkCore;
using System;
using application.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace application.Controllers
{
    public class AuthController
    {
        iti_ExamContext db = new iti_ExamContext();

        public (string UserType, int ID) AuthenticateUser(string email, string password)
        {
            var userTypeParam = new SqlParameter("@UserType", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output };
            var userIDParam = new SqlParameter("@UserID", SqlDbType.Int) { Direction = ParameterDirection.Output };

            db.Database.ExecuteSqlRaw("EXEC AuthenticateUser @Email, @Password, @UserType OUTPUT, @UserID OUTPUT",
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password),
                userTypeParam,
                userIDParam);

            string userType = userTypeParam.Value?.ToString() ?? "Invalid";
            int userID = userIDParam.Value as int? ?? -1;

            return (userType, userID);
        }
    }
}
