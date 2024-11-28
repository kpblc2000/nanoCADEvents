using System;
using System.Runtime.CompilerServices;

namespace nanoCADEvents.Services
{
    internal class MessageService
    {
        public void ConsoleMessage(string message, [CallerMemberName] string caller = null)
        {
            throw new NotImplementedException();
        }

        public void CommandStartedMessage(string command)
        {
            throw new NotImplementedException();
        }

        public void CommandEndedMessage(string command)
        {
            throw new NotImplementedException();
        }
    }
}
