namespace RAG_Qdrant_Legal
{
    public class LegalDocument
    {
        [Microsoft.Extensions.VectorData.VectorStoreKey]
        public Guid Key {get;set;} = Guid.NewGuid();

        [Microsoft.Extensions.VectorData.VectorStoreData]
        public string Title {get;set;}= null!;

        [Microsoft.Extensions.VectorData.VectorStoreData]
        public string Content {get;set;}= null!;

        [Microsoft.Extensions.VectorData.VectorStoreVector(384, DistanceFunction = Microsoft.Extensions.VectorData.DistanceFunction.CosineSimilarity)]
        public ReadOnlyMemory<float> Vector {get;set;}
    }
}
