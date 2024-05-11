using MundrosoftAssesment.Models;

namespace MundrosoftAssesment.repositories
{
    public interface IUserRepository
    {
        int RegisterUser(Users user);
        Users Authenticate(Users user);
        int UpdatePassword(Users user);

        List<Users> GetAllUsersForAdmin();
    }
}
