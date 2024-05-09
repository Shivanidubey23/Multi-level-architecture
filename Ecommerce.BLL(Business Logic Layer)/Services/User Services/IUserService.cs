using Ecommerce.DAL.ViewModel;

namespace Ecommerce.BLL.Services.UserServices
{
    public interface IUserService
    {
        string SignInUser(UserViewModel user);

        string Registration(UserViewModel user, out string signUpStatus);
    }
}
