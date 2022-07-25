using AutoMapper;
using Chat.BLL.DTO;
using Chat.BLL.Interfaces;
using Chat.DAL.Entities;
using Chat.DAL.Interfaces;

namespace Chat.BLL.Services
{
    public class MessageService : IMessageService
    {
        IUnitOfWork DataBase { get; set; }

        public MessageService(IUnitOfWork dataBase)
        {
            DataBase = dataBase;
        }

        public IEnumerable<MessageDTO> GetLastMessage()
        {
            var mapper = new MapperConfiguration(cf => cf.CreateMap<Message, MessageDTO>()).CreateMapper();
            var result = mapper.Map<IEnumerable<Message>, IEnumerable<MessageDTO>>(DataBase.Messages.GetLast());
            return result;
        }

        public void SendTextMessage(MessageDTO messageDTO)
        {
            var user = DataBase.Users.Get(messageDTO.SenderID);

            if (user is not null)
            {
                var message = new Message
                {
                    Content = messageDTO.Content,
                    Sender = user,
                    TimeOfDispath = DateTime.Now
                };
                DataBase.Messages.Create(message);
            }
        }

        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
