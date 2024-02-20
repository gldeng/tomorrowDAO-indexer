using AElfIndexer.Client;
using AElfIndexer.Client.Handlers;
using AElfIndexer.Grains.State.Client;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TomorrowDAO.Contracts.Election;
using TomorrowDAO.Indexer.Plugin.Entities;
using TomorrowDAO.Indexer.Plugin.Enums;
using TomorrowDAO.Indexer.Plugin.Processors.DAO;
using Volo.Abp.ObjectMapping;

namespace TomorrowDAO.Indexer.Plugin.Processors.Election;

public class CandidateInfoUpdatedProcessor : ElectionProcessorBase<CandidateInfoUpdated>
{
    public CandidateInfoUpdatedProcessor(ILogger<DAOProcessorBase<CandidateInfoUpdated>> logger, IObjectMapper objectMapper, 
        IOptionsSnapshot<ContractInfoOptions> contractInfoOptions, 
        IAElfIndexerClientEntityRepository<ElectionIndex, LogEventInfo> electionRepository) : base(logger, objectMapper, contractInfoOptions, electionRepository)
    {
    }

    protected override async Task HandleEventAsync(CandidateInfoUpdated eventValue, LogEventContext context)
    {
        var DAOId = eventValue.DaoId.ToHex();
        var chainId = context.ChainId;
        var candidate = eventValue.CandidateAddress.ToBase58();
        Logger.LogInformation("[CandidateInfoUpdated] START: Id={Id}, ChainId={ChainId}, Candidate={candidate}",
            DAOId, chainId, candidate);
        try
        {
            var electionIndex = await ElectionRepository.GetFromBlockStateSetAsync(IdGenerateHelper
                .GetId(chainId, DAOId, candidate, CandidateTerm, HighCouncilType.Candidate), chainId);
            if (electionIndex != null)
            {
                electionIndex.IsRemoved = true;
                await SaveIndexAsync(electionIndex, context);
            }

            if (eventValue.IsEvilNode)
            {
                await SaveIndexAsync(new ElectionIndex 
                {
                    IsRemoved = false,
                    Address = candidate,
                    DAOId = DAOId,
                    TermNumber = CandidateTerm,
                    HighCouncilType = HighCouncilType.BlackList,
                    Id = IdGenerateHelper.GetId(chainId, DAOId, candidate, CandidateTerm, HighCouncilType.BlackList) 
                }, context);
                Logger.LogInformation("[CandidateInfoUpdated] FINISH: Id={Id}, ChainId={ChainId}, Candidate={candidate}", DAOId, chainId, candidate); 
            }
        }
        catch (Exception e)
        {
            Logger.LogError(e, "[CandidateInfoUpdated] Exception Id={DAOId}, ChainId={ChainId}, Candidate={candidate}", DAOId, chainId, candidate);
            throw;
        }
    }
}