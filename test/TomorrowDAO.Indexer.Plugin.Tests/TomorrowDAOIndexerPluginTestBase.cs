using AElf;
using AElf.CSharp.Core.Extension;
using AElf.Types;
using AElfIndexer.Client;
using AElfIndexer.Client.Handlers;
using AElfIndexer.Client.Providers;
using AElfIndexer.Grains;
using AElfIndexer.Grains.State.Client;
using Google.Protobuf.WellKnownTypes;
using TomorrowDAO.Contracts.DAO;
using TomorrowDAO.Contracts.Treasury;
using TomorrowDAO.Indexer.Orleans.TestBase;
using TomorrowDAO.Indexer.Plugin.Entities;
using TomorrowDAO.Indexer.Plugin.Processors.DAO;
using TomorrowDAO.Indexer.Plugin.Processors.Treasury;
using TomorrowDAO.Indexer.Plugin.Tests.Helper;
using File = TomorrowDAO.Contracts.DAO.File;
using FileInfo = TomorrowDAO.Contracts.DAO.FileInfo;
using Metadata = TomorrowDAO.Contracts.DAO.Metadata;

namespace TomorrowDAO.Indexer.Plugin.Tests;

public abstract class TomorrowDAOIndexerPluginTestBase : TomorrowDAOIndexerOrleansTestBase<TomorrowDAOIndexerPluginTestModule>
{
    private readonly IAElfIndexerClientInfoProvider _indexerClientInfoProvider;
    public IBlockStateSetProvider<LogEventInfo> BlockStateSetLogEventInfoProvider;
    private readonly IBlockStateSetProvider<TransactionInfo> _blockStateSetTransactionInfoProvider;
    private readonly IDAppDataProvider _dAppDataProvider;
    private readonly IDAppDataIndexManagerProvider _dAppDataIndexManagerProvider;
    protected readonly IAElfIndexerClientEntityRepository<DAOIndex, LogEventInfo> DAOIndexRepository;
    protected readonly IAElfIndexerClientEntityRepository<TreasuryFundIndex, LogEventInfo> TreasuryFundRepository;
    protected readonly IAElfIndexerClientEntityRepository<TreasuryRecordIndex, LogEventInfo> TreasuryRecordRepository;
    protected readonly DAOCreatedProcessor DAOCreatedProcessor;
    protected readonly FileInfosRemovedProcessor FileInfosRemovedProcessor;
    protected readonly FileInfosUploadedProcessor FileInfosUploadedProcessor;
    protected readonly HighCouncilDisabledProcessor HighCouncilDisabledProcessor;
    protected readonly HighCouncilEnabledProcessor HighCouncilEnabledProcessor;
    protected readonly PermissionsSetProcessor PermissionsSetProcessor;
    protected readonly SubsistStatusSetProcessor SubsistStatusSetProcessor;
    protected readonly DonationReceivedProcessor DonationReceivedProcessor;
    protected readonly TreasuryCreatedProcessor TreasuryCreatedProcessor;
    protected readonly TreasuryTokenLockedProcessor TreasuryTokenLockedProcessor;
    protected readonly EmergencyTransferredProcessor EmergencyTransferredProcessor;
    protected readonly PausedProcessor PausedProcessor;
    protected readonly SupportedStakingTokensAddedProcessor SupportedStakingTokensAddedProcessor;
    protected readonly SupportedStakingTokensRemovedProcessor SupportedStakingTokensRemovedProcessor;
    protected readonly TokenStakedProcessor TokenStakedProcessor;
    protected readonly TreasuryTokenUnlockedProcessor TreasuryTokenUnlockedProcessor;
    protected readonly private TreasuryTransferReleasedProcessor TreasuryTransferReleasedProcessor;
    protected readonly private UnpausedProcessor UnpausedProcessor;
    

