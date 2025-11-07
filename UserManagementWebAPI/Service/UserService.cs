using UserManagementWebAPI.Model;

namespace UserManagementWebAPI.Service
{
    public class UserService
    {
        List<User> li = new List<User>();

        public void AddUser(User user)
        {
            user.Id = new Random().Next(1,90000);
            li.Add(user);

        }
        public User GetUserById(int id)
        {
            var result = li.FirstOrDefault(x => x.Id == id);
            return result;

        }

        public User GetUserByEmail(string email)
        {
            var result = li.FirstOrDefault(x => x.Email == email);
            return result;
        }

        public bool Login(string email, string password)
        {
            return li.Any(x => x.Email == email && x.Password == password);

        }


    }
}
