using TomorrowDAO.Indexer.Plugin.Entities;
using TomorrowDAO.Indexer.Plugin.Enums;

namespace TomorrowDAO.Indexer.Plugin.GraphQL.Dto;

public class ProposalSyncDto
{
    public string Id { get; set; }
    
    public string DAOId { get; set; }

    public string ProposalId { get; set; }

    public string ProposalTitle { get; set; }
    
    public string ProposalDescription { get; set; }
    
    public string ForumUrl { get; set; }
    
    public ProposalType ProposalType { get; set; }
    
    public DateTime ActiveStartTime { get; set; }
   
    public DateTime ActiveEndTime { get; set; }
    
    public DateTime ExecuteStartTime { get; set; }

    public DateTime ExecuteEndTime { get; set; }
    
    public ProposalStatus ProposalStatus { get; set; }
    
    public ProposalStage ProposalStage { get; set; }
    
    public string Proposer { get; set; }
    
    public string SchemeAddress { get; set; }
    
    public ExecuteTransaction Transaction { get; set; }
    
    public string VoteSchemeId { get; set; }
    
    public string VetoProposalId { get; set; }

    public DateTime DeployTime { get; set; }

    public DateTime? ExecuteTime { get; set; }   
    
    public GovernanceMechanism GovernanceMechanism { get; set; }
    
    public int MinimalRequiredThreshold { get; set; }
    
    public int MinimalVoteThreshold { get; set; }
    
    //percentage            
    public int MinimalApproveThreshold { get; set; }
    
    //percentage    
    public int MaximalRejectionThreshold { get; set; }
    
    //percentage    
    public int MaximalAbstentionThreshold { get; set; }
    
    public long ActiveTimePeriod { get; set; }
    
    public long VetoActiveTimePeriod { get; set; }
    
    public long PendingTimePeriod { get; set; }
    
    public long ExecuteTimePeriod { get; set; }
    
    public long VetoExecuteTimePeriod { get; set; }
}