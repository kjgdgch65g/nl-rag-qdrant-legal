namespace RAG_Qdrant_Legal
{
    public static class LegalDocConfig
    {
        public const string QdrantUrl = "http://localhost:6333";
        public const string OllamaUrl = "http://localhost:11434";
        public const string EmbeddingModel = "nomic-embed-text:latest";
        public const string ChatModel = "gemma3:1b";
        public const string IndexName = "legal-documents";
    }
}

