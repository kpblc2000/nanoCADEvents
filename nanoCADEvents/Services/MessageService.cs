using HostMgd.ApplicationServices;
using HostMgd.EditorInput;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Application = HostMgd.ApplicationServices.Application;

namespace nanoCADEvents.Services
{
    internal class MessageService
    {
        public void ConsoleMessage(string message, [CallerMemberName] string caller = null)
        {
            try
            {
                Document doc = Application.DocumentManager.MdiActiveDocument;
                if (doc == null)
                {
                    InfoMessage(message, caller);
                    return;
                }

                Editor ed = doc.Editor;
                ed.WriteMessage((string.IsNullOrEmpty(caller) ? "" : $"{caller} : ") + message);
            }
            catch { }
        }

        public void CommandStartedMessage(string command)
        {
            ConsoleMessage($"{_title} - {command} started", null);
        }

        public void CommandEndedMessage(string command)
        {
            ConsoleMessage($"{_title} - {command} ended", null);
        }

        public void CommandFailedMessage(string command)
        {
            ConsoleMessage($"{_title} - {command} failed", null);
        }

        public void CommandCancelledMessage(string command)
        {
            ConsoleMessage($"{_title} - {command} cancelled", null);
        }

        public void InfoMessage(string message, [CallerMemberName] string caller = null)
        {
            MessageBox.Show(message, _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private readonly string _title = typeof(MessageService).Assembly.GetName().Name + " v." +
                                         typeof(MessageService).Assembly.GetName().Version;
    }
}
