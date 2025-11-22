using Microsoft.KernelMemory;
using System.Text.RegularExpressions;

namespace RAG_Qdrant_Legal
{
    public class LegalDocumentImporter
    {
        public async Task ImportLegalDocumentData(IKernelMemory memory)
        {
            Console.WriteLine("Importing legal document data with real embeddings...");
            var documents = LegalDocumentData.GetDocuments();
            foreach (var doc in documents)
            {
                var docText = $"Title: {doc.Title}\nContent: {doc.Content}";
                // QDrant document IDs can only use A-Z a-z 0-9 . _ -
                var safeTitle = Regex.Replace(doc.Title.ToLower(), @"[^a-z0-9._-]", "-");
                var documentId = $"legal-{safeTitle}";

                await memory.ImportTextAsync(
                    text: docText,
                    documentId: documentId,
                    index: LegalDocConfig.IndexName,
                    tags: new TagCollection {
                        { "title", doc.Title },
                        { "type", "legal-document" },
                        { "source", "sample-legal-database" }
                    });

                Console.WriteLine($"Imported: {doc.Title} (ID: {documentId})");
            }
            Console.WriteLine($"Successfully imported {documents.Count} legal documents with real embeddings!");
        }
    }
}