    protected readonly long BlockHeight = 120;
    protected readonly string ChainAelf = "tDVV";
    protected static readonly string Id1 = "123";
    protected static readonly string Id2 = "456";
    protected static readonly string ProposalId = "p-1";
    protected readonly string DAOId = HashHelper.ComputeFrom(Id1).ToHex();
    protected readonly string DAOName = "DAOName";
    protected readonly string DAOLogoUrl = "DAOLogoUrl";
    protected readonly string DAODescription = "DAODescription";
    protected readonly string DAOSocialMedia = "{ \"name\": \"url\" }";
    protected readonly string DAOMetadataAdmin = "2N9DJYUUruS7bFqRyKMvafA75qTWgqpWcB78nNZzpmxHrMv4D";
    protected readonly string DAO = "2N9DJYUUruS7bFqRyKMvafA75qTWgqpWcB78nNZzpmxHrMv4D";
    protected readonly string Elf = "ELF";
    protected readonly string GovernanceSchemeId = HashHelper.ComputeFrom(Id2).ToHex();
    protected static readonly string SubId = "456-1";
    protected readonly string FileHash = "FileHash";
    protected readonly string FileCid = "FileCid";
    protected readonly string FileName = "FileName";
    protected readonly string FileUrl = "FileUrl";
    protected readonly string DAOCreator = "2fbCtXNLVD2SC4AD6b8nqAkHtjqxRCfwvciX4MyH6257n8Gf63";
    protected readonly string Creator = "2fbCtXNLVD2SC4AD6b8nqAkHtjqxRCfwvciX4MyH6257n8Gf63";
    protected readonly string OrganizationAddress = "UE6mcinaCFJZmGNgY9fpMnyzwMETJUhqwbnvtjRgX1f12rBQj";
    protected readonly string ExecuteAddress = "aLyxCJvWMQH6UEykTyeWAcYss9baPyXkrMQ37BHnUicxD2LL3";
    protected readonly string ExecuteAddressNew = "nH1x6TMcS2f2gRUTUgUGWmcBdwnXJipeZTgNXb2dxPkPaBd4M";
    protected readonly string ExecuteContractAddress = "YeCqKprLBGbZZeRTkN1FaBLXsetY8QFotmVKqo98w9K6jK2PY";
    protected readonly string ProposalDescription = HashHelper.ComputeFrom("ProposalDescription").ToHex();
    protected readonly string TreasuryContractAddress = "7RzVGiuVWkvL4VfVHdZfQF2Tri3sgLe9U991bohHFfSRZXuGX";
    protected readonly string VoteContractAddress = "vQfjcuW3RbGmkcL74YY4q3BX9UcH5rmwLmbQi3PsZxg8vE9Uk";
    protected readonly string ElectionContractAddress = "YeCqKprLBGbZZeRTkN1FaBLXsetY8QFotmVKqo98w9K6jK2PY";
    protected readonly string GovernanceContractAddress = "HJfhXPPL3Eb2wYPAc6ePmirenNzqGBAsynyeYF9tKSV2kHTAF";
    protected readonly string TimelockContractAddress = "7VzrKvnFRjrK4duJz8HNA1nWf2AJcxwwGXzTtC4MC3tKUtdbH";
    protected readonly string TreasuryAccountAddress = "pykr77ft9UUKJZLVq15wCH8PinBSjVRQ12sD1Ayq92mKFsJ1i";

    // protected readonly int MinimalRequiredThreshold = 1;
    // protected readonly int MinimalVoteThreshold = 2;
    // protected readonly int MinimalApproveThreshold = 3;
    // protected readonly int MaximalAbstentionThreshold = 4;
    // protected readonly int MaximalRejectionThreshold = 5;
    protected readonly int MaxHighCouncilCandidateCount = 1;
    protected readonly int MaxHighCouncilMemberCount = 2;
    protected readonly int ElectionPeriod = 3;


