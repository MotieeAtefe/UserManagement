
using UserManagement;

class UserService
{
    private List<User> li = new List<User>();
    public void AddUser(User users)
    {
        li.Add(users);

    }

    public User GetByEmail(string email)
    {
        var result = li.FirstOrDefault(x => x.Email == email);
        return result;
    }

    public User GetById(int id)
    {
        var result = li.FirstOrDefault(c => c.Id == id);
        return result;
    }

    public bool Login(string email, string password)
    {
        var user = GetByEmail(email);
        if (user == null)
        {
            return false;
        }
        return user.Password == password;
    }


}