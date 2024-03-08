using AElfIndexer.Client;
using AElfIndexer.Client.Handlers;
using AElfIndexer.Grains.State.Client;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TomorrowDAO.Contracts.Governance;
using TomorrowDAO.Indexer.Plugin.Entities;
using TomorrowDAO.Indexer.Plugin.Processors.Provider;
using Volo.Abp.ObjectMapping;
using ProposalStage = TomorrowDAO.Indexer.Plugin.Enums.ProposalStage;
using ProposalStatus = TomorrowDAO.Indexer.Plugin.Enums.ProposalStatus;

namespace TomorrowDAO.Indexer.Plugin.Processors.Proposal;

public class ProposalVetoedProcessor : ProposalProcessorBase<ProposalVetoed>
{
    public ProposalVetoedProcessor(ILogger<AElfLogEventProcessorBase<ProposalVetoed, LogEventInfo>> logger,
        IObjectMapper objectMapper,
        IOptionsSnapshot<ContractInfoOptions> contractInfoOptions,
        IAElfIndexerClientEntityRepository<ProposalIndex, LogEventInfo> proposalRepository,
        IGovernanceProvider governanceProvider, IDAOProvider DAOProvider) :
        base(logger, objectMapper, contractInfoOptions, proposalRepository, governanceProvider, DAOProvider)
    {
    }

    protected override async Task HandleEventAsync(ProposalVetoed eventValue, LogEventContext context)
    {
        var chainId = context.ChainId;
        var proposalId = eventValue.ProposalId?.ToHex();
        var vetoProposalId = eventValue.VetoProposalId?.ToHex();
        Logger.LogInformation("[ProposalVetoed] start proposalId:{proposalId} chainId:{chainId} vetoProposalId {vetoProposalId}", proposalId, chainId, vetoProposalId);
        try
        {
            UpdateVetoProposal(proposalId, ProposalStatus.Executed, ProposalStage.Finished, context.BlockTime, context);
            UpdateVetoProposal(vetoProposalId, ProposalStatus.Vetoed, ProposalStage.Finished, context);
            Logger.LogInformation("[ProposalVetoed] end proposalId:{proposalId} chainId:{chainId} vetoProposalId {vetoProposalId}", proposalId, chainId, vetoProposalId);
        }
        catch (Exception e)
        {
            Logger.LogError(e, "[ProposalVetoed] Exception proposalId:{proposalId} chainId:{chainId} vetoProposalId {vetoProposalId}", proposalId, chainId, vetoProposalId);
            throw;
        }
    }
}