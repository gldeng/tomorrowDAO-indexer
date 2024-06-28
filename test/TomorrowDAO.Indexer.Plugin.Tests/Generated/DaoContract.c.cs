// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/contract/dao_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace TomorrowDAO.Contracts.DAO {

  #region Events
  public partial class DAOCreated : aelf::IEvent<DAOCreated>
  {
    public global::System.Collections.Generic.IEnumerable<DAOCreated> GetIndexed()
    {
      return new List<DAOCreated>
      {
      };
    }

    public DAOCreated GetNonIndexed()
    {
      return new DAOCreated
      {
        Metadata = Metadata,
        GovernanceToken = GovernanceToken,
        DaoId = DaoId,
        Creator = Creator,
        ContractAddressList = ContractAddressList,
        IsNetworkDao = IsNetworkDao,
        TreasuryAddress = TreasuryAddress,
        GovernanceMechanism = GovernanceMechanism,
      };
    }
  }

  public partial class SubsistStatusSet : aelf::IEvent<SubsistStatusSet>
  {
    public global::System.Collections.Generic.IEnumerable<SubsistStatusSet> GetIndexed()
    {
      return new List<SubsistStatusSet>
      {
      };
    }

    public SubsistStatusSet GetNonIndexed()
    {
      return new SubsistStatusSet
      {
        DaoId = DaoId,
        Status = Status,
      };
    }
  }

  public partial class HighCouncilEnabled : aelf::IEvent<HighCouncilEnabled>
  {
    public global::System.Collections.Generic.IEnumerable<HighCouncilEnabled> GetIndexed()
    {
      return new List<HighCouncilEnabled>
      {
      };
    }

    public HighCouncilEnabled GetNonIndexed()
    {
      return new HighCouncilEnabled
      {
        DaoId = DaoId,
        HighCouncilInput = HighCouncilInput,
        HighCouncilAddress = HighCouncilAddress,
      };
    }
  }

  public partial class HighCouncilDisabled : aelf::IEvent<HighCouncilDisabled>
  {
    public global::System.Collections.Generic.IEnumerable<HighCouncilDisabled> GetIndexed()
    {
      return new List<HighCouncilDisabled>
      {
      };
    }

    public HighCouncilDisabled GetNonIndexed()
    {
      return new HighCouncilDisabled
      {
        DaoId = DaoId,
      };
    }
  }

  public partial class FileInfosUploaded : aelf::IEvent<FileInfosUploaded>
  {
    public global::System.Collections.Generic.IEnumerable<FileInfosUploaded> GetIndexed()
    {
      return new List<FileInfosUploaded>
      {
      };
    }

    public FileInfosUploaded GetNonIndexed()
    {
      return new FileInfosUploaded
      {
        DaoId = DaoId,
        UploadedFiles = UploadedFiles,
      };
    }
  }

  public partial class FileInfosRemoved : aelf::IEvent<FileInfosRemoved>
  {
    public global::System.Collections.Generic.IEnumerable<FileInfosRemoved> GetIndexed()
    {
      return new List<FileInfosRemoved>
      {
      };
    }

    public FileInfosRemoved GetNonIndexed()
    {
      return new FileInfosRemoved
      {
        DaoId = DaoId,
        RemovedFiles = RemovedFiles,
      };
    }
  }

  public partial class MetadataUpdated : aelf::IEvent<MetadataUpdated>
  {
    public global::System.Collections.Generic.IEnumerable<MetadataUpdated> GetIndexed()
    {
      return new List<MetadataUpdated>
      {
      };
    }

    public MetadataUpdated GetNonIndexed()
    {
      return new MetadataUpdated
      {
        DaoId = DaoId,
        Metadata = Metadata,
      };
    }
  }

  public partial class MemberAdded : aelf::IEvent<MemberAdded>
  {
    public global::System.Collections.Generic.IEnumerable<MemberAdded> GetIndexed()
    {
      return new List<MemberAdded>
      {
      };
    }

    public MemberAdded GetNonIndexed()
    {
      return new MemberAdded
      {
        DaoId = DaoId,
        AddMembers = AddMembers,
      };
    }
  }

  public partial class MemberRemoved : aelf::IEvent<MemberRemoved>
  {
    public global::System.Collections.Generic.IEnumerable<MemberRemoved> GetIndexed()
    {
      return new List<MemberRemoved>
      {
      };
    }

    public MemberRemoved GetNonIndexed()
    {
      return new MemberRemoved
      {
        DaoId = DaoId,
        RemoveMembers = RemoveMembers,
      };
    }
  }

  #endregion
  public static partial class DAOContractContainer
  {
    static readonly string __ServiceName = "DAOContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.InitializeInput> __Marshaller_InitializeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.InitializeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.CreateDAOInput> __Marshaller_CreateDAOInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.CreateDAOInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.SetSubsistStatusInput> __Marshaller_SetSubsistStatusInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.SetSubsistStatusInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Hash> __Marshaller_aelf_Hash = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Hash.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.DAOInfo> __Marshaller_DAOInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.DAOInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.Metadata> __Marshaller_Metadata = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.Metadata.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.BoolValue> __Marshaller_google_protobuf_BoolValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.BoolValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.ContractAddressList> __Marshaller_ContractAddressList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.ContractAddressList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.EnableHighCouncilInput> __Marshaller_EnableHighCouncilInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.EnableHighCouncilInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.UploadFileInfosInput> __Marshaller_UploadFileInfosInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.UploadFileInfosInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.RemoveFileInfosInput> __Marshaller_RemoveFileInfosInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.RemoveFileInfosInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.FileInfoList> __Marshaller_FileInfoList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.FileInfoList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.HasPermissionInput> __Marshaller_HasPermissionInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.HasPermissionInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.AddCreatorPermissionsInput> __Marshaller_AddCreatorPermissionsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.AddCreatorPermissionsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.UpdateMetadataInput> __Marshaller_UpdateMetadataInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.UpdateMetadataInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.UpdateGovernanceSchemeThresholdInput> __Marshaller_UpdateGovernanceSchemeThresholdInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.UpdateGovernanceSchemeThresholdInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.RemoveGovernanceSchemeInput> __Marshaller_RemoveGovernanceSchemeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.RemoveGovernanceSchemeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.SetGovernanceTokenInput> __Marshaller_SetGovernanceTokenInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.SetGovernanceTokenInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.SetProposalTimePeriodInput> __Marshaller_SetProposalTimePeriodInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.SetProposalTimePeriodInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.AddMemberInput> __Marshaller_AddMemberInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.AddMemberInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.RemoveMemberInput> __Marshaller_RemoveMemberInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.RemoveMemberInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::TomorrowDAO.Contracts.DAO.GetIsMemberInput> __Marshaller_GetIsMemberInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TomorrowDAO.Contracts.DAO.GetIsMemberInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int64Value> __Marshaller_google_protobuf_Int64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Initialize = new aelf::Method<global::TomorrowDAO.Contracts.DAO.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Initialize",
        __Marshaller_InitializeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.CreateDAOInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateDAO = new aelf::Method<global::TomorrowDAO.Contracts.DAO.CreateDAOInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateDAO",
        __Marshaller_CreateDAOInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.SetSubsistStatusInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetSubsistStatus = new aelf::Method<global::TomorrowDAO.Contracts.DAO.SetSubsistStatusInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetSubsistStatus",
        __Marshaller_SetSubsistStatusInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Hash, global::TomorrowDAO.Contracts.DAO.DAOInfo> __Method_GetDAOInfo = new aelf::Method<global::AElf.Types.Hash, global::TomorrowDAO.Contracts.DAO.DAOInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetDAOInfo",
        __Marshaller_aelf_Hash,
        __Marshaller_DAOInfo);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Types.Hash> __Method_GetDAOIdByName = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Types.Hash>(
        aelf::MethodType.View,
        __ServiceName,
        "GetDAOIdByName",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Types.Hash, global::TomorrowDAO.Contracts.DAO.Metadata> __Method_GetMetadata = new aelf::Method<global::AElf.Types.Hash, global::TomorrowDAO.Contracts.DAO.Metadata>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMetadata",
        __Marshaller_aelf_Hash,
        __Marshaller_Metadata);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.BoolValue> __Method_GetSubsistStatus = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.BoolValue>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSubsistStatus",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_BoolValue);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.StringValue> __Method_GetGovernanceToken = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.StringValue>(
        aelf::MethodType.View,
        __ServiceName,
        "GetGovernanceToken",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_StringValue);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::TomorrowDAO.Contracts.DAO.ContractAddressList> __Method_GetInitializedContracts = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::TomorrowDAO.Contracts.DAO.ContractAddressList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetInitializedContracts",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_ContractAddressList);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address> __Method_GetReferendumAddress = new aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetReferendumAddress",
        __Marshaller_aelf_Hash,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address> __Method_GetHighCouncilAddress = new aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetHighCouncilAddress",
        __Marshaller_aelf_Hash,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.EnableHighCouncilInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_EnableHighCouncil = new aelf::Method<global::TomorrowDAO.Contracts.DAO.EnableHighCouncilInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "EnableHighCouncil",
        __Marshaller_EnableHighCouncilInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DisableHighCouncil = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "DisableHighCouncil",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.BoolValue> __Method_GetHighCouncilStatus = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.BoolValue>(
        aelf::MethodType.View,
        __ServiceName,
        "GetHighCouncilStatus",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_BoolValue);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.UploadFileInfosInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UploadFileInfos = new aelf::Method<global::TomorrowDAO.Contracts.DAO.UploadFileInfosInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "UploadFileInfos",
        __Marshaller_UploadFileInfosInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.RemoveFileInfosInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveFileInfos = new aelf::Method<global::TomorrowDAO.Contracts.DAO.RemoveFileInfosInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RemoveFileInfos",
        __Marshaller_RemoveFileInfosInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Hash, global::TomorrowDAO.Contracts.DAO.FileInfoList> __Method_GetFileInfos = new aelf::Method<global::AElf.Types.Hash, global::TomorrowDAO.Contracts.DAO.FileInfoList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetFileInfos",
        __Marshaller_aelf_Hash,
        __Marshaller_FileInfoList);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.HasPermissionInput, global::Google.Protobuf.WellKnownTypes.BoolValue> __Method_HasPermission = new aelf::Method<global::TomorrowDAO.Contracts.DAO.HasPermissionInput, global::Google.Protobuf.WellKnownTypes.BoolValue>(
        aelf::MethodType.View,
        __ServiceName,
        "HasPermission",
        __Marshaller_HasPermissionInput,
        __Marshaller_google_protobuf_BoolValue);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.AddCreatorPermissionsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddCreatorPermissions = new aelf::Method<global::TomorrowDAO.Contracts.DAO.AddCreatorPermissionsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddCreatorPermissions",
        __Marshaller_AddCreatorPermissionsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.UpdateMetadataInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateMetadata = new aelf::Method<global::TomorrowDAO.Contracts.DAO.UpdateMetadataInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "UpdateMetadata",
        __Marshaller_UpdateMetadataInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.UpdateGovernanceSchemeThresholdInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateGovernanceSchemeThreshold = new aelf::Method<global::TomorrowDAO.Contracts.DAO.UpdateGovernanceSchemeThresholdInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "UpdateGovernanceSchemeThreshold",
        __Marshaller_UpdateGovernanceSchemeThresholdInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.RemoveGovernanceSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveGovernanceScheme = new aelf::Method<global::TomorrowDAO.Contracts.DAO.RemoveGovernanceSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RemoveGovernanceScheme",
        __Marshaller_RemoveGovernanceSchemeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.SetGovernanceTokenInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetGovernanceToken = new aelf::Method<global::TomorrowDAO.Contracts.DAO.SetGovernanceTokenInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetGovernanceToken",
        __Marshaller_SetGovernanceTokenInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.SetProposalTimePeriodInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetProposalTimePeriod = new aelf::Method<global::TomorrowDAO.Contracts.DAO.SetProposalTimePeriodInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetProposalTimePeriod",
        __Marshaller_SetProposalTimePeriodInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetTreasuryContractAddress = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetTreasuryContractAddress",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address> __Method_GetTreasuryAddress = new aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetTreasuryAddress",
        __Marshaller_aelf_Hash,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.AddMemberInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddMember = new aelf::Method<global::TomorrowDAO.Contracts.DAO.AddMemberInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddMember",
        __Marshaller_AddMemberInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.RemoveMemberInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveMember = new aelf::Method<global::TomorrowDAO.Contracts.DAO.RemoveMemberInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RemoveMember",
        __Marshaller_RemoveMemberInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::TomorrowDAO.Contracts.DAO.GetIsMemberInput, global::Google.Protobuf.WellKnownTypes.BoolValue> __Method_GetIsMember = new aelf::Method<global::TomorrowDAO.Contracts.DAO.GetIsMemberInput, global::Google.Protobuf.WellKnownTypes.BoolValue>(
        aelf::MethodType.View,
        __ServiceName,
        "GetIsMember",
        __Marshaller_GetIsMemberInput,
        __Marshaller_google_protobuf_BoolValue);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetMemberCount = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMemberCount",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_Int64Value);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TomorrowDAO.Contracts.DAO.DaoContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS12.Acs12Reflection.Descriptor.Services[0],
          global::TomorrowDAO.Contracts.DAO.DaoContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    /// <summary>Base class for the contract of DAOContract</summary>
    // public abstract partial class DAOContractBase : AElf.Sdk.CSharp.CSharpSmartContract<TomorrowDAO.Contracts.DAO.DAOContractState>
    // {
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty Initialize(global::TomorrowDAO.Contracts.DAO.InitializeInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty CreateDAO(global::TomorrowDAO.Contracts.DAO.CreateDAOInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty SetSubsistStatus(global::TomorrowDAO.Contracts.DAO.SetSubsistStatusInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::TomorrowDAO.Contracts.DAO.DAOInfo GetDAOInfo(global::AElf.Types.Hash input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::AElf.Types.Hash GetDAOIdByName(global::Google.Protobuf.WellKnownTypes.StringValue input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::TomorrowDAO.Contracts.DAO.Metadata GetMetadata(global::AElf.Types.Hash input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.BoolValue GetSubsistStatus(global::AElf.Types.Hash input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.StringValue GetGovernanceToken(global::AElf.Types.Hash input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::TomorrowDAO.Contracts.DAO.ContractAddressList GetInitializedContracts(global::Google.Protobuf.WellKnownTypes.Empty input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::AElf.Types.Address GetReferendumAddress(global::AElf.Types.Hash input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::AElf.Types.Address GetHighCouncilAddress(global::AElf.Types.Hash input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty EnableHighCouncil(global::TomorrowDAO.Contracts.DAO.EnableHighCouncilInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty DisableHighCouncil(global::AElf.Types.Hash input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.BoolValue GetHighCouncilStatus(global::AElf.Types.Hash input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty UploadFileInfos(global::TomorrowDAO.Contracts.DAO.UploadFileInfosInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveFileInfos(global::TomorrowDAO.Contracts.DAO.RemoveFileInfosInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::TomorrowDAO.Contracts.DAO.FileInfoList GetFileInfos(global::AElf.Types.Hash input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.BoolValue HasPermission(global::TomorrowDAO.Contracts.DAO.HasPermissionInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty AddCreatorPermissions(global::TomorrowDAO.Contracts.DAO.AddCreatorPermissionsInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateMetadata(global::TomorrowDAO.Contracts.DAO.UpdateMetadataInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateGovernanceSchemeThreshold(global::TomorrowDAO.Contracts.DAO.UpdateGovernanceSchemeThresholdInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveGovernanceScheme(global::TomorrowDAO.Contracts.DAO.RemoveGovernanceSchemeInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty SetGovernanceToken(global::TomorrowDAO.Contracts.DAO.SetGovernanceTokenInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty SetProposalTimePeriod(global::TomorrowDAO.Contracts.DAO.SetProposalTimePeriodInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty SetTreasuryContractAddress(global::AElf.Types.Address input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::AElf.Types.Address GetTreasuryAddress(global::AElf.Types.Hash input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty AddMember(global::TomorrowDAO.Contracts.DAO.AddMemberInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveMember(global::TomorrowDAO.Contracts.DAO.RemoveMemberInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.BoolValue GetIsMember(global::TomorrowDAO.Contracts.DAO.GetIsMemberInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Int64Value GetMemberCount(global::AElf.Types.Hash input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    // }
    //
    // public static aelf::ServerServiceDefinition BindService(DAOContractBase serviceImpl)
    // {
    //   return aelf::ServerServiceDefinition.CreateBuilder()
    //       .AddDescriptors(Descriptors)
    //       .AddMethod(__Method_Initialize, serviceImpl.Initialize)
    //       .AddMethod(__Method_CreateDAO, serviceImpl.CreateDAO)
    //       .AddMethod(__Method_SetSubsistStatus, serviceImpl.SetSubsistStatus)
    //       .AddMethod(__Method_GetDAOInfo, serviceImpl.GetDAOInfo)
    //       .AddMethod(__Method_GetDAOIdByName, serviceImpl.GetDAOIdByName)
    //       .AddMethod(__Method_GetMetadata, serviceImpl.GetMetadata)
    //       .AddMethod(__Method_GetSubsistStatus, serviceImpl.GetSubsistStatus)
    //       .AddMethod(__Method_GetGovernanceToken, serviceImpl.GetGovernanceToken)
    //       .AddMethod(__Method_GetInitializedContracts, serviceImpl.GetInitializedContracts)
    //       .AddMethod(__Method_GetReferendumAddress, serviceImpl.GetReferendumAddress)
    //       .AddMethod(__Method_GetHighCouncilAddress, serviceImpl.GetHighCouncilAddress)
    //       .AddMethod(__Method_EnableHighCouncil, serviceImpl.EnableHighCouncil)
    //       .AddMethod(__Method_DisableHighCouncil, serviceImpl.DisableHighCouncil)
    //       .AddMethod(__Method_GetHighCouncilStatus, serviceImpl.GetHighCouncilStatus)
    //       .AddMethod(__Method_UploadFileInfos, serviceImpl.UploadFileInfos)
    //       .AddMethod(__Method_RemoveFileInfos, serviceImpl.RemoveFileInfos)
    //       .AddMethod(__Method_GetFileInfos, serviceImpl.GetFileInfos)
    //       .AddMethod(__Method_HasPermission, serviceImpl.HasPermission)
    //       .AddMethod(__Method_AddCreatorPermissions, serviceImpl.AddCreatorPermissions)
    //       .AddMethod(__Method_UpdateMetadata, serviceImpl.UpdateMetadata)
    //       .AddMethod(__Method_UpdateGovernanceSchemeThreshold, serviceImpl.UpdateGovernanceSchemeThreshold)
    //       .AddMethod(__Method_RemoveGovernanceScheme, serviceImpl.RemoveGovernanceScheme)
    //       .AddMethod(__Method_SetGovernanceToken, serviceImpl.SetGovernanceToken)
    //       .AddMethod(__Method_SetProposalTimePeriod, serviceImpl.SetProposalTimePeriod)
    //       .AddMethod(__Method_SetTreasuryContractAddress, serviceImpl.SetTreasuryContractAddress)
    //       .AddMethod(__Method_GetTreasuryAddress, serviceImpl.GetTreasuryAddress)
    //       .AddMethod(__Method_AddMember, serviceImpl.AddMember)
    //       .AddMethod(__Method_RemoveMember, serviceImpl.RemoveMember)
    //       .AddMethod(__Method_GetIsMember, serviceImpl.GetIsMember)
    //       .AddMethod(__Method_GetMemberCount, serviceImpl.GetMemberCount).Build();
    // }

  }
}
#endregion

