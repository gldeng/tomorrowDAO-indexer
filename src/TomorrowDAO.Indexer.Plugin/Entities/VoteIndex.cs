using AElf.Indexing.Elasticsearch;
using AElfIndexer.Client;
using Nest;

namespace TomorrowDAO.Indexer.Plugin.Entities;

public class VoteIndex : AElfIndexerClientEntity<string>, IIndexBuild
{
    [Keyword] public override string Id { get; set; }
    
    // The voting activity id.(proposal id)
    [Keyword] public string VotingItemId { get; set; }
    
    [Keyword] public string VoteSchemeId { get; set; }
    
    [PropertyName("DAOId")]
    [Keyword] public string DAOId { get; set; }
        
    [Keyword] public string AcceptedCurrency { get; set; }
   
    public int ApprovedCount { get; set; }
    
    public int RejectionCount { get; set; }
        
    public int AbstentionCount { get; set; }
                
    public int VotesAmount { get; set; }    
    
    [Keyword] public HashSet<string> VoterSet { get; set; } 
        
    public DateTime RegisterTime { get; set; }
    
    public DateTime StartTime { get; set; }
        
    public DateTime EndTime { get; set; }
    
    public DateTime CreateTime { get; set; }
}