    public TomorrowDAOIndexerPluginTestBase()
    {
        _indexerClientInfoProvider = GetRequiredService<IAElfIndexerClientInfoProvider>();
        BlockStateSetLogEventInfoProvider = GetRequiredService<IBlockStateSetProvider<LogEventInfo>>();
        _blockStateSetTransactionInfoProvider = GetRequiredService<IBlockStateSetProvider<TransactionInfo>>();
        _dAppDataProvider = GetRequiredService<IDAppDataProvider>();
        _dAppDataIndexManagerProvider = GetRequiredService<IDAppDataIndexManagerProvider>();
        DAOIndexRepository = GetRequiredService<IAElfIndexerClientEntityRepository<DAOIndex, LogEventInfo>>();
        TreasuryFundRepository = GetRequiredService<IAElfIndexerClientEntityRepository<TreasuryFundIndex, LogEventInfo>>();
        TreasuryRecordRepository = GetRequiredService<IAElfIndexerClientEntityRepository<TreasuryRecordIndex, LogEventInfo>>();
        FileInfosRemovedProcessor = GetRequiredService<FileInfosRemovedProcessor>();
        FileInfosUploadedProcessor = GetRequiredService<FileInfosUploadedProcessor>();
        HighCouncilDisabledProcessor = GetRequiredService<HighCouncilDisabledProcessor>();
        HighCouncilEnabledProcessor = GetRequiredService<HighCouncilEnabledProcessor>();
        PermissionsSetProcessor = GetRequiredService<PermissionsSetProcessor>();
        SubsistStatusSetProcessor = GetRequiredService<SubsistStatusSetProcessor>();
        DAOCreatedProcessor = GetRequiredService<DAOCreatedProcessor>();
        DonationReceivedProcessor = GetRequiredService<DonationReceivedProcessor>();
        TreasuryCreatedProcessor = GetRequiredService<TreasuryCreatedProcessor>();
        TreasuryTokenLockedProcessor = GetRequiredService<TreasuryTokenLockedProcessor>();
        EmergencyTransferredProcessor = GetRequiredService<EmergencyTransferredProcessor>();
        PausedProcessor = GetService<PausedProcessor>();
        SupportedStakingTokensAddedProcessor = GetRequiredService<SupportedStakingTokensAddedProcessor>();
        SupportedStakingTokensRemovedProcessor = GetRequiredService<SupportedStakingTokensRemovedProcessor>();
        TokenStakedProcessor = GetRequiredService<TokenStakedProcessor>();
        TreasuryTokenUnlockedProcessor = GetRequiredService<TreasuryTokenUnlockedProcessor>();
        TreasuryTransferReleasedProcessor = GetRequiredService<TreasuryTransferReleasedProcessor>();
        UnpausedProcessor = GetRequiredService<UnpausedProcessor>();
    }

    protected async Task<string> InitializeBlockStateSetAsync(BlockStateSet<LogEventInfo> blockStateSet, string chainId)
    {
        var key = GrainIdHelper.GenerateGrainId("BlockStateSets", _indexerClientInfoProvider.GetClientId(), chainId,
            _indexerClientInfoProvider.GetVersion());

        await BlockStateSetLogEventInfoProvider.SetBlockStateSetAsync(key, blockStateSet);
        await BlockStateSetLogEventInfoProvider.SetCurrentBlockStateSetAsync(key, blockStateSet);
        await BlockStateSetLogEventInfoProvider.SetLongestChainBlockStateSetAsync(key, blockStateSet.BlockHash);

        return key;
    }

    protected async Task<string> InitializeBlockStateSetAsync(BlockStateSet<TransactionInfo> blockStateSet,
        string chainId)
    {
        var key = GrainIdHelper.GenerateGrainId("BlockStateSets", _indexerClientInfoProvider.GetClientId(), chainId,
            _indexerClientInfoProvider.GetVersion());

        await _blockStateSetTransactionInfoProvider.SetBlockStateSetAsync(key, blockStateSet);
        await _blockStateSetTransactionInfoProvider.SetCurrentBlockStateSetAsync(key, blockStateSet);
        await _blockStateSetTransactionInfoProvider.SetLongestChainBlockStateSetAsync(key, blockStateSet.BlockHash);

        return key;
    }

    protected async Task BlockStateSetSaveDataAsync<TSubscribeType>(string key)
    {
        await _dAppDataProvider.SaveDataAsync();
        await _dAppDataIndexManagerProvider.SavaDataAsync();
        if (typeof(TSubscribeType) == typeof(TransactionInfo))
            await _blockStateSetTransactionInfoProvider.SaveDataAsync(key);
        else if (typeof(TSubscribeType) == typeof(LogEventInfo))
            await BlockStateSetLogEventInfoProvider.SaveDataAsync(key);
    }

