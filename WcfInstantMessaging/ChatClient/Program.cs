using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatClient.ChatService;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChatServiceClient chatProxy = new ChatServiceClient())
            {
                chatProxy.PostNote("Thanh Doan", "Hello WCF World");
            }
        }
    }
}
