﻿using HostMgd.ApplicationServices;
using System;
using Teigha.Runtime;

namespace nanoCADEvents
{
    public partial class ExtensionInitalize : IExtensionApplication
    {
        public void Initialize()
        {
            Application.DocumentManager.DocumentCreated += OnDocumentCreatedEvent;
            Application.DocumentManager.DocumentToBeDestroyed += OnDocumentToBeDestroyedEvent;

            Document doc = Application.DocumentManager.MdiActiveDocument;
            if (doc != null)
            {
                OnDocumentCreatedEvent(null, null);
                doc.CommandCancelled += OnCommandCancelledEvent;
                doc.CommandEnded += OnCommandEndedEvent;
                doc.CommandFailed += OnCommandFailedEvent;
                doc.CommandWillStart += OnCommandWillStartEvent;
            }
        }
        
        public void Terminate() { }
    }
}
