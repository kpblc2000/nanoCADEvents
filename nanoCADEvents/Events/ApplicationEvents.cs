using HostMgd.ApplicationServices;
using nanoCADEvents.Services;

namespace nanoCADEvents
{
    public partial class ExtensionInitalize
    {
        private void OnDocumentToBeDestroyedEvent(object sender, DocumentCollectionEventArgs e)
        {
            MessageService msgService = new MessageService();
            msgService.InfoMessage("Document start to be destroyed");
        }

        private void OnDocumentCreatedEvent(object sender, DocumentCollectionEventArgs e)
        {
            MessageService msgService = new MessageService();
            msgService.InfoMessage("Document created");
        }
    }
}
