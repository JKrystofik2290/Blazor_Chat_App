using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Blazor_Chat_App.Data
{
    public class ChatHub:Hub
    {
        public async Task SendMsg(string user, string msg) => await Clients.All.SendAsync("ReceiveMessage", user, msg);
    }
}
