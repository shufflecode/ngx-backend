using System.Collections.Generic;
using ngx_backend.Entities;

namespace ngx_backend.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}