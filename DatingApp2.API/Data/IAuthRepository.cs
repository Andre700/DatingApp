using System.Threading.Tasks;
using DatingApp2.API.Models;
namespace DatingApp2.API.Data
{
    public interface IAuthRepository
    {
        Task<Users> Register(Users user, string password);
        Task<Users> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}