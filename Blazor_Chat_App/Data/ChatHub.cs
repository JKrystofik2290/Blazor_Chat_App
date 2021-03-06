﻿using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Blazor_Chat_App.Data
{
    public class ChatHub : Hub
    {
        List<string> userList = new List<string>();
        string envVar = Environment.GetEnvironmentVariable("userList");

        public async Task SendUserList(List<string> userList)
        {
            await Clients.All.SendAsync("ReceiveUserList", (envVar == null) ? new List<string>() : envVar.Split(",").ToList());
        }

        public async Task SendMsg(string user, string msg, string flag) => await Clients.All.SendAsync("ReceiveMessage", user, msg, flag);

        public async Task SendNewUser(string newUser)
        {
            List<string> userList = (envVar == null) ? new List<string>() : envVar.Split(",").ToList();
            userList.Add(newUser);
            string temp = String.Join(",", userList.ToArray());
            Environment.SetEnvironmentVariable("userList", temp);

            await Clients.All.SendAsync("ReceiveUserList", userList);
        }

        public async Task RemoveUser(string user)
        {
            List<string> userList = (envVar == null) ? new List<string>() : envVar.Split(",").ToList();

            if (userList.Contains(user))
            {
                userList.RemoveAt(userList.IndexOf(user));
                string temp = String.Join(",", userList.ToArray());
                Environment.SetEnvironmentVariable("userList", temp);
            }

            await Clients.All.SendAsync("ReceiveUserList", userList);
        }
    }
}