    protected LogEventContext MockLogEventContext(long inputBlockHeight = 100, string chainId = "tDVV")
    {
        const string blockHash = "dac5cd67a2783d0a3d843426c2d45f1178f4d052235a907a0d796ae4659103b1";
        const string previousBlockHash = "e38c4fb1cf6af05878657cb3f7b5fc8a5fcfb2eec19cd76b73abb831973fbf4e";
        const string transactionId = "c1e625d135171c766999274a00a7003abed24cfe59a7215aabf1472ef20a2da2";
        var blockHeight = inputBlockHeight;
        return new LogEventContext
        {
            ChainId = chainId,
            BlockHeight = blockHeight,
            BlockHash = blockHash,
            PreviousBlockHash = previousBlockHash,
            TransactionId = transactionId,
            BlockTime = DateTime.UtcNow,
            ExtraProperties = new Dictionary<string, string>
            {
                { "TransactionFee", "{\"ELF\": 10, \"DECIMAL\": 8}" },
                { "ResourceFee", "{\"ELF\": 10, \"DECIMAL\": 15}" }
            }
        };
    }

    protected LogEventInfo MockLogEventInfo(LogEvent logEvent)
    {
        var logEventInfo = LogEventHelper.ConvertAElfLogEventToLogEventInfo(logEvent);
        var logEventContext = MockLogEventContext(100);
        logEventInfo.BlockHeight = logEventContext.BlockHeight;
        logEventInfo.ChainId = logEventContext.ChainId;
        logEventInfo.BlockHash = logEventContext.BlockHash;
        logEventInfo.TransactionId = logEventContext.TransactionId;
        logEventInfo.BlockTime = DateTime.Now;
        return logEventInfo;
    }

    protected async Task<string> MockBlockState(LogEventContext logEventContext)
    {
        var blockStateSet = new BlockStateSet<LogEventInfo>
        {
            BlockHash = logEventContext.BlockHash,
            BlockHeight = logEventContext.BlockHeight,
            Confirmed = true,
            PreviousBlockHash = logEventContext.PreviousBlockHash
        };
        return await InitializeBlockStateSetAsync(blockStateSet, logEventContext.ChainId);
    }

    protected async Task<string> MockBlockStateForTransactionInfo(LogEventContext logEventContext)
    {
        var blockStateSet = new BlockStateSet<TransactionInfo>
        {
            BlockHash = logEventContext.BlockHash,
            BlockHeight = logEventContext.BlockHeight,
            Confirmed = true,
            PreviousBlockHash = logEventContext.PreviousBlockHash
        };
        return await InitializeBlockStateSetAsync(blockStateSet, logEventContext.ChainId);
    }

    protected async Task MockEventProcess(LogEvent logEvent, IAElfLogEventProcessor processor)
    {
        var logEventContext = MockLogEventContext(BlockHeight, ChainAelf);

        // step1: create blockStateSet
        var blockStateSetKey = await MockBlockState(logEventContext);

        // step2: create logEventInfo
        var logEventInfo = MockLogEventInfo(logEvent);

        // step3 call the logic
        await processor.HandleEventAsync(logEventInfo, logEventContext);

        // step4 save data after logic
        await BlockStateSetSaveDataAsync<LogEventInfo>(blockStateSetKey);
    }

    protected LogEvent MaxInfoDAOCreated()
    {
        return new DAOCreated
        {
            Metadata = new Metadata
            {
                Name = DAOName,
                LogoUrl = DAOLogoUrl,
                Description = DAODescription,
                SocialMedia = { ["name"] = "url" }
            },
            GovernanceToken = Elf,
            DaoId = HashHelper.ComputeFrom(Id1),
            Creator = Address.FromBase58(DAOCreator),
            ContractAddressList = new ContractAddressList
            {
                TreasuryContractAddress = Address.FromBase58(TreasuryContractAddress),
                VoteContractAddress = Address.FromBase58(VoteContractAddress),
                ElectionContractAddress = Address.FromBase58(ElectionContractAddress),
                GovernanceContractAddress = Address.FromBase58(GovernanceContractAddress),
                TimelockContractAddress = Address.FromBase58(TimelockContractAddress)
            }
        }.ToLogEvent();
    }

