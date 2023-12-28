﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MarginCallResponseCode.  ISO2002 ID# _YdGGINp-Ed-ak6NoX_4Aeg_420355985.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the margin call request was sent on a non valuation day or was received after notification time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YdGGINp-Ed-ak6NoX_4Aeg_420355985")]
[Description(@"Specifies whether the margin call request was sent on a non valuation day or was received after notification time.")]
public enum MarginCallResponseCode
{
    /// <summary>
    /// Indicates that the margin call request was sent on a non valuation day.
    /// Encoded/decoded by serializers as "NVDA".
    /// </summary>
    [EnumMember(Value = "NVDA")]
    [IsoId("_YdGGIdp-Ed-ak6NoX_4Aeg_-1089065484")]
    [Description(@"Indicates that the margin call request was sent on a non valuation day.")]
    NonValuationDay,
    
    /// <summary>
    /// Indicates that the margin call request was sent after the notification time.
    /// Encoded/decoded by serializers as "RANT".
    /// </summary>
    [EnumMember(Value = "RANT")]
    [IsoId("_YdGGItp-Ed-ak6NoX_4Aeg_-1747873600")]
    [Description(@"Indicates that the margin call request was sent after the notification time.")]
    ReceivedAfterNotificationTime,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MarginCallResponseCodeMetadataExtensions
{
    private static readonly MarginCallResponseCodeDropdownSource _dropdownSource = new MarginCallResponseCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMarginCallResponseCodeDropdownRow GetMetadata(this MarginCallResponseCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

