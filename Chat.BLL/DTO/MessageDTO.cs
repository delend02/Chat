namespace Chat.BLL.DTO
{
    public class MessageDTO
    {
        public DateTime TimeOfDispath { get; set; }
        public string Content { get; set; }
        public ulong SenderID { get; set; }
    }
}
