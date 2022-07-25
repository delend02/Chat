using Chat.BLL.DTO;
using Chat.BLL.Interfaces;
using Chat.BLL.Models;
using Chat.DAL.Interfaces;

namespace Chat.BLL.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork DataBase { get; set; }

        public UserService(IUnitOfWork database)
        {
            DataBase = database;
        }

        public AccessAuth Authorization(UserDTO userDTO)
        {
            var user = DataBase.Users.FindByKey(x => x.Login == userDTO.Login);

            if (user is null)
                return AccessAuth.LoginIncorrect;

            if (user.Password != userDTO.Password)
                return AccessAuth.PasswordIncorrect;

            return AccessAuth.Allowed;
        }

        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
