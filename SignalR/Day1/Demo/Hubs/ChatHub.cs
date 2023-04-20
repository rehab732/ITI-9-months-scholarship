using Microsoft.AspNetCore.SignalR;

namespace Demo.Hubs
{
    public class ChatHub :Hub
    {
        //SignalR client call this functions RPC
        public void NewMessage(string name,string msg)
        {
            //logic
            //notify
            // Clients==Context.Employee
            //Clients.All
            //Clients.Caller
            // Clients.Clients(ids)

            Clients.All.SendAsync("NotifyNewMessage",name,msg);//call rpc from clients
            //logic
        }
    }
}
