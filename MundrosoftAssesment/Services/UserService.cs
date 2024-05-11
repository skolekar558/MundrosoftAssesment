using MundrosoftAssesment.Models;
using MundrosoftAssesment.repositories;

namespace MundrosoftAssesment.Services
{
    public class UserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository userRepository)
        {
            _repo = userRepository;
        }

        public int RegisterUser(Users user)
        {
           
            return _repo.RegisterUser(user);
        }

        public Users Authenticate(Users user)
        {
           
            return _repo.Authenticate(user);
        }

        public int UpdatePassword(Users user)
        {
            
            return _repo.UpdatePassword(user);
        }

        public List<Users> GetAllUsersForAdmin()
        {
            
            return _repo.GetAllUsersForAdmin();
        }
    }
}
