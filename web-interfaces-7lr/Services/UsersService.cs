using System.Collections.Generic;
using System.Threading.Tasks;

namespace _6lr
{
    public interface IUsersService
    {
        Task<List<Users>> GetUsers();
        Task AddUser(Users user);
        Task UpdateUser(Users user);
        Task DeleteUser(int id);
    }

    public class UsersService : IUsersService
    {
        private readonly List<Users> _users = new List<Users>();

        public UsersService()
        {
            _users.Add(new Users { Id = 0, Name = "Oleg", Surname = "Oleg", FavoriteGenre = "Fiction", FavoriteBookTitle = "Book 1" });
            _users.Add(new Users { Id = 1, Name = "Ivan", Surname = "Ivan", FavoriteGenre = "Mystery", FavoriteBookTitle = "Book 2" });
            _users.Add(new Users { Id = 2, Name = "Maria", Surname = "Maria", FavoriteGenre = "Thriller", FavoriteBookTitle = "Book 3" });
            _users.Add(new Users { Id = 3, Name = "Anna", Surname = "Anna", FavoriteGenre = "Fantasy", FavoriteBookTitle = "Book 4" });
            _users.Add(new Users { Id = 4, Name = "Pavel", Surname = "Pavel", FavoriteGenre = "Science Fiction", FavoriteBookTitle = "Book 5" });
            _users.Add(new Users { Id = 5, Name = "Olga", Surname = "Olga", FavoriteGenre = "Romance", FavoriteBookTitle = "Book 6" });
            _users.Add(new Users { Id = 6, Name = "Andrii", Surname = "Andrii", FavoriteGenre = "Non-Fiction", FavoriteBookTitle = "Book 7" });
            _users.Add(new Users { Id = 7, Name = "Natalia", Surname = "Natalia", FavoriteGenre = "Biography", FavoriteBookTitle = "Book 8" });
            _users.Add(new Users { Id = 8, Name = "Dmitry", Surname = "Dmitry", FavoriteGenre = "Historical Fiction", FavoriteBookTitle = "Book 9" });
            _users.Add(new Users { Id = 9, Name = "Svitlana", Surname = "Svitlana", FavoriteGenre = "Horror", FavoriteBookTitle = "Book 10" });
        }

        public async Task<List<Users>> GetUsers()
        {
            return _users;
        }

        public async Task AddUser(Users user)
        {
            _users.Add(user);
        }

        public async Task UpdateUser(Users user)
        {
            var index = _users.FindIndex(u => u.Id == user.Id);
            if (index != -1)
            {
                _users[index] = user;
            }
        }

        public async Task DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }
    }
}
