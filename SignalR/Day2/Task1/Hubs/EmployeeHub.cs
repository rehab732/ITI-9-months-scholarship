using Microsoft.AspNetCore.SignalR;
using Task1.Models;

namespace Task1.Hubs
{
    public class EmployeeHub:Hub
    {
        public void AddNewEmp(Employee emp)
        {
            Clients.All.SendAsync("NotifayNewEmployee", emp);
        }
    }
}
