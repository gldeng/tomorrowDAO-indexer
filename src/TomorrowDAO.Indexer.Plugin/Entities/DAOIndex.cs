using AElf.Indexing.Elasticsearch;
using AElfIndexer.Client;
using Nest;

namespace TomorrowDAO.Indexer.Plugin.Entities;

public class DAOIndex : AElfIndexerClientEntity<string>, IIndexBuild
{
    [Keyword] public override string Id { get; set; }
    [Keyword] public string Creator { get; set; }
    [Keyword] public string MetadataAdmin { get; set; }
    public Metadata Metadata { get; set; }
    [Keyword] public string GovernanceToken { get; set; }
    public bool IsHighCouncilEnabled { get; set; }
    public HighCouncilConfig HighCouncilConfig { get; set; }
    public long HighCouncilTermNumber { get; set; }
    [Keyword] public string FileInfoList { get; set; }
    public bool IsTreasuryContractNeeded { get; set; }
    public bool IsVoteContractNeeded { get; set; }
    public bool SubsistStatus { get; set; }
    [Keyword] public string TreasuryContractAddress { get; set; }
    [Keyword] public string TreasuryAccountAddress { get; set; }
    public bool IsTreasuryPause { get; set; }
    [Keyword] public string TreasuryPauseExecutor { get; set; }
    [Keyword] public string VoteContractAddress { get; set; }
    [Keyword] public string PermissionAddress { get; set; }
    [Keyword] public string PermissionInfoList { get; set; }
    public DateTime CreateTime { get; set; }
}