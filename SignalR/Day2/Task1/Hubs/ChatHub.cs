using Microsoft.AspNetCore.SignalR;

namespace Task1.Hubs
{
    public class ChatHub:Hub
    {
        public void NewMessage(string name, string msg)
        {
            Clients.All.SendAsync("NotifyNewMessage", name, msg);//call rpc from clients
        }

    }
}
