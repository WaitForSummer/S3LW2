using System;

namespace LW2
{
    public  class DocumentWorker
    {
        public DocumentWorker() { }

        public void OpenDocument()
        {
            Console.WriteLine("The document is open.");
        }

        public virtual void EditDocument() 
        {
            Console.WriteLine("Document editing is available in the Pro version.");
        }

        public virtual void SaveDocument() 
        {
            Console.WriteLine("Saving the document is available in the Pro version.");
        }

        public virtual void Print() 
        {
            this.OpenDocument();
            this.EditDocument();
            this.SaveDocument();
        }
    }

    public class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("The document has been edited.");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version.");
        }
    }

    public class ExpertDocumentWorker: ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("The document has been saved in a new format.");
        }
    }
}
