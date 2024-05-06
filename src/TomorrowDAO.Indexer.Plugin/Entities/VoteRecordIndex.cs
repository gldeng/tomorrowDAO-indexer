using AElf.Indexing.Elasticsearch;
using AElfIndexer.Client;
using Nest;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TomorrowDAO.Indexer.Plugin.Enums;

namespace TomorrowDAO.Indexer.Plugin.Entities;

public class VoteRecordIndex : AElfIndexerClientEntity<string>, IIndexBuild
{
    [Keyword] public override string Id { get; set; }
    
    // The voting activity id.(proposal id)
    [Keyword] public string VotingItemId { get; set; }
    
    [Keyword] public string Voter { get; set; }
    
    public int Amount { get; set; }
    
    [JsonConverter(typeof(StringEnumConverter))]
    public VoteOption Option { get; set; }
    
    public DateTime VoteTime { get; set; }
    
    public bool IsFinished { get; set; }
}
