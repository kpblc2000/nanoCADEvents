using HostMgd.ApplicationServices;
using System;

namespace nanoCADEvents
{
    public partial class ExtensionInitalize
    {
        private void OnDocumentToBeDestroyedEvent(object sender, DocumentCollectionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnDocumentCreatedEvent(object sender, DocumentCollectionEventArgs e)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            if (doc == null)
            {
                return;
            }

            doc.CommandCancelled += OnCommandCancelledEvent;
            doc.CommandEnded += OnCommandEndedEvent;
            doc.CommandFailed += OnCommandFailedEvent;
            doc.CommandWillStart += OnCommandWillStartEvent;
        }

       
    }
}
