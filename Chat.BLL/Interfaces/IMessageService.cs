using Chat.BLL.DTO;

namespace Chat.BLL.Interfaces
{
    public interface IMessageService
    {
        void SendTextMessage(MessageDTO messageDTO);
        IEnumerable<MessageDTO> GetLastMessage();
        void Dispose();
    }
}
