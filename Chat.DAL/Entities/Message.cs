namespace Chat.DAL.Entities
{
    public class Message
    {
        public long ID { get; set; }
        public DateTime TimeOfDispath { get; set; }
        public string Content { get; set; }
        public User Sender { get; set; }
    }
}
