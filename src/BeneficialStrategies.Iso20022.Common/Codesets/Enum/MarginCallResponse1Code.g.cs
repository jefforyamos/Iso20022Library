﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MarginCallResponse1Code.  ISO2002 ID# _Yc8VJtp-Ed-ak6NoX_4Aeg_-352735605.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the margin call request was sent on a non valuation day or was received after notification time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yc8VJtp-Ed-ak6NoX_4Aeg_-352735605")]
[Description(@"Specifies whether the margin call request was sent on a non valuation day or was received after notification time.")]
[DerivedFrom(typeof(MarginCallResponseCode))]
public enum MarginCallResponse1Code
{
    /// <summary>
    /// Indicates that the margin call request was sent on a non valuation day.
    /// Encoded/decoded by serializers as "NonValuationDay".
    /// </summary>
    [EnumMember(Value = "NVDA")]
    [IsoId("_Yc8VJ9p-Ed-ak6NoX_4Aeg_661474467")]
    [Description(@"Indicates that the margin call request was sent on a non valuation day.")]
    NonValuationDay,
    
    /// <summary>
    /// Indicates that the margin call request was sent after the notification time.
    /// Encoded/decoded by serializers as "ReceivedAfterNotificationTime".
    /// </summary>
    [EnumMember(Value = "RANT")]
    [IsoId("_Yc8VKNp-Ed-ak6NoX_4Aeg_-631136566")]
    [Description(@"Indicates that the margin call request was sent after the notification time.")]
    ReceivedAfterNotificationTime,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MarginCallResponse1CodeMetadataExtensions
{
    private static readonly MarginCallResponse1CodeDropdownSource _dropdownSource = new MarginCallResponse1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMarginCallResponse1CodeDropdownRow GetMetadata(this MarginCallResponse1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


