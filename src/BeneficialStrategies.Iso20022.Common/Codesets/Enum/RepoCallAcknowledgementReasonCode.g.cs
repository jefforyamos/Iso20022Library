﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RepoCallAcknowledgementReasonCode.  ISO2002 ID# _ZSvUuNp-Ed-ak6NoX_4Aeg_-2001170938.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies additional information about the repurchase agreement call processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZSvUuNp-Ed-ak6NoX_4Aeg_-2001170938")]
[Description(@"Specifies additional information about the repurchase agreement call processed instruction.")]
[Derivations(typeof(RepoCallAcknowledgementReason2Code),typeof(RepoCallAcknowledgementReason1Code))]
public enum RepoCallAcknowledgementReasonCode
{
    /// <summary>
    /// Received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZS5FsNp-Ed-ak6NoX_4Aeg_-859698405")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Repurchase agreement call is in process.
    /// Encoded/decoded by serializers as "CALD".
    /// </summary>
    [EnumMember(Value = "CALD")]
    [IsoId("_ZS5Fsdp-Ed-ak6NoX_4Aeg_-858775491")]
    [Description(@"Repurchase agreement call is in process.")]
    InProcess,
    
    /// <summary>
    /// Repurchase agreement call is issued.
    /// Encoded/decoded by serializers as "CALI".
    /// </summary>
    [EnumMember(Value = "CALI")]
    [IsoId("_ZS5Fstp-Ed-ak6NoX_4Aeg_-857851394")]
    [Description(@"Repurchase agreement call is issued.")]
    Issued,
    
    /// <summary>
    /// Repurchase agreement call is processed.
    /// Encoded/decoded by serializers as "CALP".
    /// </summary>
    [EnumMember(Value = "CALP")]
    [IsoId("_ZS5Fs9p-Ed-ak6NoX_4Aeg_-856002365")]
    [Description(@"Repurchase agreement call is processed.")]
    Processed,
    
    /// <summary>
    /// Repurchase agreement call request is being processed.
    /// Encoded/decoded by serializers as "CALR".
    /// </summary>
    [EnumMember(Value = "CALR")]
    [IsoId("_ZS5FtNp-Ed-ak6NoX_4Aeg_-855078844")]
    [Description(@"Repurchase agreement call request is being processed.")]
    BeingProcessed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RepoCallAcknowledgementReasonCodeMetadataExtensions
{
    private static readonly RepoCallAcknowledgementReasonCodeDropdownSource _dropdownSource = new RepoCallAcknowledgementReasonCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRepoCallAcknowledgementReasonCodeDropdownRow GetMetadata(this RepoCallAcknowledgementReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


