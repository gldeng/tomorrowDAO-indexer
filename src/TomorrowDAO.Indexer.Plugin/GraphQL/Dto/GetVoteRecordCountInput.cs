namespace TomorrowDAO.Indexer.Plugin.GraphQL.Dto;

public class GetVoteRecordCountInput
{
    public string ChainId { get; set; }
    public string DaoId { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }
}