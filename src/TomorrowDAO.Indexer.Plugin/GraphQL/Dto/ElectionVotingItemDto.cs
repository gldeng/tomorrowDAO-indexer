namespace TomorrowDAO.Indexer.Plugin.GraphQL.Dto;

public class ElectionVotingItemDto
{
    public long Count { get; set; }
    public List<ElectionVotingItem> Data { get; set; }
}

public class ElectionVotingItem
{
    public string Id { get; set; }
    public string DaoId { get; set; }
    public string VotingItemId { get; set; }
    public string AcceptedCurrency { get; set; }
    public bool IsLockToken { get; set; }
    public long CurrentSnapshotNumber { get; set; }
    public long TotalSnapshotNumber { get; set; }
    public string Options { get; set; }
    public DateTime RegisterTimestamp { get; set; }
    public DateTime StartTimestamp { get; set; }
    public DateTime EndTimestamp { get; set; }
    public DateTime CurrentSnapshotStartTimestamp { get; set; }
    public string Sponsor { get; set; }
    public bool IsQuadratic { get; set; }
    public long TicketCost { get; set; }

    public string ChainId { get; set; }
    public string BlockHash { get; set; }
    public long BlockHeight { get; set; }
    public string PreviousBlockHash { get; set; }
    public bool IsDeleted { get; set; }
}

public class GetElectionVotingItemIndexInput
{
    public string ChainId { get; set; }
    public string DaoId { get; set; }
    public int SkipCount { get; set; } = 0;
    public int MaxResultCount { get; set; } = 10;
}