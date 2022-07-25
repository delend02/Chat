using Chat.BLL.DTO;
using Chat.BLL.Models;

namespace Chat.BLL.Interfaces
{
    public interface IUserService
    {
        AccessAuth Authorization(UserDTO user);
        void Dispose();
    }
}
