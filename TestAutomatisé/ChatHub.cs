using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using TestAutomatisé.Controllers;

namespace TestAutomatisé
{
    public class ChatHub : Hub
    {
        //#region Data Members

        //static List<UserDetail> ConnectedUsers = new List<UserDetail>();
        //static List<MessageDetail> CurrentMessage = new List<MessageDetail>();

        //#endregion

        //#region Methods

        //public void Connect(string username)
        //{
        //    var id = Context.ConnectionId;

        //    if (ConnectedUsers.Count(x => x.ConnectionId == id) == 0)
        //    {
        //        ConnectedUsers.Add(new UserDetail { ConnectionId = id, UserName = username });

        //        //Send to caller
        //        Clients.Caller.onConnected(id, username, ConnectedUsers, CurrentMessage);

        //        //Send to all expect caller client

        //        Clients.AllExcept(id).onNewUserConnected(id, username);
        //    }
        //}

        //public void SendMessageToAll(String userName, String message)
        //{
        //    //Historique des 100 derniers message en cache
        //    AddMessageinCache(userName, message);

        //    //Broad Cast message
        //    Clients.All.messageReceived(userName, message);
        //}

        //public void SendPrivateMessage(string touserId, string message)
        //{
        //    string fromUserId = Context.ConnectionId;

        //    var toUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == touserId);
        //    var fromUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == fromUserId);

        //    if (toUser != null && fromUser != null)
        //    {
        //        //Envoyer à
        //        Clients.Client(touserId).sendPrivateMessage(fromUserId, fromUser.UserName, message);

        //        //Send to caller user
        //        Clients.Caller.sendPrivateMessage(touserId, fromUser.UserName, message);
        //    }
        //}

        //public override System.Threading.Tasks.Task OnDisconnected()
        //{
        //    var item = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
        //    if (item != null)
        //    {
        //        ConnectedUsers.Remove(item);
        //        var id = Context.ConnectionId;
        //        Clients.All.onUserDisconnected(id, item.UserName);
        //    }

        //    return base.OnDisconnected();
        //}


        //#endregion

        //#region Private Messages

        //private void AddMessageinCache(String userName, String message)
        //{
        //    CurrentMessage.Add(new MessageDetail { UserName = userName, Message = message });
        //    if (CurrentMessage.Count > 100)
        //        CurrentMessage.RemoveAt(0);
        //}
        //#endregion
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}