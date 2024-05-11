using MundrosoftAssesment.Data;
using MundrosoftAssesment.Models;

namespace MundrosoftAssesment.repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int RegisterUser(Users user)
        {
            _context.Users.Add(user);
            return _context.SaveChanges();
        }

        public Users Authenticate(Users user)
        {
            return _context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
        }

        public int UpdatePassword(Users user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Password = user.Password;
                return _context.SaveChanges();
            }
            return 0;
        }

        public List<Users> GetAllUsersForAdmin()
        {
            return _context.Users.ToList();
        
    }
    

    }
}
