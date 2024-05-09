using Ecommerce.DAL.Helper;
using Ecommerce.DAL.ViewModel;
using System.Data;
using Constant = ECommerce.Constant;//to reduce ambiguity between system.constant and ecommerc eone

namespace Ecommerce.BLL.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly ECommerceDbHelper _dbHelper;

        public UserService(ECommerceDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public string SignInUser(UserViewModel user)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                   { Constant.Keys.Username, user.Username ?? string.Empty },
                   { Constant.Keys.Password, user.Password ?? string.Empty }
                };

                DataTable results = _dbHelper.ExecuteStoredProcedure(Constant.StoredProcedure.spSignInUser, parameters);

                if (results.Rows.Count > 0)
                {
                    return results.Rows[0][Constant.Text.SignInStatus].ToString();
                }

                return Constant.Text.Error; // If no rows returned, consider it as an error
            }
            catch 
            {
                throw;
            }
        }

        public string Registration(UserViewModel user, out string signUpStatus)
        {
            try
            {
                signUpStatus = string.Empty;

                var parameters = new Dictionary<string, object>
                {
                   { Constant.Keys.Fullname, user.FullName ?? string.Empty },
                   { Constant.Keys.Username, user.Username ?? string.Empty },
                   { Constant.Keys.EmailId, user.EmailId ?? string.Empty },
                   { Constant.Keys.Password, user.Password ?? string.Empty },
                   { Constant.Keys.CreatedAt, DateTime.Now }
                };

                DataTable results = _dbHelper.ExecuteStoredProcedure(Constant.StoredProcedure.spSignUpuser, parameters);

                if (results.Rows.Count > 0)
                {
                    string statusMessage = results.Rows[0][Constant.Text.StatusMessage].ToString();
                    signUpStatus = statusMessage; // Assigning status message to out parameter

                    return statusMessage; // Returning the status message
                }

                return Constant.Text.Error; // If no result is found, return a generic error message
            }
            catch 
            {
                throw;
            }
        }
    }
}
