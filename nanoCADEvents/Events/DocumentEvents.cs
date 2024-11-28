using HostMgd.ApplicationServices;
using nanoCADEvents.Services;

namespace nanoCADEvents
{
    public partial class ExtensionInitalize
    {
        private void OnCommandWillStartEvent(object sender, CommandEventArgs e)
        {
            MessageService msgService = new MessageService();
            msgService.CommandStartedMessage(e.GlobalCommandName);
        }

        private void OnCommandFailedEvent(object sender, CommandEventArgs e)
        {
            MessageService msgService = new MessageService();
            msgService.CommandFailedMessage(e.GlobalCommandName);
        }

        private void OnCommandEndedEvent(object sender, CommandEventArgs e)
        {
            MessageService msgService = new MessageService();
            msgService.CommandEndedMessage(e.GlobalCommandName);
        }

        private void OnCommandCancelledEvent(object sender, CommandEventArgs e)
        {
            MessageService msgService = new MessageService();
            msgService.CommandCancelledMessage(e.GlobalCommandName);
        }
    }
}
