using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRCustomApp
{
    public class ChatHub : Hub
    {
    //    private IHostingEnvironment _hostingEnvironment;

        static object locker = new object();


        //public ChatHub(IHostingEnvironment environment)
        //{
        //    _hostingEnvironment = environment;
        //}

        public async Task Send(string username, string message)
        {
            //lock (locker)
            //{
            //   // var path = Path.Combine(_hostingEnvironment.WebRootPath, "Sample.PNG");

            //    FileStream file1 = new FileStream(("~/content/messages.txt"), FileMode.Append);
            //    StreamWriter writer = new StreamWriter(file1);

            //    writer.Write(username + ":" + message + "\r");
            //    writer.Close();
            //}

            await this.Clients.All.SendAsync("Send", username, message);
        }

    }
}
