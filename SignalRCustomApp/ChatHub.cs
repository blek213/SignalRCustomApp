using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRCustomApp
{
    public class ChatHub : Hub
    {
        public async Task Send(string username, string message)
        {
            await this.Clients.All.SendAsync("Send", username, message);
        }

    }
}
