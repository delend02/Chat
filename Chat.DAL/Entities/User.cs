﻿namespace Chat.DAL.Entities
{
    public class User
    {
        public long ID { get; set; }
        public string NickName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
