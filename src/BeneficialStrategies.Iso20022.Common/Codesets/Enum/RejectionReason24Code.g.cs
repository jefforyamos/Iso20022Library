﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason24Code.  ISO2002 ID# _ZjbcF9p-Ed-ak6NoX_4Aeg_-1383112473.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the request has a rejected or repair status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZjbcF9p-Ed-ak6NoX_4Aeg_-1383112473")]
[Description(@"Specifies the reason why the request has a rejected or repair status.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum RejectionReason24Code
{
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZjbcGNp-Ed-ak6NoX_4Aeg_1066393063")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ZjlNENp-Ed-ak6NoX_4Aeg_1066393115")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_ZjlNEdp-Ed-ak6NoX_4Aeg_1066393158")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZjlNEtp-Ed-ak6NoX_4Aeg_1481977131")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection,
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZjlNE9p-Ed-ak6NoX_4Aeg_-1967966501")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZjlNFNp-Ed-ak6NoX_4Aeg_-1184235378")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Statement/status advice request cannot be executed. The message type requested is not valid for the message reference or statement period concerned.
    /// Encoded/decoded by serializers as "InvalidRequest".
    /// </summary>
    [EnumMember(Value = "MISM")]
    [IsoId("_ZjlNFdp-Ed-ak6NoX_4Aeg_-66977480")]
    [Description(@"Statement/status advice request cannot be executed. The message type requested is not valid for the message reference or statement period concerned.")]
    InvalidRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason24CodeMetadataExtensions
{
    private static readonly RejectionReason24CodeDropdownSource _dropdownSource = new RejectionReason24CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason24CodeDropdownRow GetMetadata(this RejectionReason24Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


