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
    /// ??
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZjbcGNp-Ed-ak6NoX_4Aeg_1066393063")]
    [Description(@"??")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZjlNENp-Ed-ak6NoX_4Aeg_1066393115")]
    [Description(@"??")]
    InvalidSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZjlNEdp-Ed-ak6NoX_4Aeg_1066393158")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZjlNEtp-Ed-ak6NoX_4Aeg_1481977131")]
    [Description(@"??")]
    ReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZjlNE9p-Ed-ak6NoX_4Aeg_-1967966501")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZjlNFNp-Ed-ak6NoX_4Aeg_-1184235378")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZjlNFdp-Ed-ak6NoX_4Aeg_-66977480")]
    [Description(@"??")]
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


