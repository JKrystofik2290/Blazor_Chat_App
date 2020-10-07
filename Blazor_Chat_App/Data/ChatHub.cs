using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Blazor_Chat_App.Data
{
    public class ChatHub:Hub
    {
        List<string> userList = new List<string>();

        public async Task SendMsg(string user, string msg) => await Clients.All.SendAsync("ReceiveMessage", user, msg);

        public async Task SendNewUser(string newUser)
        {
            userList.Add(newUser);

            await Clients.All.SendAsync("ReceiveUserList", userList);
        }

        public async Task RemoveUserL(string user)
        {
            /*userList.RemoveAt(userList.IndexOf(user));*/

            await Clients.All.SendAsync("RemoveUserFromList", user);
        }
    }
}