    protected LogEvent MinInfoDAOCreated()
    {
        return new DAOCreated
        {
            DaoId = HashHelper.ComputeFrom(Id1)
        }.ToLogEvent();
    }

    protected LogEvent FileInfosRemoved()
    {
        return new FileInfosRemoved
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            RemovedFiles = GetFileInfoList()
        }.ToLogEvent();
    }
    
    protected LogEvent FileInfosUploaded()
    {
        return new FileInfosUploaded
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            UploadedFiles = GetFileInfoList()
        }.ToLogEvent();
    }

    protected FileInfoList GetFileInfoList()
    {
        return new FileInfoList
        {
            Data =
            {
                [FileCid] = new FileInfo
                {
                    File = new File{ Cid = FileCid, Name = FileName, Url = FileUrl},
                    UploadTime = new Timestamp(),
                    Uploader = Address.FromBase58(DAOCreator)
                }
            }
        };
    }
    
    protected LogEvent TreasuryCreated()
    {
        return new TreasuryCreated
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            TreasuryAccountAddress = Address.FromBase58(TreasuryAccountAddress),
            SymbolList = new SymbolList
            {
                Data = { Elf }
            }
        }.ToLogEvent();
    }
    
    protected LogEvent DonationReceived()
    {
        return new DonationReceived
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            Amount = 1L,
            DonationTime = new Timestamp(),
            Symbol = Elf,
            Donor = Address.FromBase58(DAOCreator)
        }.ToLogEvent();
    }
    
    protected LogEvent TreasuryTokenLocked()
    {
        return new TreasuryTokenLocked
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            LockInfo = new LockInfo
            {
                Amount = 1L,
                LockDdl = new Timestamp(),
                Symbol = Elf,
                ProposalId = HashHelper.ComputeFrom(Id1)
            },
            Proposer = Address.FromBase58(DAOCreator)
        }.ToLogEvent();
    }
    
    protected LogEvent EmergencyTransferred()
    {
        return new EmergencyTransferred
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            Account = Address.FromBase58(DAOCreator),
            Amount = 1L,
            Recipient = Address.FromBase58(DAOCreator),
            Symbol = Elf
        }.ToLogEvent();
    }
    
    protected LogEvent Paused()
    {
        return new Paused
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            Account = Address.FromBase58(DAOCreator)
        }.ToLogEvent();
    }
    
    protected LogEvent SupportedStakingTokensAdded()
    {
        return new SupportedStakingTokensAdded
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            AddedTokens = new SymbolList
            {
                Data = { Elf }
            }
        }.ToLogEvent();
    }
    
    protected LogEvent SupportedStakingTokensRemoved()
    {
        return new SupportedStakingTokensRemoved
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            RemovedTokens = new SymbolList
            {
                Data = { Elf }
            }
        }.ToLogEvent();
    }
    
    protected LogEvent TokenStaked()
    {
        return new TokenStaked
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            Account = Address.FromBase58(DAOCreator),
            Amount = 1L,
            StakedTime = new Timestamp(),
            Symbol = Elf
        }.ToLogEvent();
    }
    
    protected LogEvent TreasuryTokenUnlocked()
    {
        return new TreasuryTokenUnlocked
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            LockInfo = new LockInfo
            {
                Amount = 1L,
                LockDdl = new Timestamp(),
                Symbol = Elf,
                ProposalId = HashHelper.ComputeFrom(Id1)
            },
            Executor = Address.FromBase58(DAOCreator)
        }.ToLogEvent();
    }
    
    protected LogEvent TreasuryTransferReleased()
    {
        return new TreasuryTransferReleased
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            Amount = 1L,
            Recipient = Address.FromBase58(DAOCreator),
            Executor = Address.FromBase58(DAOCreator),
            Symbol = Elf
        }.ToLogEvent();
    }
    
    protected LogEvent Unpaused()
    {
        return new Unpaused
        {
            DaoId = HashHelper.ComputeFrom(Id1),
            Account = Address.FromBase58(DAOCreator)
        }.ToLogEvent();
    }
}